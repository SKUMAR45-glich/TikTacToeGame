using System;

namespace TikTacToeGame
{
    public class TikTacToeGame
    {
        static void Main(string[] args)
        {
            char []board = startGame();
            displayBoard(board);

        }
        public static void displayBoard(char [] board)
        {
            Console.WriteLine(board[1] + "|" + board[2] + "|" + board[3]);
            Console.WriteLine("\n"+board[4] + "|" + board[5] + "|" + board[6]);
            Console.WriteLine("\n"+board[7] + "|" + board[8] + "|" + board[9]);
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
    }
}
