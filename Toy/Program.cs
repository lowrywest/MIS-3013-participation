using System;

namespace Toy
{
    class Program
    {
        static void Main(string[] args)
        {

            ToyClass one = new ToyClass("Sony","PlayStation",450,"Less shipping problems ");
            ToyClass two = new ToyClass("Microsoft", "Xbox", 500, "More shipping problems ");
            Console.WriteLine(one.ToString());
            Console.WriteLine(one.GetAisle());
            Console.WriteLine(two.ToString());
            Console.WriteLine(two.GetAisle());

            
        }
    }
}
