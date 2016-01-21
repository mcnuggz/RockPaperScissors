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
            VsPlayer2 vsP2 = new VsPlayer2();

            Console.WriteLine("Press 1 to play against an opponent, or 2 to play against the computer");
            string gameChoice = Console.ReadLine();
            switch (gameChoice)
            {
                case "1":
                    vsP2.VsOpponent();
                    break;
                case "2":
                    vsAI.VsComputer();
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }      
        }
    }
}
