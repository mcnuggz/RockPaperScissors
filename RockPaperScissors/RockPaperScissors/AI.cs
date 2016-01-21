using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class AI 
    {
        Random random = new Random();
        public string aiChoice;
        
        public string AITurn()
        {
            int aiRoll = random.Next(1,3);
            if (aiRoll == 1)
            {
                aiChoice = "rock";
            }
            else if (aiRoll == 2)
            {
                aiChoice = "scissors";
            }
            else if (aiRoll == 3)
            {
                aiChoice = "paper";
            }
            return aiChoice;
        }
    }
}
