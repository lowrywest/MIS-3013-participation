using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            String findWord, changeWord;
            String sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(sentence);
            Console.WriteLine("What word would you like to look for in the sentence above?");
            findWord =Console.ReadLine();
            Console.WriteLine("What word would you like to replace the first word with?");
            changeWord = Console.ReadLine();
            if (sentence.IndexOf(findWord) == -1)
            {
                String backWord = "";
                Console.WriteLine("Sorry, I could not find your word " + findWord);
                for (int i = changeWord.Length - 1; i >= 0; i--)
                {
                    backWord += changeWord[i];
                }
                Console.WriteLine(backWord);
            }
            else
            {
                sentence =sentence.Replace(findWord, changeWord);
                Console.WriteLine(sentence);
            }
        }
    }
}
