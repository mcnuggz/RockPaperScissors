using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Scissors : IWinOrLose
    {
        public string Name;
        public Scissors(string name)
        {
            this.Name = name;
        }

        public void DisplayLose(string firstChoice, string secondChoice)
        {
            if (firstChoice == "scissors" && secondChoice == "rock")
            {
                Console.WriteLine("The Rock crushed the Scissors!");
            }
            else if (firstChoice == "scissors" && secondChoice == "spock")
            {
                Console.WriteLine("Spock crushes the Scissors!");
            }
        }

        public void DisplayWin(string firstChoice, string secondChoice)
        {
            if (firstChoice == "scissors" && secondChoice == "paper")
            {
                Console.WriteLine("The Scissors cut the paper!");
            }
            else if (firstChoice == "scissors" && secondChoice == "lizard")
            {
                Console.WriteLine("The Scissors decapitates the Lizard!");
            }
        }
    }
}
