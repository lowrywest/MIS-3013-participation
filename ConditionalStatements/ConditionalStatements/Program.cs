using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int luckyNumber;
            Console.WriteLine("What is your favorite number? (Whole numbers only!)");
            luckyNumber = Convert.ToInt32(Console.ReadLine());
            int remainder = luckyNumber % 7;
            if (remainder == 0)
            {
                Console.WriteLine(luckyNumber + " is truly a lucky number!");
            }
            else if (luckyNumber % 13 == 0)
            {
                Console.WriteLine(luckyNumber + " is a really unlucky number!");
            }
            else
            {
                Console.WriteLine(luckyNumber);
            }
            
        }
    }
}
