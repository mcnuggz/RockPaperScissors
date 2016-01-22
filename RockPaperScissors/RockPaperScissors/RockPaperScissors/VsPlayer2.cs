using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class VsPlayer2
    {
        Display display = new Display();
        Player player = new Player();
        Rock rock = new Rock("Rock");
        Paper paper = new Paper("Paper");
        Scissors scissors = new Scissors("Scissors");

        public void VsOpponent()
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
                display.OutputToFile2("ScoresVsOpponent.txt");
                Console.WriteLine("New game? yes/no");
                string userContinue = Console.ReadLine().ToLower();
                Console.Clear();

                display.DisplayScoreBoardVsP2();

                if (userContinue == "no")
                {
                    display.OutputToFile2("ScoresVsOpponent.txt");
                    break;
                }

                if (userContinue == "yes")
                {
                    player.Player1Input();
                    Console.Clear();

                    display.DisplayScoreBoardVsP2();
                    player.Player2Input();
                    Console.Clear();

                    display.DisplayScoreBoardVsP2();
                    //rock
                    if (player.player2Choice == "rock")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("{0} and {1} chose {2}", player1Name, player2Name, rock.Name);
                            Console.WriteLine("It is a tie ");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "paper")
                        {
                            display.player1Score++;
                            Console.WriteLine("{0} chose {2} and {1} chose {3}", player2Name, player1Name, rock.Name, paper.Name);
                            Console.WriteLine("{0} wins!", player1Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            display.player2Score++;
                            Console.WriteLine("{0} chose {2} and {1} chose {3}", player2Name, player1Name, rock.Name, scissors.Name);
                            Console.WriteLine("{0} wins!", player2Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("You must choose {0}, {1}, or {2}!", rock.Name, paper.Name, scissors.Name);
                            Console.WriteLine(Environment.NewLine);
                        }

                    }
                    //paper
                    else if (player.player2Choice == "paper")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("{0} chose {2} and {1} chose {3}", player2Name, player1Name, paper.Name, rock.Name);
                            Console.WriteLine("{0} wins!", player2Name);
                            display.player2Score++;
                            Console.WriteLine(Environment.NewLine);

                        }
                        else if (player.player1Choice == "paper")
                        {
                            Console.WriteLine("{0} and {1} chose {2}", player1Name, player2Name, paper.Name);
                            Console.WriteLine("It is a tie");
                            Console.WriteLine(Environment.NewLine);

                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("{{0} chose {2} and {1} chose {3}", player2Name, player1Name, paper.Name, scissors.Name);
                            Console.WriteLine("{0} wins!", player1Name);
                            display.player1Score++;
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("You must choose {0}, {1}, or {2}!", rock.Name, paper.Name, scissors.Name);
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
                            Console.WriteLine("{0} chose {2} and {1} chose {3}", player2Name, player1Name, scissors.Name, rock.Name);
                            Console.WriteLine("{0} wins!", player1Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "paper")
                        {
                            //ai scissors, you paper = lose
                            display.player2Score++;
                            Console.WriteLine("{0} chose {2} and {1} chose {3}", player2Name, player1Name, scissors.Name, paper.Name);
                            Console.WriteLine("{0} wins!", player2Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("{0} and {1} chose Scissors", player2Name, player1Name, scissors.Name);
                            Console.WriteLine("It is a tie");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("You must choose {0}, {1}, or {2}!", rock.Name, paper.Name, scissors.Name);
                            Console.WriteLine(Environment.NewLine);
                        }

                    }
                }
            }
        }
    }
}
