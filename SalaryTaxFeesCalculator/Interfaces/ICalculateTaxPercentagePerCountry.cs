using SalaryTaxFeesCalculator.Models;

namespace SalaryTaxFeesCalculator.Interfaces
{
    public interface ICalculateTaxPercentagePerCountry
    {
        public TaxPercentages CalculateTaxPercentage(string country);
    }
}
