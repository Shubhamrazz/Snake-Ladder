using System;

namespace Snake_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            GameUC1.Player();
            GameUC2.Beggin_Game();
            GameUC3.StartPlaying();
            GameUC4.MovePosition();
            GameUC5.ExactWinningPosition();
            GameUC6 die = new GameUC6();
            die.DiceRole();
            GameUC7 player = new GameUC7();
            player.TwoPlayer();
            Console.ReadLine();
        }
    }
}
