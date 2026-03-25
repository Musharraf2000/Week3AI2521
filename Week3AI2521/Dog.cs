using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
        public override void Move()
        {
            Console.WriteLine("Dog runs and walks");
        }
    }

}
