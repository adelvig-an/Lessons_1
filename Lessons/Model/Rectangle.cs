using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Model
{
    public class Rectangle : Figures
    {
        public double Width { get; set; }
        public double Height { get; set; }

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
