﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player
    {
        public string player1Choice;
        public string player2Choice;

        public string Player1Input()
        {
            Console.WriteLine("Player 1");
            Console.WriteLine("Choose: Rock, Paper, or Scissors");
            player1Choice = Console.ReadLine().ToLower();
            return player1Choice;
        }
        public string Player1InputHard()
        {
            Console.WriteLine("Player 1");
            Console.WriteLine("Choose: Rock, Paper, Scissors, Lizard, or Spock");
            player1Choice = Console.ReadLine().ToLower();
            return player1Choice;
        }
        public string Player2Input()
        {
            Console.WriteLine("Player 2");
            Console.WriteLine("Choose: Rock, Paper, or Scissors");
            player2Choice = Console.ReadLine().ToLower();
            return player2Choice;
        }
        public string Player2InputHard()
        {
            Console.WriteLine("Player 2");
            Console.WriteLine("Choose: Rock, Paper, Scissors, Lizard, or Spock");
            player2Choice = Console.ReadLine().ToLower();
            return player2Choice;
        }

    }
}
