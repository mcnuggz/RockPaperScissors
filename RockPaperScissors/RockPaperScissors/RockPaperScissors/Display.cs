using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RockPaperScissors
{
    public class Display : IWrite
    {
        
        public int aiScore;
        public int player1Score;
        public int player2Score;
        public void DisplayScoreBoardVsAI()
        {
            for (int i = 0, j = 0; i < 100; i++, j++)
            {
                int top = Console.CursorTop;
                int left = Console.CursorLeft;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("***********Score***********");
                Console.Write("Player: {0}\nAI: {1}\n", player1Score, aiScore);
                Console.WriteLine("***************************");
            }
        }
        public void DisplayScoreBoardVsP2()
        {
            for (int i = 0, j = 0; i < 100; i++, j++)
            {
                int top = Console.CursorTop;
                int left = Console.CursorLeft;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("***********Score***********");
                Console.Write("Player 1: {0}\nPlayer 2: {1}\n", player1Score, player2Score);
                Console.WriteLine("***************************");
            }
        }
        public void OutputToFile(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Player: " + player1Score);
                writer.WriteLine("AI: " + aiScore);
            }
        }

        public void OutputToFile2(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Player 1: " + player1Score);
                writer.WriteLine("Player 2: " + player2Score);
            }
        }
    }
}
