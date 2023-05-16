using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Swap
    {
        public static void swp()
        {
            int Numb1, Numb2, SwapingNumbs;
            Console.WriteLine("Input the First Number : ");
            Numb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second Number : ");
            Numb2 = int.Parse(Console.ReadLine());
            SwapingNumbs = Numb1;
            Numb1 = Numb2;
            Numb2 = SwapingNumbs;
            Console.WriteLine("After Swapping\t: ");
            Console.WriteLine("First Number\t: " + Numb1);
            Console.WriteLine("Second Number\t: " + Numb2);
            Console.Read();
        }
    }
}
