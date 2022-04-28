using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    class GameUC2
    {
        public static void Beggin_Game()
        {
            int player_position = 0;//Variable

            Random random = new Random();
            int DiceRolled = random.Next(1, 7);//1 to 6
            Console.WriteLine("DiceRolled : {0}", DiceRolled);

            player_position = player_position + DiceRolled;

            Console.WriteLine("player_position: {0}", player_position);
        }
    }
}
