using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Model
{
    public class Rectangle : Figures
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double P
        {
            get { return Width * 2 + Height * 2; }
        }

        public override double Area
        {
            get { return Width * Height; }
        }
    }
}
