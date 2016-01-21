using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            AI ai = new AI();

            Player player = new Player();
            Display display = new Display();
            bool gameActive = true;

  
            while (gameActive == true)
            {
                display.OutputToFile("Scores.txt");
                Console.WriteLine("New game? yes/no");
                string userContinue = Console.ReadLine().ToLower();
                Console.Clear();
                display.DisplayScoreBoard();

                if (userContinue == "no")
                {
                    display.OutputToFile("Scores.txt");
                    break;
                }

                if (userContinue == "yes")
                {                    
                    ai.AITurn();
                    player.UserInput();
                    Console.WriteLine(Environment.NewLine);
                    #region game
                    //rock
                    if (ai.aiChoice == "rock")
                    {
                        if (player.playerChoice == "rock")
                        {
                            Console.WriteLine("The computer chose Rock");
                            Console.WriteLine("It is a tie ");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.playerChoice == "paper")
                        {
                            display.playerScore++;
                            Console.WriteLine("The computer chose Paper");
                            Console.WriteLine("Your Paper covered the computers Rock, you win.");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.playerChoice == "scissors")
                        {
                            display.aiScore++;
                            Console.WriteLine("The computer chose Scissors");
                            Console.WriteLine("The computers Rock was crushed by your Scissors, you lose!");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("You must choose rock, paper or scissors!");
                            Console.WriteLine(Environment.NewLine);
                        }

                    }
                    //paper
                    else if (ai.aiChoice == "paper")
                    {
                        if (player.playerChoice == "rock")
                        {
                            Console.WriteLine("The computer chose Paper");
                            Console.WriteLine("The computers Paper covered your Rock, you lose");
                            display.aiScore++;
                            Console.WriteLine(Environment.NewLine);

                        }
                        else if (player.playerChoice == "paper")
                        {
                            Console.WriteLine("The computer chose Paper");
                            Console.WriteLine("It is a tie");
                            Console.WriteLine(Environment.NewLine);

                        }
                        else if (player.playerChoice == "scissors")
                        {
                            Console.WriteLine("The computer chose paper");
                            Console.WriteLine("The Players Scissors cuts the computers Paper, you win");
                            display.playerScore++;
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("You must choose rock, paper or scissors!");
                            Console.WriteLine(Environment.NewLine);
                        }
                    }
                    //scissors
                    else if (ai.aiChoice == "scissors")
                    {
                        if (player.playerChoice == "rock")
                        {
                            //ai scissors, you rock = win
                            display.playerScore++;
                            Console.WriteLine("The computer chose Scissors");
                            Console.WriteLine("Your Rock crushed the computers Scissors, you win");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.playerChoice == "paper")
                        {
                            //ai scissors, you paper = lose
                            display.aiScore++;
                            Console.WriteLine("This computer chose scissors");
                            Console.WriteLine("The computers Scissors cuts your Paper, you lose");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else if (player.playerChoice == "scissors")
                        {
                            Console.WriteLine("This computer chose scissors");
                            Console.WriteLine("It is a tie");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("You must choose rock, paper or scissors!");
                            Console.WriteLine(Environment.NewLine);
                        }
                        
                    }
                    #endregion

                    

                }
            }
        }
    }
}
