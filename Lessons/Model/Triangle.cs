using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Model
{
    public class Triangle : Figures
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double P
        {
            get { return SideA + SideB + SideC; }
        }

        public override double Area
        {
            get { return Width * Height; }
        }
    }
}
