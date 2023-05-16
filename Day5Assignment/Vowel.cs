using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Vowel
    {
        public static void voc()
        {
            Console.WriteLine("Enter an alphabet to check if it is a Vowel or a Consonant:");
            char i = Convert.ToChar(Console.ReadLine().ToLower());

            if (Char.IsLetter(i))
            {
                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                {
                    Console.WriteLine("The alphabet is a Vowel.");
                }
                else
                {
                    Console.WriteLine("The alphabet is a Consonant.");
                }
            }
            else
            {
                Console.WriteLine("The character is neither a Vowel nor a Consonant.");
            }
        }
    }
}
