using System;
using System.Collections.Generic;
namespace Collection_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            students.Add("1", 3.0);
            students.Add("2", 4.0);
            students.Add("3", 2.5);
            Console.WriteLine("Do you want to add another student?");
            string ans = Console.ReadLine();
            if (ans.ToLower()[0] == 'y')
            {
                Console.WriteLine("What is the students ID?");
                string id = Console.ReadLine();
                Console.WriteLine("What is the students GPA?");
                double gpa = Convert.ToDouble(Console.ReadLine());
                if (students.ContainsKey(id) == true)
                {
                    Console.WriteLine("That student is already in the system. We will update the GPA");
                    students[id] = gpa;
                }
                else
                {
                    students.Add(id, gpa);
                }
            }

            foreach (string id in students.Keys)
            {
                Console.WriteLine(id);
            }
            Console.WriteLine("Whose GPA do you want to see?");
            string searchID = Console.ReadLine();
            if (students.ContainsKey(searchID) == true)
            {
                Console.WriteLine(searchID + " " + students[searchID].ToString("N3"));
            }
           
            
        }
    }
}
