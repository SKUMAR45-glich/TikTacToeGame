using System;

namespace TikTacToeGame
{
    public class TikTacToeGame
    {
        public const int HEAD = 0;
        public const int TAIL = 1;
        public enum PLAYER { USER, COMPUTER };
        static void Main(string[] args)
        {
           
            char userletter = chooseLetter();
            char[] board = new char[10];
            char computerletter = (userletter =='X')? '0':'X';
            PLAYER player = whoStartsGame();
            bool playGame = true;
            
            while(playGame)
            {
                if(player.Equals(PLAYER.USER))
                {
                    Console.WriteLine("Enter the position to be filled");
                    int index = Convert.ToInt32(Console.ReadLine());
                    if (board[index] == '\0')
                    {
                        board[index] = userletter;
                        if (isWinner(userletter, board))
                        {
                            Console.WriteLine("Computer Won");
                            playGame = false;
                        }
                        else
                        {
                            player = PLAYER.COMPUTER;
                        }
                    }
                    else if (isBoardFull(board))
                    {

                        playGame = false;
                    }
                    else
                    {
                        Console.WriteLine("Enter at correct position");
                        player = PLAYER.USER;
                    }
                }
                else if (player.Equals(PLAYER.COMPUTER))
                {
                    Random random = new Random();
                    int index = random.Next(0, 9);
                    if (board[index] == '\0')
                    {
                        board[index] = computerletter;
                        if (isWinner(computerletter, board))
                        {
                            Console.WriteLine("Computer Won");
                            playGame = false;
                        }
                        else
                        {
                            player = PLAYER.USER;
                        }
                    }
                    else if (isBoardFull(board))
                    {

                        playGame = false;
                    }
                    else
                    {
                        Console.WriteLine("Enter at correct position");
                        player = PLAYER.COMPUTER;
                    }
                }
            }
        }
        
        
        public static char chooseLetter()
        {
            Console.WriteLine("Enter the text you want to use : X or 0");
            char option = Convert.ToChar(Console.ReadLine());
            return option;

        }
        public static PLAYER whoStartsGame()
        {
            Random random = new Random();
            int index = random.Next(0, 2);
            if (index == HEAD)
            {
                return PLAYER.USER;
            }
            else
            {
                return PLAYER.COMPUTER;
            }
        }
        public static bool isBoardFull(char[] b)
        {
            int check = 1;
            for(int i=1;i<10;i++)
            {
                if(b[i]!='\0')
                {
                    check = 0;
                }
            }
            if(check==0)
            {
                return false;
            }
            return true;
        }
        public static bool isWinner(char user, char [] b )
        {
            return ((b[1] == user && b[2] == user && b[3] == user) ||
                    (b[3] == user && b[4] == user && b[6] == user) ||
                    (b[7] == user && b[8] == user && b[9] == user) ||
                    (b[1] == user && b[4] == user && b[7] == user) ||
                    (b[1] == user && b[5] == user && b[9] == user) ||
                    (b[2] == user && b[5] == user && b[8] == user) ||
                    (b[3] == user && b[6] == user && b[9] == user) ||
                    (b[3] == user && b[5] == user && b[7] == user));
        }

    }
}
