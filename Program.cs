using System;

namespace TikTacToeGame
{
    public class TikTacToeGame
    {
        static void Main(string[] args)
        {
            char []board = startGame();
            char option = chooseLetter();

        }
        public static char[] startGame()
        {
            char[] board = new char[10];
            for(int i=0;i<10;i++)
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
    }
}
