using System;

namespace TikTacToeGame
{
    public class TikTacToeGame
    {
        public const int HEAD = 0;
        public const int TAIL = 1;
        public enum PLAYER { USER, COMPUTER};
        static void Main(string[] args)
        {
            char[] board = startGame();
            char userletter = chooseLetter();
            Console.WriteLine("Won:" + isUserWinner(userletter, board));

           
            //PLAYER player = whoStartsGame();
            
        }
        public static char[] startGame()
        {
            char[] board = new char[10];
            for (int i = 0; i < 10; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        public static char chooseLetter()
        {
            Console.WriteLine("Enter the text you want to use : X or 0");
            char option = Convert.ToChar(Console.ReadLine());
            return option;

        }
        public static bool isUserWinner(char user, char [] b )
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
