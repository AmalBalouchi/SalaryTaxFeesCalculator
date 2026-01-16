using Microsoft.AspNetCore.Mvc;
using SalaryTaxFeesCalculator.Interfaces;
using SalaryTaxFeesCalculator.Models;
using System.Runtime.CompilerServices;

namespace SalaryTaxFeesCalculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaxCalculatorController : Controller
    {
        private readonly ICalculateTaxPercentagePerCountry _calculateTaxPercentagePerCountry;

        public TaxCalculatorController(ICalculateTaxPercentagePerCountry calculateTaxPercentagePerCountry)
        {
            _calculateTaxPercentagePerCountry = calculateTaxPercentagePerCountry;
        }

        [HttpPost("CalculateTax")]

        public IActionResult CalculateTax([FromBody] Request request)
        {
            TaxPercentages taxPercentages = _calculateTaxPercentagePerCountry.CalculateTaxPercentage(request.Country);
            double taxRate = request.IsMarried ? taxPercentages.taxPercentageForSingle : taxPercentages.taxPercentageForMarried;
            taxRate -= request.NumberOfChildren * taxPercentages.taxReductionPerChild;

            if (taxRate < 0.10)
            {
                taxRate = 0.10;
            }
            Response response = new Response();
            response.TaxPercentage = taxRate * 100;
            response.AnnualNetSalary = request.AnnualGrossSalary - (request.AnnualGrossSalary * taxRate);
            response.MonthlyNetSalary = Math.Round((response.AnnualNetSalary / 12), 2);
            
            return Ok(response);
        }
    }
}
