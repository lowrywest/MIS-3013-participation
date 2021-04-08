using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Lowry West", "MIS 3013", "04/07/2021");
            bool cont = true;
            string operation, input;
            double first, second;
            double result= 0;
            int count = 0;
            do
            {
                if (count == 0)
                {
                    Console.WriteLine("What type of calculation would you like to preform?");
                    operation = Console.ReadLine().ToLower();
                    Console.WriteLine("What is your first number?");
                    first = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What is your second number?");
                    second = Convert.ToDouble(Console.ReadLine());
                    if (operation[0] == 'a')
                    {
                        result = Add(first, second);
                        Console.WriteLine(first +"+"+second+"="+result);
                    }
                    else if (operation[0] == 's')
                    {
                        result = Subtract(first, second);
                        Console.WriteLine(first + "-" + second + "=" + result);
                    }
                    else if (operation[0] == 'm')
                    {
                        result = Multiply(first, second);
                        Console.WriteLine(first + "*" + second + "=" + result);
                    }
                    else
                    {
                        result = Divide(first, second);
                        Console.WriteLine(first + "/" + second + "=" + result);
                    }
                    count++;
                }
                else
                {
                    Console.WriteLine("Please enter done if you are done with the calculator. If you are not done please enter continue.");
                    input = Console.ReadLine().ToLower();
                    if (input[0] == 'd')
                    {
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("Would you like to preform a new calculation or use the result from the last calculation?");
                        Console.WriteLine("Please enter new or old to choose which one.");
                        input = Console.ReadLine().ToLower();
                        Console.WriteLine("What type of calculation would you like to preform?");
                        operation = Console.ReadLine().ToLower();
                        if (input[0] == 'o')
                        {
                            first = result;
                            Console.WriteLine("Enter the second number in your calculation");
                            second = Convert.ToDouble(Console.ReadLine());
                            if (operation[0] == 'a')
                            {
                                result = Add(first, second);
                                Console.WriteLine(first + "+" + second + "=" + result);
                            }
                            else if (operation[0] == 's')
                            {
                                result = Subtract(first, second);
                                Console.WriteLine(first + "-" + second + "=" + result);
                            }
                            else if (operation[0] == 'm')
                            {
                                result = Multiply(first, second);
                                Console.WriteLine(first + "*" + second + "=" + result);
                            }
                            else
                            {
                                result = Divide(first, second);
                                Console.WriteLine(first + "/" + second + "=" + result);
                            }
                        }
                        else
                        {
                           
                            Console.WriteLine("What is your first number?");
                            first = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("What is your second number?");
                            second = Convert.ToDouble(Console.ReadLine());
                            if (operation[0] == 'a')
                            {
                                result = Add(first, second);
                                Console.WriteLine(first + "+" + second + "=" + result);
                            }
                            else if (operation[0] == 's')
                            {
                                result = Subtract(first, second);
                                Console.WriteLine(first + "-" + second + "=" + result);
                            }
                            else if (operation[0] == 'm')
                            {
                                result = Multiply(first, second);
                                Console.WriteLine(first + "*" + second + "=" + result);
                            }
                            else
                            {
                                result = Divide(first, second);
                                Console.WriteLine(first + "/" + second + "=" + result);
                            }
                        }
                    }
                }

            }
            while (cont);
        }

        static void DeveloperInformation(string devName, string className, string date)
        {
            Console.WriteLine("Developer Name:"+ devName);
            Console.WriteLine("Class Name:" + className);
            Console.WriteLine("Date of Development:" + date);

        }

        static double Add(double first, double second)
        { 
            return first + second;
        }
        static double Subtract(double first, double second)
        {
            return first - second;
        }
        static double Divide(double first, double second)
        {
            return first / second;
        }
        static double Multiply(double first, double second)
        {
            return first *second;
        }

    }
}
