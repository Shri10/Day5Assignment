using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class LeapYear
    {
        public static void lpy()
        {
            Console.WriteLine("Please enter a year (Must be 4 digit): ");
            int Leapyear = Convert.ToInt32(Console.ReadLine());

            if (Leapyear < 1000 || Leapyear > 9999)
            {
                Console.WriteLine("Please enter a 4-digit number as year.");
            }
            else if ((Leapyear % 4 == 0 && Leapyear % 100 != 0) || Leapyear % 400 == 0)
            {
                Console.WriteLine(Leapyear + " is a leap year.");
            }
            else
            {
                Console.WriteLine(Leapyear + " is not a leap year.");
            }

            Console.ReadLine();
        }
    }
}
