using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Rock : IWinOrLose 
    {
        public string Name;
        AI ai = new AI("AI");
        public Rock(string name)
        {
            this.Name = name;
        }

        public void DisplayLoss(string firstChoice, string secondChoice)
        {
            if (firstChoice == "rock" && secondChoice == "paper")
            {
                Console.WriteLine("The Paper covered your Rock!");
            }
            else if (firstChoice == "rock" && secondChoice == "spock")
            {
                Console.WriteLine("Spock vaporized the Rock!");
            }
        }

        public void DisplayWin(string firstChoice, string secondChoice)
        {
            if (firstChoice == "rock" && secondChoice == "scissors")
            {
                Console.WriteLine("The Rock crushes the Scissors!");
            }
            else if (firstChoice == "rock" && secondChoice == "lizard")
            {
                Console.WriteLine("The Lizard was crushed the Rock!");
            }
        }
        

    }
}
