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
        public int playerScore;
        public void DisplayScoreBoard()
        {
            for (int i = 0, j = 0; i < 100; i++, j++)
            {
                int top = Console.CursorTop;
                int left = Console.CursorLeft;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("***********Score***********");
                Console.Write("Player: {0}\nAI: {1}\n", playerScore, aiScore);
                Console.WriteLine("***************************");
            }
        }
        public void OutputToFile(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Player: " + playerScore);
                writer.WriteLine("AI: " + aiScore);
            }

        }
    }
}
