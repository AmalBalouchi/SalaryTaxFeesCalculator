using Microsoft.AspNetCore.Routing.Constraints;

namespace SalaryTaxFeesCalculator.Models
{
    public class TaxPercentages
    {
        public double taxPercentageForSingle { get; set; }
        public double taxPercentageForMarried { get; set; }
        public double taxReductionPerChild { get; set; }

        public TaxPercentages(double taxPercentageForSingle, double taxPercentageForMarried, double taxReductionPerChild)
        {
            this.taxPercentageForSingle = taxPercentageForSingle;
            this.taxPercentageForMarried = taxPercentageForMarried;
            this.taxReductionPerChild = taxReductionPerChild;
        }
    }
}
