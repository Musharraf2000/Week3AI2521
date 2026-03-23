using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal class Manager:Employee
    {
        private double monthlyBonus;

        public Manager(string name, double baseSalary,double monthlyBonus) : base(name, baseSalary)
        {
            this.monthlyBonus = monthlyBonus;
        }

        public override double calculatePay()
        {
            return BaseSalary + monthlyBonus;
        }
    }
}
