using System;
using System.Collections.Generic;

namespace DictonaryCourses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            List<double> averages = new List<double>();
            Dictionary<String, List<double>> courseNum = new Dictionary<string, List<double>>();
            string courseNums = "";
            string gradeAdd = "";
            bool contNum = true;
            bool contGrades = true;
            double sum = 0;
            double avg = 0;
            do
            {
                Console.WriteLine("Please enter the course code. Please enter done when you have entered all your course codes.");
                courseNums = Console.ReadLine();
                if (courseNums[0] == 'd' || courseNums[0] == 'D')
                {
                    contNum = false;
                }
                else 
                {
                    do
                    {
                        Console.WriteLine("Please enter the grades for the course. Please enter done when all grades have been entered. ");
                        gradeAdd = Console.ReadLine();
                        if (gradeAdd[0] == 'd' || gradeAdd[0] == 'D')
                        {
                            contGrades = false;
                        }
                        else
                        {
                            sum += Convert.ToDouble(gradeAdd);
                            grades.Add(Convert.ToDouble(gradeAdd));
                        }
                    }
                    while (contGrades==true);
                    avg = sum / grades.Count;
                    averages.Add(avg);
                    courseNum.Add(courseNums, grades);
                    grades.Clear();
                    contGrades = true;
                    avg = 0;
                    sum = 0;
                }

            }
            while (contNum == true);
            int counter = 0;
            foreach (string course in courseNum.Keys)
            {
                Console.WriteLine("The grade average for "+course+ " is "+ averages[counter].ToString("N2"));
                counter++;
            }
            
        }
    }
}
