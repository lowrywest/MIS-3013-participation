using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            WhileExample();
           // DoWhileExample();
           // ForLoopExample();
        

            
        }
        private static void WhileExample()
        {
            int favNum;
            Console.WriteLine("What is your favorite number?");
            string ans = Console.ReadLine();
            while (int.TryParse(ans, out favNum) == false)
            {
                Console.WriteLine("Incorrect Value. you murst enter an Integer.");
                ans = Console.ReadLine();
            }
        }
        private static void DoWhileExample()
        {
            string usersAnswer = "";
            do
            {
                Console.WriteLine("Knock Knock. Who's there?");
                usersAnswer = Console.ReadLine();

            } while (usersAnswer.ToLower() != "banana");


        }
        private static void ForLoopExample()
        {
            for (int i = 3; i <= 1000; i = i + 3)
            {
                Console.WriteLine(i);
            }

        }
    }
}
