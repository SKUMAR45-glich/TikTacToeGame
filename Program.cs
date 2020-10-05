using System;

namespace TikTacToeGame
{
    public class TikTacToeGame
    {
        static void Main(string[] args)
        {
            char []board = startGame();

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
    }
}
