using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class VsAI
    {
        Display display;
        AI ai;
        Player player;
        Rock rock;
        Paper paper;
        Scissors scissors;
        public void VsComputer()
        {
            display = new Display();
            player = new Player();
            ai = new AI("AI");
            rock = new Rock("Rock");
            paper = new Paper("Paper");
            scissors = new Scissors("Scissors");
            bool gameActive = true;

            while (gameActive == true)
            {
                display.OutputToFile("ScoresVsAI.txt");
                Console.WriteLine("New game? yes/no");
                string userContinue = Console.ReadLine().ToLower();
                Console.Clear();
                display.DisplayScoreBoardVsAI();

                if (userContinue == "no")
                {
                    display.OutputToFile("ScoresVsAI.txt");
                    break;
                }

                if (userContinue == "yes")
                {
                    ai.AITurn();
                    player.Player1Input();
                    Console.WriteLine(Environment.NewLine);

                    //rock
                    if (ai.aiChoice == "rock")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("The {0} chose {1}", ai.Name, rock.Name);
                            Console.WriteLine("It is a tie.\r\n");
                        }
                        else if (player.player1Choice == "paper")
                        {
                            display.player1Score++;
                            Console.WriteLine("The {0} chose {1}", ai.Name, rock.Name);
                            paper.DisplayWin(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("You win!\r\n");
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            display.aiScore++;
                            Console.WriteLine("The {0} chose {1}", ai.Name, rock.Name);
                            scissors.DisplayLoss(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("{0} wins!\r\n",ai.Name);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, or Scissors!\r\n");
                        }

                    }
                    //paper
                    else if (ai.aiChoice == "paper")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("The {0} chose {1}", ai.Name, rock.Name);
                            rock.DisplayLoss(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("{0} wins!\r\n",ai.Name);
                            display.aiScore++;
                        }
                        else if (player.player1Choice == "paper")
                        {
                            Console.WriteLine("The {0} chose {1}", ai.Name, paper.Name);
                            Console.WriteLine("It is a tie\r\n");                            

                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("The {0} chose {1}", ai.Name, paper.Name);
                            scissors.DisplayWin(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("You win!\r\n");
                            display.player1Score++;

                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, or Scissors!\r\n");
                        }
                    }

                    //scissors
                    else if (ai.aiChoice == "scissors")
                    {
                        if (player.player1Choice == "rock")
                        {
                            //ai scissors, you rock = win
                            display.player1Score++;
                            Console.WriteLine("The {0} chose {1}", ai.Name, scissors.Name);
                            rock.DisplayWin(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("You win!\r\n");
                        }
                        else if (player.player1Choice == "paper")
                        {
                            //ai scissors, you paper = lose
                            display.aiScore++;
                            Console.WriteLine("The {0} chose {1}", ai.Name, scissors.Name);
                            paper.DisplayLoss(player.player1Choice, ai.aiChoice);
                            Console.WriteLine("{0} wins!\r\n", ai.Name);
                        
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("The {0} chose {1}", ai.Name, scissors.Name);
                            Console.WriteLine("It is a tie\r\n");
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, or Scissors!\r\n");
                        }

                    }
                }
            }
        }
    }
}