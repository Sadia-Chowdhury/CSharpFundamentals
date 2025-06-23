﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAreaOfShapes
{
    internal class Rectangle :Shape 
    {
        public double Width {  get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) { 
            this.Width = width;
            this.Height = height;
        }

        public override double GetArea()
        {
            double area = Width * Height;
            return area;
        }
    }
}
