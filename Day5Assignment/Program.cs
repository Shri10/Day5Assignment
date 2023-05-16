namespace Day5Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int repeat = 0;
            while (repeat == 0)
            {
                Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\nPlease Select an option from below:\n" +
                "\t1:\tCoin Flip Percentage\n" +
                "\t2:\tLeap Year\n" +
                "\t3:\tPower of 2\n" +
                "\t4:\tHarmonic\n" +
                "\t5:\tFactorisation\n" +
                "\t6:\tQuotient and Remainder\n" +
                "\t7:\tSwap 2 numbers\n" +
                "\t8:\tNumber is Even or Odd\n" +
                "\t9:\tVowel or Consonant\n" +
                "\t10:\tLargest amongs the three numners\n" +
                "\t0:\tStop the Program\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
                string inp = Console.ReadLine();
                switch (inp)
                {
                    case "1":
                        //1. Coin Flip Percentage
                        CoinFlip.Flip();
                        break;
                    case "2":
                        //2. Leap Year
                        LeapYear.lpy();
                        break;
                    case "3":
                        //Power of 2
                        Power.power();
                        break;
                    case "4":
                        //4. Harmonic
                        HarmonicNum.hrm();
                        break;
                    case "5":
                        //Factorisation
                        Factors.fact();
                        break;
                    case "6":
                        //Quotient and Remainder
                        QuotientRemainder.qr();
                        break;
                    case "7":
                        //Swap 2 numbers
                        Swap.swp();
                        break;
                    case "8":
                        //Number is Even or Odd
                        EvenOrOdd.eoo();
                        break;
                    case "9":
                        //Vowel or Consonant
                        Vowel.voc();
                        break;
                    case "10":
                        //Largest amongs the three numners
                        Largest.lar();
                        break;
                    case "0":
                        Console.WriteLine("Stopping the Program.");
                        repeat = 1;
                        break;
                    default:
                        Console.WriteLine("Stopping the Program.\nSelect from the given options, any other input ends the program.");
                        repeat = 1;
                        break;

                }
            }


        }

    }
}