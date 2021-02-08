using System;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNbr = rand.Next(1,3);
            //Console.WriteLine(randomNbr);
            Console.WriteLine("Guess heads or tails!");
            String ans = Console.ReadLine().ToLower();
            if (ans.Equals("heads") && randomNbr == 1)
            {
                Console.WriteLine("The coin landed on heads and you guessed correct!");
            }
            else if (ans.Equals("heads") && randomNbr == 2)
            {
                Console.WriteLine("The coin landed on heads but you guessed wrong.");
            }
            else if (ans.Equals("tails") && randomNbr == 1)
            {
                Console.WriteLine("The coin landed on tails but you guessed wrong.");
            }
            else
            {
                Console.WriteLine("The coin landed on tails and you guessed correct!");
            }
        }
    }
}
