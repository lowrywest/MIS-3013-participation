using System;
using System.Collections.Generic;

namespace Collections_Min_Max_AVG
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> testScore = new List<double>();
            Dictionary <double, int> modeCalc = new Dictionary<double, int>();
            double max, min, avg;
            double mode=0;
            double sum =0;
            double maxTemp, minTemp;
            bool fin = true;
            do
            {
                Console.WriteLine("Please enter your exam scores. Enter the word done when complete.");
                string input = Console.ReadLine();
                if (input[0] == 'd')
                {
                    fin = false;
                }
                else 
                {
                    double score = Convert.ToDouble(input);
                    testScore.Add(score);
                }

            } while (fin==true);


            minTemp = testScore[0];
            maxTemp = testScore[0];
            for (int i = 0; i < testScore.Count; i++)
            {

                sum = testScore[i] + sum;
                if (maxTemp < testScore[i])
                {
                    maxTemp = testScore[i];
                }
                if (minTemp > testScore[i])
                {
                    minTemp = testScore[i];
                }
                if (modeCalc.ContainsKey(testScore[i]) == true)
                {
                    modeCalc[testScore[i]] = modeCalc[testScore[i]] + 1;
                }
                else 
                {
                    modeCalc.Add(testScore[i], 1);
                }
                
            }
            foreach (double scoreKey in modeCalc.Keys)
            {
                if (modeCalc[scoreKey] > mode)
                {
                    mode = modeCalc[scoreKey];
                }
            }
            
            
            avg = sum / testScore.Count;
            max = maxTemp;
            min = minTemp;
            Console.WriteLine("The highest exam score is "+max+".");
            Console.WriteLine("The lowest exam score is " + min+".");
            Console.WriteLine("The average exam score is " + avg+".");

            foreach (double scoreKey in modeCalc.Keys)
            {
                if (modeCalc[scoreKey] == mode)
                {
                    Console.WriteLine("The grade " + scoreKey +" occurs the most often. ");
                }
            }
        }
    }
}
