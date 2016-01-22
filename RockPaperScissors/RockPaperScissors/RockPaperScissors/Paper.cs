using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Paper : IWinOrLose
    {
        AI ai = new AI("AI");
        public string Name;
        public Paper(string name)
        {
            this.Name = name;
        }

        public void DisplayLose(string firstChoice, string secondChoice)
        {
            if (firstChoice == "paper" && secondChoice == "scissors")
            {
                Console.WriteLine("The Scissors cuts the Paper!");
            }
            else if (firstChoice == "paper" && secondChoice == "lizard")
            {
                Console.WriteLine("The Lizard ate the Paper.");
            }
        }

        public void DisplayWin(string firstChoice, string secondChoice)
        {
            if (firstChoice == "paper" && secondChoice == "rock")
            {
                Console.WriteLine("The Paper covers the Rock!");
            }
            else if (firstChoice == "paper" && secondChoice == "spock")
            {
                Console.WriteLine("The Paper disapproves Spock");
            }
        }
    }
}
