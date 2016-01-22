using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            VsAI vsAI = new VsAI();
            VsAIHard vsHardAI = new VsAIHard();
            VsPlayer2 vsP2 = new VsPlayer2();
            VsPlayer2Hard vsP2Hard = new VsPlayer2Hard();
            string gameAIDifficulty;
            string gameP2Difficulty;

            Console.WriteLine("Press 1 to play against an opponent, or 2 to play against the computer");
            string gameChoice = Console.ReadLine();
            switch (gameChoice)
            {
                case "1":
                    Console.WriteLine("Do you want the play on [Normal] or [Hard] difficulty?");
                    Console.WriteLine("Normal is normal Rock, Paper, Scissors. Hard has Rock, Paper, Scissors, Lizard, Spock");
                    gameP2Difficulty = Console.ReadLine().ToLower();
                    if (gameP2Difficulty == "normal")
                    {
                        vsP2.VsOpponent();
                    }
                    else
                    {
                        vsP2Hard.VsOpponentHard();
                    }
                    break;

                case "2":
                    Console.WriteLine("Do you want the play on [Normal] or [Hard] difficulty?");
                    Console.WriteLine("Normal is normal Rock, Paper, Scissors. Hard has Rock, Paper, Scissors, Lizard, Spock");
                    gameAIDifficulty = Console.ReadLine().ToLower();
                    if (gameAIDifficulty == "normal")
                    {
                        vsAI.VsComputer();
                    }
                    else
                    {
                        vsHardAI.VsComputerHard();
                    }
                    
                    break;

                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }      
        }
    }
}
