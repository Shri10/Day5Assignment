using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class QuotientRemainder
    {
        public static void qr()
        {
            int a = 0, b = 1;
            Console.WriteLine("Please Enter the Dividend:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Divisor:");
            b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Divisor MUST NOT be zero");
            }
            else
            {
                int q, r;
                q = a / b;
                r = a % b;
                Console.WriteLine("When " + a + " is divided by " + b + ", quotient is " + q + " and remainder is " + r + ".");
            }
        }
    }
}
