using System;

namespace TikTacToeGame
{
    public class TikTacToeGame
    {
        static void Main(string[] args)
        {
            char []board = startGame();
            
            int userMove = getUserMove(board);
        }
        public static int getUserMove(char[] board)
        {

            Console.WriteLine("Enter your next move");
            int index = Convert.ToInt32(Console.ReadLine());
            if (board[index] == '\0')
            
            {
                return index;
            }
            else
            {
                return -1;
            }
        }

        public static char[] startGame()
        {
            char[] board = new char[10];
            for (int i = 0; i < 8; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
    }
}
