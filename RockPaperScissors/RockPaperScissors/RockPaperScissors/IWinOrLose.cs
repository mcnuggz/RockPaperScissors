﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    interface IWinOrLose
    {
        void DisplayWin(string firstChoice, string secondChoice);
        void DisplayLoss(string firstChoice, string secondChoice);
    }
}
