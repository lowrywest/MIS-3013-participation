using System;
using System.Collections.Generic;
using System.Text;

namespace InClass_ClassExample
{
    class Circle
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 0;
        }
        public Circle(double rad)
        {
            Radius = rad;
        }
        public double CalculateArea()
        {
            return (Math.PI * (Radius * Radius));
        }
        public double CalculatePerimeter()
        {
            return ((2 * Math.PI) * Radius);
        }
    }
}
