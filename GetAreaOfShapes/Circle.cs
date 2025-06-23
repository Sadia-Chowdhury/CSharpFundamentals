using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAreaOfShapes
{
    internal class Circle: Shape
    {
        private double Radius { get; set; }
        public Circle(double radius) 
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            double area = Math.PI * Radius*Radius;
            return area;
        }
    }
}
