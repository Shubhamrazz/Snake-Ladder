using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    class GameUC4
    {
        public static void MovePosition()
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
                            Console.WriteLine("Got Ladder");
                            break;
                        case 2:
                            player_position = player_position - DiceRolled;//Moves back
                            Console.WriteLine("Snake Bites");
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                    if (player_position < 0)
                    {
                        player_position = 0;
                    }
                }
        }
    }
}
