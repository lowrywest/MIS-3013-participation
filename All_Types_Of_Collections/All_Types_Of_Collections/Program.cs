using System;

namespace All_Types_Of_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] subject = new String[3];
            int[] courseNum = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter the course subject.");
                subject[i] = Console.ReadLine();
                Console.WriteLine("Please enter the course number.");
                courseNum[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < subject.Length; i++)
            {
                Console.WriteLine(subject[i] +courseNum[i]);
            
            }

        }
    }
}
