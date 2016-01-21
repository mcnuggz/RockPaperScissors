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
        public void VsComputerHard()
        {
            display = new Display();
            player = new Player();
            ai = new AI();
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
                            Console.WriteLine("The computer chose Rock");
                            Console.WriteLine("It is a tie ");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "paper")
                        {
                            display.player1Score++;
                            Console.WriteLine("The computer chose Rock");
                            Console.WriteLine("Your Paper covered the computers Rock, you win.");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            display.aiScore++;
                            Console.WriteLine("The computer chose Rock");
                            Console.WriteLine("The computers Rock crushed your Scissors, you lose!");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "lizard")
                        {
                            display.aiScore++;
                            Console.WriteLine("The computer chose Rock");
                            Console.WriteLine("The computers Rock crushed your Lizard, you lose!");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "spock")
                        {
                            display.player1Score++;
                            Console.WriteLine("The computer chose Rock");
                            Console.WriteLine("Spock vaporized the computers Rock, you win.");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!");
                            Console.WriteLine(Environment.NewLine);
                        }

                    }
                    //paper
                    else if (ai.aiChoice == "paper")
                    {
                        if (player.player1Choice == "rock")
                        {
                            Console.WriteLine("The computer chose Paper");
                            Console.WriteLine("The computers Paper covered your Rock, you lose");
                            display.aiScore++;
                            Console.WriteLine(Environment.NewLine);

                        }
                        else if (player.player1Choice == "paper")
                        {
                            Console.WriteLine("The computer chose Paper");
                            Console.WriteLine("It is a tie");
                            Console.WriteLine(Environment.NewLine);

                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("The computer chose Paper");
                            Console.WriteLine("The Players Scissors cuts the computers Paper, you win");
                            display.player1Score++;
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!");
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
                            Console.WriteLine("The computer chose Scissors");
                            Console.WriteLine("Your Rock crushed the computers Scissors, you win");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "paper")
                        {
                            //ai scissors, you paper = lose
                            display.aiScore++;
                            Console.WriteLine("This computer chose scissors");
                            Console.WriteLine("The computers Scissors cuts your Paper, you lose");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.player1Choice == "scissors")
                        {
                            Console.WriteLine("This computer chose scissors");
                            Console.WriteLine("It is a tie");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("You must choose Rock, Paper, Scissors, Lizard, or Spock!");
                            Console.WriteLine(Environment.NewLine);
                        }

                    }
                    else if (ai.aiChoice == "lizard")
                    {

                    }
                    else if (ai.aiChoice == "spock")
                    {

                    }
                }
            }
        }
    }
}
