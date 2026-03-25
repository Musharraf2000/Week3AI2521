using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal class Circle:Shape
    {
        private double radius;

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius,2);
        }
    }
}
