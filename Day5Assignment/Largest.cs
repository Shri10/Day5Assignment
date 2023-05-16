using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Largest
    {
        public static void lar()
        {
            int Numb1, Numb2, Numb3;

            Console.WriteLine("Enter the first number: ");
            Numb1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            Numb2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            Numb3 = int.Parse(Console.ReadLine());

            if (Numb1 > Numb2 && Numb1 > Numb3)
            {
                Console.WriteLine("The largest number is: " + Numb1);
            }
            else if (Numb2 > Numb1 && Numb2 > Numb3)
            {
                Console.WriteLine("The largest number is: " + Numb2);
            }
            else
            {
                Console.WriteLine("The largest number is: " + Numb3);
            }
        }
    }
}
