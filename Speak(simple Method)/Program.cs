using System;

namespace Speak_simple_Method_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the animal you want to see the sound of.");
            string input = Console.ReadLine().Trim();
            string sound = Speak(input);
            Console.WriteLine("A "+input+" makes the sound of "+sound);
        }
        static string Speak(string animal)
        {
            string output = "booooo";
            string[] animals = { "dog", "cat", "horse", "pig","lion","cow" };
            string[] sounds = { "ruff", "meow", "neigh", "oink", "roar", "mooo" };
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] == animal.ToLower())
                {
                    output = sounds[i];
                }
            }
            return output;
        }
    }
}
