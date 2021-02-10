using System;

namespace FizzBuzz_ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumberBetween1and100 = rand.Next(1, 101);

            if (randomNumberBetween1and100 % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (randomNumberBetween1and100 % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (randomNumberBetween1and100 % 3 == 0 && randomNumberBetween1and100 % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
        }
    }
}
