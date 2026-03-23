using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal class SalesPerson:Employee
    {
        private double commissionRate;
        private double totalSales;
        public SalesPerson(string name, double baseSalary, double commissionRate, double totalSales) : base(name, baseSalary)
        {
            this.commissionRate = commissionRate;
            this.totalSales = totalSales;
        }

        public double CommissionRate { get => commissionRate; set => commissionRate = value; }
        public double TotalSales { get => totalSales; set => totalSales = value; }

        public override double calculatePay()
        {
            return BaseSalary + (commissionRate * totalSales);
        }
    }
}
