using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double setnum = 7.777;
            double firstnum;
            double secnum;
            double thirdnum;
            double sum;
            double setnumandsum;
            Console.WriteLine("Please enter one number.");
            firstnum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            secnum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your last number.");
            thirdnum = Convert.ToDouble(Console.ReadLine());
            sum = firstnum + secnum + thirdnum;
            Console.WriteLine("The sum of your numbers is "+ sum.ToString("N3"));
            setnumandsum = setnum * sum;
            Console.WriteLine("Your sum times 7.777 is "+ setnumandsum.ToString("N3"));
        }
    }
}
