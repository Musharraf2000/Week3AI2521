using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal abstract class Book: IDistributable
    {
        private double baseRetailPrice;
        private int copiesSold;

        public Book(double baseRetailPrice, int copiesSold)
        {
            this.baseRetailPrice = baseRetailPrice;
            this.copiesSold = copiesSold;
        }

        public double BaseRetailPrice { get => baseRetailPrice; set => baseRetailPrice = value; }
        public int CopiesSold { get => copiesSold; set => copiesSold = value; }

        public abstract double CalculateAuthorRoyalty();

        public double calculateDistributionFee()
        {
           return 0.1 * (baseRetailPrice * copiesSold); 
        }

        public double calculateNetProfit()
        {
            return (baseRetailPrice * copiesSold) - CalculateAuthorRoyalty() - calculateDistributionFee();
        }
    }
}
