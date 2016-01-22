using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Lizard : IWinOrLose
    {
        public string Name;
        public Lizard(string name)
        {
            this.Name = name;
        }

        public void DisplayLose(string firstChoice, string secondChoice)
        {
            if (firstChoice == "lizard" && secondChoice == "rock")
            {
                Console.WriteLine("The Rock crushes the Lizard!");
            }
            else if (firstChoice == "lizard" && secondChoice == "scissors")
            {
                Console.WriteLine("The Scissors decapitates the Lizard!");
            }
        }

        public void DisplayWin(string firstChoice, string secondChoice)
        {
            if (firstChoice == "lizard" && secondChoice == "paper")
            {
                Console.WriteLine("The Lizard eats the Paper");
            }
            else if (firstChoice == "lizard" && secondChoice == "spock")
            {
                Console.WriteLine("Spock is poisoned by the Lizard!");
            }
        }
    }
}
