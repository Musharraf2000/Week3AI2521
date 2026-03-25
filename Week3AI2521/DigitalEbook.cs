using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal class DigitalEbook:Book,IDistributable
    {
        public DigitalEbook(double baseRetailPrice, int copiesSold) : base(baseRetailPrice, copiesSold)
        {
        }
        public override double CalculateAuthorRoyalty()
        {
            return 0.7 * (BaseRetailPrice * CopiesSold);
        }

        public double calculateDistributionFee()
        {
            return 0.15  * CopiesSold;
        }
    }
}
