using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    class GameUC6
    { 
            public int count;
            public string play;
            public int No_Play = 0;
            public int Ladder = 1;
            public int Snake = 2;
         public void DiceRole()
         {
                int player_position = 0;

                while (player_position != 100)
                {
                    Random random = new Random();
                    int DiceRolled = random.Next(1, 7);//1 to 6
                    Console.WriteLine("DiceRolled : {0}", DiceRolled);

                    int ComputerChoice = random.Next(0, 3);//Choice to check its snake or ladder
                    Console.WriteLine("Dice value:" + ComputerChoice);

                    if (ComputerChoice == 0)
                    {
                        play = "No_Play";
                    }
                    else if (ComputerChoice == 1)
                    {
                        play = "Ladder";
                    }
                    else if (ComputerChoice == 2)
                    {
                        play = "Snake";
                    }
                    Console.WriteLine("Dice Value:" + play);

                    switch (play)
                    {
                        case "No_Play":
                            Console.WriteLine("No Play");
                            count++;
                            break;
                        case "Ladder":
                            player_position = player_position + DiceRolled;//Moving forward 
                            if (player_position > 100)
                            {
                                player_position = player_position - player_position;//stays in same position
                            }
                            Console.WriteLine("Exact Position" + player_position);
                            break;
                        case "Snake":
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
                    Console.WriteLine("Number of times dice rolled for winning the game" + count);
                }
         }
    }
}
