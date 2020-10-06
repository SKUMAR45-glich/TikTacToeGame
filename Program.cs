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
           
            PLAYER player = whoStartsGame();
            
        }
        public static PLAYER whoStartsGame()
        {
            Random random = new Random();
            int index = random.Next(0, 2);
            if(index == HEAD)
            {
                return PLAYER.USER;
            }
            else
            {
                return PLAYER.COMPUTER;
            }
        }
        
      
    }
}
