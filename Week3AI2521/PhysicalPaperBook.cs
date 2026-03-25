using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal class PhysicalPaperBook:Book, IDistributable
    {
          private double printCostPerUnit;
        public PhysicalPaperBook(double baseRetailPrice, int copiesSold, double printCostPerUnit) : base(baseRetailPrice, copiesSold)
        {
            this.printCostPerUnit = printCostPerUnit;
        }
        public double PrintCostPerUnit { get => printCostPerUnit; set => printCostPerUnit = value; }
        public override double CalculateAuthorRoyalty()
        {
            return 0.15 * (BaseRetailPrice * CopiesSold);
        }
        public double calculateDistributionFee()
        {
            return (printCostPerUnit * CopiesSold) + 50.00;
        }
    }
}
