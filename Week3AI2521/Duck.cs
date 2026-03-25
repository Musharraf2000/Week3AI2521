using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal class Duck:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Quack");
        }
        public override void Move()
        {
            Console.WriteLine("Duck swims and walks");
        }
    }
}
