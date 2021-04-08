using System;
using System.Collections.Generic;

namespace GradesList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            string input;
            bool cont = true;
            double avg;
            double sum=0;
            do
            {
                Console.WriteLine("Please enter your grade. Enter no when complete.");
                input = Console.ReadLine().ToLower();
                if (input[0] == 'n')
                {
                    cont = false;
                }
                else
                {
                    grades.Add(Convert.ToDouble(input));
                    sum += Convert.ToDouble(input);
                }

            }
            while (cont == true);
            avg = sum / grades.Count;
            Console.WriteLine("Your average grade is " + avg);

        }
    }
}
