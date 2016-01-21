using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player
    {
        public string playerChoice;
        public int playerScore = 0;

        public string UserInput()
        {
            Console.WriteLine(Environment.NewLine + "Choose: Rock Paper Scissors");
            playerChoice = Console.ReadLine().ToLower();
            return playerChoice;
        }
        
    }
}
