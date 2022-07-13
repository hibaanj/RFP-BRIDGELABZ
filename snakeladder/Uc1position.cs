using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeladder
{
    internal class Uc1position
    {
        public void Position()
        {
            int PLAYER_POSITION = 0;
            Random rn = new Random();
            int dice = rn.Next(1, 7);
            PLAYER_POSITION = PLAYER_POSITION + dice;
            Console.WriteLine("the position of player is " + PLAYER_POSITION);
            


        }
        
    }
    public class Snakeladder
    {
        public static void Main(string[] args)
        {
            Uc1position uc1 = new Uc1position();
            uc1.Position();
        }
    }
}
