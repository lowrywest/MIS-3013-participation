﻿using System;

namespace InClass_ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rect = new Rectangle();
            Rectangle rect2 = new Rectangle(3, 4);
            rect.Length = 10;
            rect.Width = 15;
            Circle circ = new Circle();
            Circle circ2 = new Circle(3.32);
            circ.Radius = 5.0;

            Console.WriteLine("The area of your rectangle is "+rect.CalculateArea().ToString("N2"));
            Console.WriteLine("The perimeter of your rectangle is " + rect.CalculatePerimeter().ToString("N2"));
            Console.WriteLine("The area of your rectangle is " + rect2.CalculateArea().ToString("N2"));
            Console.WriteLine("The perimeter of your rectangle is " + rect2.CalculatePerimeter().ToString("N2"));
            Console.WriteLine("The area of your circle is " + circ.CalculateArea().ToString("N2"));
            Console.WriteLine("The perimeter of your circle is " + circ.CalculatePerimeter().ToString("N2"));
            Console.WriteLine("The area of your circle is " + circ2.CalculateArea().ToString("N2"));
            Console.WriteLine("The perimeter of your circle is " +circ2.CalculatePerimeter().ToString("N2"));


        }
    }
}
