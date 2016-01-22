using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Spock : IWinOrLose
    {
        public string Name;
        public Spock(string name)
        {
            this.Name = name;
        }

        public void DisplayLoss(string firstChoice, string secondChoice)
        {
            if (firstChoice == "spock" && secondChoice == "paper")
            {
                Console.WriteLine("The Paper disapproves Spock!");
            }
            else if (firstChoice == "spock" && secondChoice == "lizard")
            {
                Console.WriteLine("Spock is poisoned by the Lizard!");
            }
        }

        public void DisplayWin(string firstChoice, string secondChoice)
        {
            if (firstChoice == "spock" && secondChoice == "rock")
            {
                Console.WriteLine("Spock vaporizes the Rock!");
            }
            else if (firstChoice == "spock" && secondChoice == "scissors")
            {
                Console.WriteLine("Spock crushes the Scissors!");
            }
        }
    }
}
