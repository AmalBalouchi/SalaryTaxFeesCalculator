using SalaryTaxFeesCalculator.Interfaces;
using SalaryTaxFeesCalculator.Models;
namespace SalaryTaxFeesCalculator.Services
{
    public class CalculateTaxPercentagePerCountry : ICalculateTaxPercentagePerCountry
    {
        public TaxPercentages CalculateTaxPercentage(string country)
        {
            switch (country) {
            case "AL": 
                return new TaxPercentages (0.30, 0.25, 0.03);
            case "ES": 
                return new TaxPercentages (0.26, 0.23, 0.02);
            case "FR":
                return new TaxPercentages (0.28, 0.22, 0.04);
            case "LX":
                return new TaxPercentages (0.25, 0.20, 0.02);
            case "PB":
                return new TaxPercentages (0.27, 0.24, 0.02);
            case "PT":
                return new TaxPercentages (0.26, 0.22, 0.03);
            case "SD":
                return new TaxPercentages (0.32, 0.32, 0.01);
            default:
                return new TaxPercentages (0.25, 0.20, 0.02);
            }
        }
    }
}
