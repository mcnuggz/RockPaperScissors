using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class VsAIHard
    {
        Display display;
        AI ai;
        Player player;
        Rock rock;
        Paper paper;
        Scissors scissors;
        Spock spock;
        Lizard lizard;
        public void VsComputerHard()
        {
            display = new Display();
            player = new Player();
            ai = new AI("AI");
            rock = new Rock("Rock");
            paper = new Paper("Paper");
            scissors = new Scissors("Scissors");
            lizard = new Lizard("Lizard");
            spock = new Spock("Spock");
            bool gameActive = true;

            while (gameActive == true)
            {
                display.OutputToFile("ScoresVsHardAI.txt");
                Console.WriteLine("New game? yes/no");
                string userContinue = Console.ReadLine().ToLower();
                Console.Clear();
                display.DisplayScoreBoardVsAI();

                if (userContinue == "no")
                {
                    display.OutputToFile("ScoresVsHardAI.txt");
                    break;
                }

                if (userContinue == "yes")
                {
                    ai.AITurn();
                    player.Player1InputHard();
                    Console.WriteLine(Environment.NewLine);

                    //rock
                    if (ai.aiChoice == "rock")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("The {0} chose Rock", ai.Name);
                            Console.WriteLine("It is a tie\n");
                        }
                        else if (player.player1Choice == "paper")
                        {
                            display.player1Score++;
                            Console.WriteLine("The {0} chose Rock", ai.Name);
                            paper.DisplayWin(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("You win!\n");
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            display.aiScore++;
                            Console.WriteLine("The {0} chose Rock", ai.Name);
                            scissors.DisplayLose(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("{0} wins!", ai.Name);
                        }
                        else if (player.player1Choice == "lizard")
                        {
                            display.aiScore++;
                            Console.WriteLine("The {0} chose Rock", ai.Name);
                            lizard.DisplayLose(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("{0} wins!\n", ai.Name);
                        }
                        else if (player.player1Choice == "spock")
                        {
                            display.player1Score++;
                            Console.WriteLine("The {0} chose Rock", ai.Name);
                            spock.DisplayWin(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("You win!\n");
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!\n");

                        }

                    }
                    //paper
                    else if (ai.aiChoice == "paper")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("The {0} chose Paper", ai.Name);
                            rock.DisplayLose(player.player1Choice, ai.aiChoice);
                            display.aiScore++;
                            Console.WriteLine("{0} wins!\n", ai.Name);

                        }
                        else if (player.player1Choice == "paper")
                        {
                            Console.WriteLine("The {0} chose Paper",ai.Name);
                            Console.WriteLine("It is a tie\n");

                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("The {0} chose Paper", ai.Name);
                            scissors.DisplayWin(player.player1Choice, ai.aiChoice);
                            display.player1Score++;
                            Console.WriteLine("You win!\n");
                        }
                        else if (player.player1Choice == "lizard")
                        {
                            Console.WriteLine("The {0} chose Paper",ai.Name);
                            lizard.DisplayWin(player.player1Choice, ai.aiChoice);
                            display.player1Score++;
                            Console.WriteLine("You win!\n");
                        }
                        else if (player.player1Choice == "spock")
                        {
                            Console.WriteLine("The {0} chose Paper", ai.Name);
                            spock.DisplayLose(player.player1Choice, ai.aiChoice);
                            display.aiScore++;
                            Console.WriteLine("{0} wins!\n", ai.Name);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!\n");
                        }
                    }
                    //scissors
                    else if (ai.aiChoice == "scissors")
                    {
                        if (player.player1Choice == "rock")
                        {
                            //ai scissors, you rock = win
                            display.player1Score++;
                            Console.WriteLine("The {0} chose Scissors", ai.Name);
                            rock.DisplayLose(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("{0} wins!\n", ai.Name);
                        }
                        else if (player.player1Choice == "paper")
                        {
                            //ai scissors, you paper = lose
                            display.aiScore++;
                            Console.WriteLine("This {0} chose scissors",ai.Name);
                            paper.DisplayLose(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("{0} wins!\n", ai.Name);
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("This {0} chose scissors",ai.Name);
                            Console.WriteLine("It is a tie\n");
                        }
                        else if (player.player1Choice == "lizard") 
                        {
                            Console.WriteLine("This {0} chose scissors", ai.Name);
                            lizard.DisplayLose(player.player1Choice, ai.aiChoice);
                            display.aiScore++;
                            Console.WriteLine("{0} wins!\n", ai.Name);
                        }
                        else if (player.player1Choice == "spock")
                        {
                            Console.WriteLine("This {0} chose scissors",ai.Name);
                            spock.DisplayWin(player.player1Choice, ai.aiChoice);
                            display.player1Score++;
                            Console.WriteLine("You win!\n");
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!\n");
                        }

                    }
                    else if (ai.aiChoice == "lizard")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("The {0} chose Lizard",ai.Name);
                            rock.DisplayWin(player.player1Choice, ai.aiChoice);
                            display.player1Score++;
                            Console.WriteLine("You win!\n");
                        }
                        else if (player.player1Choice == "paper")
                        {
                            display.player1Score++;
                            Console.WriteLine("The {0} chose Lizard",ai.Name);
                            paper.DisplayLose(player.player1Choice, ai.aiChoice);
                            display.aiScore++;
                            Console.WriteLine("{0} wins!\n", ai.Name);
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            display.aiScore++;
                            Console.WriteLine("The {0} chose Lizard", ai.Name);
                            scissors.DisplayWin(player.player1Choice, ai.aiChoice);
                            display.player1Score++;
                            Console.WriteLine("You win!\n");
                        }
                        else if (player.player1Choice == "lizard")
                        {
                            Console.WriteLine("The {0} chose Lizard",ai.Name);
                            Console.WriteLine("It is a tie.");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "spock")
                        {
                            Console.WriteLine("The {0} chose Lizard",ai.Name);
                            spock.DisplayLose(player.player1Choice, ai.aiChoice);
                            display.aiScore++;
                            Console.WriteLine("{0} wins!\n", ai.Name);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!\n");
                        }
                    }

                    else if (ai.aiChoice == "spock")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("The {0} chose Spock",ai.Name);
                            rock.DisplayLose(player.player1Choice, ai.aiChoice);
                            display.aiScore++;
                            Console.WriteLine("{0} wins!\n", ai.Name);
                        }
                        else if (player.player1Choice == "paper")
                        {
                            display.player1Score++;
                            Console.WriteLine("The {0} chose Spock",ai.Name);
                            paper.DisplayWin(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("You win!\n");
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            display.aiScore++;
                            Console.WriteLine("The {0} chose Spock",ai.Name);
                            scissors.DisplayLose(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("{0} wins!\n", ai.Name);
                        }
                        else if (player.player1Choice == "lizard")
                        {
                            display.player1Score++;
                            Console.WriteLine("The {0} chose Spock",ai.Name);
                            lizard.DisplayWin(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("You win!\n");
                        }
                        else if (player.player1Choice == "spock")
                        {
                            Console.WriteLine("The {0} chose Spock",ai.Name);
                            Console.WriteLine("It is a tie.\n");
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!\n");
                        }
                    }
                }
            }
        }
    }
}
