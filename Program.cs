using System;

namespace TikTacToeGame
{
    public class TikTacToeGame
    {
        static void Main(string[] args)
        {
           
            char userletter = chooseLetter();
            char computerletter;
            if (userletter=='X')
            {
                computerletter = '0';
            }
            else
            {
                computerletter = 'X';
            }
            char[] board = new char[10];
           
            int computermove = computerMove(board, computerletter); 
        }
        public static char chooseLetter()
        {
            Console.WriteLine("Enter the text you want to use : X or 0");
            char option = Convert.ToChar(Console.ReadLine());
            return option;

        }
        public static int computerMove(char[] b, char c_letter)
        {
            Random random = new Random();
            int index = random.Next(0, 9);
            if(b[index]=='\0')
            {
                b[index] = c_letter;
                if (isComputerWinner(c_letter, b)) 
                {
                    return index;
                }
            }
            return 0;
        }
        public static bool isComputerWinner(char user, char [] b )
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
