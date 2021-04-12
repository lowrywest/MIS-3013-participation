using System;
using System.Collections.Generic;
using System.Text;

namespace InClass_ClassExample
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }
        public Rectangle(double len, double wid)
        {
            Length = len;
            Width = wid;
        }
        public double CalculateArea()
        {
            return Width * Length;
        }
        public double CalculatePerimeter()
        {
            return 2*(Length + Width);
        }
    }
}
