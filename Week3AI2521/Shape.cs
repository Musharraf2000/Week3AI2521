using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal abstract class Shape
    {
        private string name;

        protected Shape(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }

        public abstract double CalculateArea();
    }
}
