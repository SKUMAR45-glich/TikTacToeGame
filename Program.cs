using System;

namespace TikTacToeGame
{
    public class TikTacToeGame
    {
        static void Main(string[] args)
        {
           
            char userletter = chooseLetter();
            char[] board = new char[10];
            char computerletter;
            if (userletter=='X')
            {
                computerletter = '0';
            }
            else
            {
                computerletter = 'X';
            }
            
           
            int computermove = computerMove(board, computerletter); 
            int usermove = userMove(board, userletter); 
            if(computermove!=0)
            {
                Console.WriteLine("Computer is winner");
            }
            else if(usermove!=0)
            {
                Console.WriteLine("User is Winner");
            }
            else
            {
                int[] corners = { 1, 3, 7, 9 };
                int userchoice = userChoice(board, corners);
                if(userchoice!=0)
                {
                    Console.WriteLine("Enter the value at" +userchoice);
                }
                else
                {
                    if(board[5] == '\0')
                    {
                        Console.WriteLine("Enter the value at 5");
                    }
                    else
                    {
                        int[] side = { 2, 4, 6, 8 };
                        int cornerchoice = cornerChoice(board, side);
                        if(cornerchoice!=0)
                        {
                            Console.WriteLine("Enter the value at" + cornerchoice);
                        }
                        else
                        {
                            Console.WriteLine("Not Available");
                        }
                    }

                }
            }
        }
        public static int cornerChoice(char[] b, int[] side)
        {
            int index = Convert.ToInt32(Console.ReadLine());
            while (b[index] != '\0')
            {
                for (int i = 0; i < side.Length; i++)
                {
                    if (side[i] == index)
                    {
                        return index;
                    }
                }
            }
            return 0;
        }

        public static int userChoice(char[] b, int [] c)
        {
              int index = Convert.ToInt32(Console.ReadLine());
              while(b[index]!='\0')
              {
                 for(int i=0; i<c.Length;i++)
                 {
                     if(c[i]==index)
                     {
                        return index;
                     }
                 }
              }
            return 0;
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
                if (isWinner(c_letter, b)) 
                {
                    return index;
                }
            }
            return 0;
        }
        public static int userMove(char[] b, char u_letter)
        {
            Console.WriteLine("Enter the position to be filled");
            int index = Convert.ToInt32(Console.ReadLine());
            if (b[index] == '\0')
            {
                b[index] = u_letter;
                if (isWinner(u_letter, b))
                {
                    return index;
                }
            }
            return 0;
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
