using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal class Employee
    {
        private string name;
        private double baseSalary;

        public Employee(string name, double baseSalary)
        {
            this.name = name;
            this.baseSalary = baseSalary;
        }

        public string Name { get => name; set => name = value; }
        public double BaseSalary { get => baseSalary; set => baseSalary = value; }

        public virtual double calculatePay()
        {
            return baseSalary;
        }
    }
}
