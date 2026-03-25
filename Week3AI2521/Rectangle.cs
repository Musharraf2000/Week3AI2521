using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal class Rectangle:Shape
    {
        private double width;
        private double length;

        public Rectangle(string name, double width, double length):base(name)
        {
            this.width = width;
            this.length = length;
        }

        public double Width { get => width; set => width = value; }
        public double Length { get => length; set => length = value; }

        public override double CalculateArea()
        {
            return width * length;
        }
    }
}
