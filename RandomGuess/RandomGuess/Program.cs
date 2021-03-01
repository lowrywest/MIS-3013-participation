using System;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int lowNum, highNum, guess, rand;
            Console.WriteLine("This is a random number guessing game. Good Luck");
            Console.WriteLine("Please enter the low bound in the range ");
            lowNum=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the high bound in the range ");
            highNum = Convert.ToInt32(Console.ReadLine());
            rand = (int)randNum.Next(lowNum, highNum);
            do
            {
                Console.WriteLine("Enter your guess");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == rand)
                {
                    Console.WriteLine("You guessed correctly!");
                }
                else
                {
                    Console.WriteLine("Try again.");
                }

            } while (guess != rand);

        }
    }
}
