using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class EvenOrOdd
    {
        public static void eoo()
        {
            int Nmb, Remainder;
            Console.WriteLine("Input an integer to Check whether it is even or odd: ");
            Nmb = Convert.ToInt32(Console.ReadLine());
            Remainder = Nmb % 2;
            if (Remainder == 0)
            { Console.WriteLine(Nmb+" is an even integer."); }
            else
            { Console.WriteLine(Nmb+" is an odd integer."); }

        }
    }
}
