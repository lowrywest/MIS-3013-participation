using System;
using System.Collections.Generic;

namespace Collections_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteThings = new List<string>();
            string ans;
            do
            {
                Console.WriteLine("Name one of your favorite things");
                ans = Console.ReadLine();
                favoriteThings.Add(ans);
                Console.WriteLine("do you have another favorite thing?");
                ans = Console.ReadLine();
            }while (ans.ToLower()[0] == 'y');

            Random rand = new Random();
            int index = rand.Next(0,favoriteThings.Count);

            Console.WriteLine(favoriteThings[index]);
        }  
    }
}
