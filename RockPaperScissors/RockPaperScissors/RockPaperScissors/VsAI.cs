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
                            Console.WriteLine("It is a tie ");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "paper")
                        {
                            display.player1Score++;
                            Console.WriteLine("The {0} chose {1}", ai.Name, rock.Name);
                            Console.WriteLine("Your {0} covered {1}s {2}, you win.", paper.Name, ai.Name, rock.Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            display.aiScore++;
                            Console.WriteLine("The {0} chose {1}", ai.Name, rock.Name);
                            Console.WriteLine("{0}s {1} crushed your {2}, you lose!", ai.Name, rock.Name, scissors.Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, or Scissors!");
                            Console.WriteLine(Environment.NewLine);
                        }

                    }
                    //paper
                    else if (ai.aiChoice == "paper")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("The {0} chose {1}", ai.Name, rock.Name);
                            Console.WriteLine("{0}s {1} covered your {2}, you lose", ai.Name, paper.Name, rock.Name);
                            display.aiScore++;
                            Console.WriteLine(Environment.NewLine);

                        }
                        else if (player.player1Choice == "paper")
                        {
                            Console.WriteLine("The {0} chose {1}", ai.Name, paper.Name);
                            Console.WriteLine("It is a tie");
                            Console.WriteLine(Environment.NewLine);

                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("The {0} chose {1}", ai.Name, paper.Name);
                            Console.WriteLine("Your {0} cuts the {1}s {2}, you win", scissors.Name, ai.Name, paper.Name);
                            display.player1Score++;
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, or Scissors!");
                            Console.WriteLine(Environment.NewLine);
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
                            Console.WriteLine("Your {0} crushes the {1}s {2}, you win", rock.Name, ai.Name, scissors.Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "paper")
                        {
                            //ai scissors, you paper = lose
                            display.aiScore++;
                            Console.WriteLine("The {0} chose {1}", ai.Name, scissors.Name);
                            Console.WriteLine("The {0}s {1} cuts your {2}, you lose", ai.Name, scissors.Name, paper.Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("The {0} chose {1}", ai.Name, scissors.Name);
                            Console.WriteLine("It is a tie");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, or Scissors!");
                            Console.WriteLine(Environment.NewLine);
                        }

                    }
                }
            }
        }
    }
}
