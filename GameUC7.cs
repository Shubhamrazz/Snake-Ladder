using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    class GameUC7
    {
            public int Count_For_Dice1 = 0, Count_For_Dice2 = 0;
            public int WinningPosition = 100;
            public int Player1, Player2;
            public int StartPosition = 0;
            public string play;
            public void TwoPlayer()
            {
                bool Player1IsPlaying = true;

                int Player1_Position = StartPosition, Player2_Position = StartPosition, DiceRolledTimes = 0;
                Random random = new Random();
                while (Player1_Position != WinningPosition && Player2_Position != WinningPosition)
                {
                    int DiceRolled = random.Next(1, 7);//1 to 6
                    DiceRolledTimes++;
                    int ComputerChoice = random.Next(0, 3);//Choice to check its snake or ladder


                    switch (ComputerChoice)
                    {
                        case 0:
                            if (Player1IsPlaying)
                            {
                                Player1_Position += 0;
                                Player1IsPlaying = false;
                            }
                            else
                            {
                                Player2_Position += 0;
                                Player1IsPlaying = true;
                            }
                            break;
                        case 1:

                            if (Player1IsPlaying)
                            {
                                if (Player1_Position + DiceRolled <= WinningPosition)
                                {
                                    Player1_Position += DiceRolled;
                                    Console.WriteLine("Player 1 is on ladder");
                                }
                            }
                            else
                            {
                                if (Player2_Position + DiceRolled <= WinningPosition)
                                {
                                    Player2_Position = Player2_Position + DiceRolled;
                                    Console.WriteLine("Player 2 is on ladder");
                                }

                            }
                            break;
                        case 2:
                            if (Player1IsPlaying)
                            {
                                Player1_Position = Player1_Position - DiceRolled;
                                Player1IsPlaying = false;

                                if (Player1_Position < 0)
                                {
                                    Player1_Position = 0;
                                }
                                Console.WriteLine("Player1 landed on snake");
                            }
                            else
                            {
                                Player2_Position = Player2_Position - DiceRolled;
                                Player1IsPlaying = true;

                                if (Player2_Position < 0)
                                {
                                    Player2_Position = 0;
                                }
                                Console.WriteLine("Player2 landed on snake");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                    Console.WriteLine("Player 1 Position :" + Player1_Position);
                    Console.WriteLine("Player 2 Position :" + Player2_Position);
                }

                if (Player1_Position == WinningPosition)
                {
                    Console.WriteLine("Player 1 Won");
                }
                else
                {
                    Console.WriteLine("Player 2 Won");
                }
                Console.WriteLine("Dice was rolled for : " + DiceRolledTimes);

            }
    }
}
