using System;

namespace TikTacToeGame
{
    public class TikTacToeGame
    {
        static void Main(string[] args)
        {
            char []board = startGame();
            
            int userMove = getUserMove(board);
            Console.WriteLine("The user is at" + userMove);
           
        }
        public static int getUserMove(char[] board)
        {

            Console.WriteLine("Enter your next move");
            int index = Convert.ToInt32(Console.ReadLine());
            if (board[index] == '\0')
            
            {
                Console.WriteLine("There is availability at" + index);
                return index;
            }
            else
            {
                Console.WriteLine("There is no availability at" + index);
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
