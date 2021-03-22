using System;
using System.Collections.Generic;
using System.IO;

namespace File_extracting_Data
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines("geoMap.csv");
            List<string> states = new List<string>();
            List<double> soccer = new List<double>();
            List<double> football = new List<double>();

            for (int i =0; i <lines.Length; i++)
            {
                string line = lines[i];
                Console.WriteLine(line);
                string[] pieces = line.Split(',');
                string state = pieces[0];
                states.Add(state);

                string soccerScoreAsString = pieces[1];
                double soccerScore = Convert.ToDouble(soccerScoreAsString.Trim('%'))/100;
                soccer.Add(soccerScore);
                football.Add(Convert.ToDouble(pieces[2].Trim('%' )) / 100);
            }

            for (int i = 0; i <football.Count;i++)
            { 
                if(soccer[])
            }
        }
    }
}
