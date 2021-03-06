﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Model
{
    public class Square : Figures
    {
        public double Width { get; set; }

        public override double P
        {
            get { return Width * 4; }
        }

        public override double Area
        {
            get { return Width * Width; }
        }
    }
}
