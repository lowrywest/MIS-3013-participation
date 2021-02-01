
using System;

namespace Variables_Input_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int hereIsMyInt;
            double hereIsMyDouble;
            Console.WriteLine("Please enter a double.");
            String answer = Console.ReadLine();
            hereIsMyDouble = Convert.ToDouble(answer);
            
            Console.WriteLine("Please enter a Int.");
            answer = Console.ReadLine();
            hereIsMyInt = Convert.ToInt32(answer);

            Double result = hereIsMyInt + hereIsMyDouble;
            Console.WriteLine("The result of " + hereIsMyDouble.ToString("N3") + " + " + hereIsMyInt.ToString()+ " = " + result.ToString("C5"));
            
        }
    }
}
