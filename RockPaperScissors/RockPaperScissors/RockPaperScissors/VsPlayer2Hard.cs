using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class VsPlayer2Hard
    {
        Display display = new Display();
        Player player = new Player();
        Rock rock = new Rock("Rock");
        Paper paper = new Paper("Paper");
        Scissors scissors = new Scissors("Scissors");
        Lizard lizard = new Lizard("Lizard");
        Spock spock = new Spock("Spock");
        public void VsOpponentHard()
        {
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
                    if (player.player2Choice == "rock")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("{0} and {1} chose Rock", player1Name, player2Name);
                            Console.WriteLine("It is a tie\r\n");
                        }
                        else if (player.player1Choice == "paper")
                        {
                            display.player1Score++;
                            Console.WriteLine("{0} chose Rock and {1} chose Paper", player2Name, player1Name);
                            paper.DisplayWin(player.player1Choice, player.player2Choice);
                            Console.WriteLine("{0} wins!\r\n", player1Name);
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            display.player2Score++;
                            Console.WriteLine("{0} chose Rock and {1} chose Scissors", player2Name, player1Name);
                            scissors.DisplayLoss(player.player1Choice, player.player2Choice);
                            Console.WriteLine("{0} wins!\r\n", player2Name);
                        }
                        else if (player.player1Choice == "lizard")
                        {
                            display.player2Score++;
                            Console.WriteLine("{0} chose Rock and {1} chose Lizard", player2Name, player1Name);
                            lizard.DisplayLoss(player.player1Choice, player.player2Choice);
                            Console.WriteLine("{0} wins!\r\n", player2Name);
                        }
                        else if (player.player1Choice == "spock")
                        {
                            display.player1Score++;
                            Console.WriteLine("{0} chose Rock and {1} chose Spock", player2Name, player1Name);
                            spock.DisplayWin(player.player1Choice, player.player2Choice);
                            Console.WriteLine("{0} wins!\r\n", player1Name);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!\r\n");
                        }

                    }
                    //paper
                    else if (player.player2Choice == "paper")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("{0} chose Paper and {1} chose Rock", player2Name, player1Name);
                            rock.DisplayLoss(player.player1Choice, player.player2Choice);
                            display.player2Score++;
                            Console.WriteLine("{0} wins!\r\n", player2Name);

                        }
                        else if (player.player1Choice == "paper")
                        {
                            Console.WriteLine("{0} and {1} chose Paper", player1Name, player2Name);
                            Console.WriteLine("It is a tie\r\n");

                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("{0} chose Paper and {1} chose Scissors", player2Name, player1Name);
                            scissors.DisplayWin(player.player1Choice, player.player2Choice);
                            display.player1Score++;
                            Console.WriteLine("{0} wins!\r\n", player1Name);
                        }
                        else if (player.player1Choice == "lizard")
                        {
                            Console.WriteLine("{0} chose Paper and {1} chose Lizard", player2Name, player1Name);
                            lizard.DisplayWin(player.player1Choice, player.player2Choice);
                            display.player1Score++;
                            Console.WriteLine("{0} wins!\r\n", player1Name);
                        }
                        else if (player.player1Choice == "spock")
                        {
                            Console.WriteLine("{0} chose Paper and {1} chose Spock", player2Name, player1Name);
                            spock.DisplayLoss(player.player1Choice, player.player2Choice);
                            display.player2Score++;
                            Console.WriteLine("{0} wins!\r\n", player2Name);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!\r\n");
                        }
                    }
                    //scissors
                    else if (player.player2Choice == "scissors")
                    {
                        if (player.player1Choice == "rock")
                        {
                            display.player1Score++;
                            Console.WriteLine("{0} chose Scissors and {1} chose Rock", player2Name, player1Name);
                            rock.DisplayWin(player.player1Choice, player.player2Choice);
                            Console.WriteLine("{0} wins!\r\n", player1Name);
                        }
                        else if (player.player1Choice == "paper")
                        {
                            display.player2Score++;
                            Console.WriteLine("{0} chose Scissors and {1} chose Paper", player2Name, player1Name);
                            paper.DisplayLoss(player.player1Choice, player.player2Choice);
                            Console.WriteLine("{0} wins!\r\n", player2Name);
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("{0} chose Scissors and {1} chose Scissors", player2Name, player1Name);
                            Console.WriteLine("It is a tie\r\n");
                        }
                        else if (player.player1Choice == "lizard")
                        {
                            Console.WriteLine("{0} chose Scissors and {1} chose Lizard", player2Name, player1Name);
                            lizard.DisplayLoss(player.player1Choice, player.player2Choice);
                            display.player2Score++;
                            Console.WriteLine("{0} wins!\r\n", player2Name);
                        }
                        else if (player.player1Choice == "spock")
                        {
                            Console.WriteLine("{0} chose Scissors and {1} chose Spock", player2Name, player1Name);
                            spock.DisplayWin(player.player1Choice, player.player2Choice);
                            display.player1Score++;
                            Console.WriteLine("{0} wins!\r\n", player1Name);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!\r\n");
                        }
                    }
                    //lizard
                    else if (player.player2Choice == "lizard")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("{0} chose Lizard and {1} chose Rock", player2Name, player1Name);
                            rock.DisplayWin(player.player1Choice, player.player2Choice);
                            display.player1Score++;
                            Console.WriteLine("{0} wins!\r\n", player1Name);
                        }
                        else if (player.player1Choice == "paper")
                        {
                            display.player2Score++;
                            Console.WriteLine("{0} chose Lizard and {1} chose Paper", player2Name, player1Name);
                            paper.DisplayLoss(player.player1Choice, player.player2Choice);
                            Console.WriteLine("{0} wins!\r\n", player2Name);
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("{0} chose Lizard and {1} chose Scissors", player2Name, player1Name);
                            scissors.DisplayWin(player.player1Choice, player.player2Choice);
                            display.player1Score++;
                            Console.WriteLine("{0} wins!\r\n", player1Name);
                        }
                        else if (player.player1Choice == "lizard")
                        {
                            Console.WriteLine("{0} and {1} chose Lizard", player1Name, player2Name);
                            Console.WriteLine("It is a tie.\r\n");
                        }
                        else if (player.player1Choice == "spock")
                        {
                            Console.WriteLine("{0} chose Lizard and {1} chose Spock", player2Name, player1Name);
                            spock.DisplayLoss(player.player1Choice, player.player2Choice);
                            display.player2Score++;
                            Console.WriteLine("{0} wins!\r\n", player2Name);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!\r\n");
                        }
                    }
                    //spock
                    else if (player.player2Choice == "spock")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("{0} chose Spock and {1} chose Rock", player2Name, player1Name);
                            rock.DisplayLoss(player.player1Choice, player.player2Choice);
                            display.player2Score++;
                            Console.WriteLine("{0} wins!\r\n", player2Name);
                        }
                        else if (player.player1Choice == "paper")
                        {
                            display.player1Score++;
                            Console.WriteLine("{0} chose Spock and {1} chose Paper", player2Name, player1Name);
                            paper.DisplayWin(player.player1Choice, player.player2Choice);
                            Console.WriteLine("{0} wins!\r\n", player1Name);
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("{0} chose Spock and {1} chose Scissors", player2Name, player1Name);
                            scissors.DisplayLoss(player.player1Choice, player.player2Choice);
                            display.player2Score++;
                            Console.WriteLine("{0} wins!\r\n", player2Name);
                        }
                        else if (player.player1Choice == "lizard")
                        {
                            display.player1Score++;
                            Console.WriteLine("{0} chose Spock and {1} chose Lizard", player2Name, player1Name);
                            lizard.DisplayWin(player.player1Choice, player.player2Choice);
                            Console.WriteLine("{0} wins!\r\n", player1Name);
                        }
                        else if (player.player1Choice == "spock")
                        {
                            Console.WriteLine("{0} and {1} chose Spock", player1Name, player2Name);
                            Console.WriteLine("It is a tie.\r\n");
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!\r\n");
                        }
                    }
                }
            }
        }
    }
}
