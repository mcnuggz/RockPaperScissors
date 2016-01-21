using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class VsPlayer2Hard
    {
        Display display;
        Player player;
        public void VsOpponentHard()
        {
            display = new Display();
            player = new Player();
            string player1Name;
            string player2Name;
            bool gameActive = true;


            Console.Clear();
            Console.WriteLine("Player 1, enter your name: ");
            player1Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Player 2, enter your name: ");
            player2Name = Console.ReadLine();
            Console.Clear();

            while (gameActive == true)
            {
                display.OutputToFile2("ScoresVsOpponentHard.txt");
                Console.WriteLine("New game? yes/no");
                string userContinue = Console.ReadLine().ToLower();
                Console.Clear();

                display.DisplayScoreBoardVsP2();

                if (userContinue == "no")
                {
                    display.OutputToFile2("ScoresVsOpponentHard.txt");
                    break;
                }

                if (userContinue == "yes")
                {
                    player.Player1InputHard();
                    Console.Clear();

                    display.DisplayScoreBoardVsP2();
                    player.Player2InputHard();
                    Console.Clear();

                    display.DisplayScoreBoardVsP2();
                    //rock
                    #region initial game
                    if (player.player2Choice == "rock")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("{0} and {1} chose Rock", player1Name, player2Name);
                            Console.WriteLine("It is a tie ");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "paper")
                        {
                            display.player1Score++;
                            Console.WriteLine("{0} chose Rock and {1} chose Paper", player2Name, player1Name);
                            Console.WriteLine("The Paper covers the Rock, {0} wins!", player1Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            display.player2Score++;
                            Console.WriteLine("{0} chose Rock and {1} chose Scissors", player2Name, player1Name);
                            Console.WriteLine("The Rock crushes the Scissors {0} wins!", player2Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "lizard")
                        {
                            display.player2Score++;
                            Console.WriteLine("{0} chose Rock and {1} chose Lizard", player2Name, player1Name);
                            Console.WriteLine("The Rock crushes the Lizard, {0} wins!", player2Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "spock")
                        {
                            display.player1Score++;
                            Console.WriteLine("{0} chose Rock and {1} chose Spock", player2Name, player1Name);
                            Console.WriteLine("Spock vaporized the computers Rock, {0} wins.", player1Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!");
                            Console.WriteLine(Environment.NewLine);
                        }

                    }
                    //paper
                    else if (player.player2Choice == "paper")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("{0} chose Paper and {1} chose Rock", player2Name, player1Name);
                            Console.WriteLine("The Paper covers the Rock, {0} wins!", player2Name);
                            display.player2Score++;
                            Console.WriteLine(Environment.NewLine);

                        }
                        else if (player.player1Choice == "paper")
                        {
                            Console.WriteLine("{0} and {1} chose Paper", player1Name, player2Name);
                            Console.WriteLine("It is a tie");
                            Console.WriteLine(Environment.NewLine);

                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("{0} chose Paper and {1} chose Scissors", player2Name, player1Name);
                            Console.WriteLine("The Scissors cut the Paper, {0} wins!", player1Name);
                            display.player1Score++;
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "lizard")
                        {
                            Console.WriteLine("{0} chose Paper and {1} chose Lizard", player2Name, player1Name);
                            Console.WriteLine("The Lizard poisons Spock, {0} wins!", player1Name);
                            display.player1Score++;
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "spock")
                        {
                            Console.WriteLine("{0} chose Paper and {1} chose Spock", player2Name, player1Name);
                            Console.WriteLine("The Paper disapproves Spock, {0} wins.", player2Name);
                            display.player2Score++;
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!");
                            Console.WriteLine(Environment.NewLine);
                        }
                    }
                    //scissors
                    else if (player.player2Choice == "scissors")
                    {
                        if (player.player1Choice == "rock")
                        {
                            //ai scissors, you rock = win
                            display.player1Score++;
                            Console.WriteLine("{0} chose Scissors and {1} chose Rock", player2Name, player1Name);
                            Console.WriteLine("The Rock crushes the Scissors, {0} wins!", player1Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "paper")
                        {
                            //ai scissors, you paper = lose
                            display.player2Score++;
                            Console.WriteLine("{0} chose Scissors and {1} chose Paper", player2Name, player1Name);
                            Console.WriteLine("The Scissors cut the Paper, {0} wins!", player2Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("{0} chose Scissors and {1} chose Scissors", player2Name, player1Name);
                            Console.WriteLine("It is a tie");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "lizard")
                        {
                            Console.WriteLine("{0} chose Scissors and {1} chose Lizard", player2Name, player1Name);
                            Console.WriteLine("The Scissors decapitate the Lizard, {0} wins!", player2Name);
                            display.player2Score++;
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "spock")
                        {
                            Console.WriteLine("{0} chose Scissors and {1} chose Spock", player2Name, player1Name);
                            Console.WriteLine("Spock crushes the Scissors, {0} wins.", player1Name);
                            display.player1Score++;
                            Console.WriteLine(Environment.NewLine);
                        }
                        #endregion
                        #region lizard
                        else if (player.player2Choice == "lizard")
                        {
                            if (player.player1Choice == "rock")
                            {
                                Console.WriteLine("{0} chose Lizard and {1} chose Rock", player2Name, player1Name);
                                Console.WriteLine("The computers Lizard was crushed by your Rock, you win!");
                                display.player1Score++;
                                Console.WriteLine(Environment.NewLine);
                            }
                            else if (player.player1Choice == "paper")
                            {
                                display.player1Score++;
                                Console.WriteLine("{0} chose Lizard and {1} chose Paper", player2Name, player1Name);
                                Console.WriteLine("The computers Lizard ate your Paper, you lose.");
                                display.aiScore++;
                                Console.WriteLine(Environment.NewLine);
                            }
                            else if (player.player1Choice == "scissors")
                            {
                                display.aiScore++;
                                Console.WriteLine("{0} chose Lizard and {1} chose Scissors", player2Name, player1Name);
                                Console.WriteLine("The Lizard was decapitated by the Scissors, {0} wins!", player1Name);
                                display.player1Score++;
                                Console.WriteLine(Environment.NewLine);
                            }
                            else if (player.player1Choice == "lizard")
                            {
                                Console.WriteLine("{0} and {1} chose Lizard", player1Name, player2Name);
                                Console.WriteLine("It is a tie.");
                                Console.WriteLine(Environment.NewLine);
                            }
                            else if (player.player1Choice == "spock")
                            {
                                Console.WriteLine("{0} chose Lizard and {1} chose Spock", player2Name, player1Name);
                                Console.WriteLine("The Lizard poisoned Spock, {0} wins!", player2Name);
                                display.player2Score++;
                                Console.WriteLine(Environment.NewLine);
                            }
                            else
                            {
                                Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!");
                                Console.WriteLine(Environment.NewLine);
                            }
                        }
                        #endregion
                        else if (player.player2Choice == "spock")
                        {
                            if (player.player1Choice == "rock")
                            {
                                Console.WriteLine("{0} chose Spock and {1} chose Rock", player2Name, player1Name);
                                Console.WriteLine("The computers Spock vaporized your Rock, {0} wins!", player2Name);
                                display.player2Score++;
                                Console.WriteLine(Environment.NewLine);
                            }
                            else if (player.player1Choice == "paper")
                            {
                                display.player1Score++;
                                Console.WriteLine("{0} chose Spock and {1} chose Paper", player2Name, player1Name);
                                Console.WriteLine("Your Paper disapproves the computers Spock, {0} wins!", player1Name);
                                Console.WriteLine(Environment.NewLine);
                            }
                            else if (player.player1Choice == "scissors")
                            {
                                Console.WriteLine("{0} chose Spock and {1} chose Scissors", player2Name, player1Name);
                                Console.WriteLine("The computers Spock crushed your Scissors, {0} wins!", player2Name);
                                display.player2Score++;
                                Console.WriteLine(Environment.NewLine);
                            }
                            else if (player.player1Choice == "lizard")
                            {
                                display.player1Score++;
                                Console.WriteLine("{0} chose Spock and {1} chose Lizard", player2Name, player1Name);
                                Console.WriteLine("Spock was poisoned by your Lizard, {0} wins!", player1Name);
                                Console.WriteLine(Environment.NewLine);
                            }
                            else if (player.player1Choice == "spock")
                            {
                                Console.WriteLine("{0} and {1} chose Spock", player1Name, player2Name);
                                Console.WriteLine("It is a tie.");
                                Console.WriteLine(Environment.NewLine);
                            }
                            else
                            {
                                Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!");
                                Console.WriteLine(Environment.NewLine);
                            }

                        }
                    }
                }
            }
        }
    }
}
