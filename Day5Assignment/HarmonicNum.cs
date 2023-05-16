using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class HarmonicNum
    {
        public static void hrm() 
        {
            int i, n; // n is Nth harmonic number:
            double s = 0;

            Console.WriteLine("Calculate the Harmonic Numbers\nPlease enter the number of terms:");
            
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/"+i+" + ");
                s += 1 / (float)i;
            }
            Console.WriteLine("\nSum of Series upto "+n+" terms : "+s);
        }
    }
}
