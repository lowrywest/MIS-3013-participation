using System;

namespace Collections_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentIDs = new string[3];
            double[] studentGPAs = { 3.0,4.0,2.5};
            studentIDs[0] = "1";
            studentIDs[1] = "2";
            studentIDs[2] = "3";

         
            foreach (string id in studentIDs)
            {
                Console.WriteLine(id+"\t");
            }
            Console.WriteLine("Whose GPA do you want to see?");
            string searchID = Console.ReadLine();
            for (int i = 0; i < studentGPAs.Length; i++)
            {

                string id = studentIDs[i];
                double gpa = studentGPAs[i];
                if (id == searchID)
                {
                    Console.WriteLine(id + " GPA is " + gpa.ToString("N3"));

                }
                
            }
        }
    }
}
