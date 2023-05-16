using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Power
    {
        public static void power()
        {
            Console.Write("Enter the power N: ");
            int N = int.Parse(Console.ReadLine());

            if (N < 0 || N >= 31)
            {
                Console.WriteLine("N must be between 0 and 30:");
                return;
            }

            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine($"2^"+i+" = "+Math.Pow(2, i));
            }
        }
    }
}
