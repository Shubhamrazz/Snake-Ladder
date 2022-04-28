using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    class GameUC5
    {
         public static void ExactWinningPosition()
         {
                int player_position = 0;

                while (player_position != 100)
                {
                    Random random = new Random();
                    int DiceRolled = random.Next(1, 7);//1 to 6
                    Console.WriteLine("DiceRolled : {0}", DiceRolled);

                    int ComputerChoice = random.Next(0, 3);//Choice to check its snake or ladder
                    Console.WriteLine("Dice value:" + ComputerChoice);

                    switch (ComputerChoice)
                    {
                        case 0:
                            Console.WriteLine("No Play");
                            break;
                        case 1:
                            player_position = player_position + DiceRolled;//Moving forward 
                            if (player_position > 100)
                            {
                                player_position = player_position - player_position;//stays in same position
                            }
                            Console.WriteLine("Exact Position" + player_position);
                            break;
                        case 2:
                            player_position = player_position - DiceRolled;//Moves back
                            if (player_position < 0)
                            {
                                player_position = 0;
                            }
                            Console.WriteLine("Snake Bites :" + player_position);
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
         }
    }
}
