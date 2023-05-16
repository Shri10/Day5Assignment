using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class CoinFlip
    {
        public static void Flip()
        {
            Console.WriteLine("Enter The number of times to Flip Coin:");
            int n = Convert.ToInt32(Console.ReadLine());

            int countHeads = 0, countTails = 0;

            Random flip = new Random();
            for (int i = 0; i < n; i++)
            {
                if (flip.NextDouble() < 0.5)
                {
                    countTails++;
                }
                else
                {
                    countHeads++;
                }
            }

            double headsPercentage = ((double)countHeads / n) * 100;
            double tailsPercentage = ((double)countTails / n) * 100;

            Console.WriteLine("Percentage of Heads: " + headsPercentage.ToString("0.00") + "%");
            Console.WriteLine("Percentage of Tails: " + tailsPercentage.ToString("0.00") + "%");

        }
    }
}
