using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int luckyNumber;
            string answer;
            Console.WriteLine("What is your favorite number? (Whole numbers only!)");
            answer = Console.ReadLine();
            bool isInteger = int.TryParse(answer, out luckyNumber);
            if (isInteger == false)
            {
                Console.WriteLine(luckyNumber+" is not a valid integer. Goodbye!");
                Environment.Exit(0);
                //can also use the return; to exit the application
            }
           
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

            Console.WriteLine("What is your favorite type of pet?");
            answer = Console.ReadLine();

            switch (answer.ToLower())
            {
                case "dog":
                    Console.WriteLine("Cool me too!");
                    break;
                case "cat":
                    Console.WriteLine("If you say so");
                    break;
                default:
                    Console.WriteLine("Who would ever have " + answer + " as a pet?");
                    break;
            }

        }
    }
}
