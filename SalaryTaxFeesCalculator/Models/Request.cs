namespace SalaryTaxFeesCalculator.Models
{
    public class Request
    {
        public double AnnualGrossSalary { get; set; }
        public bool IsMarried { get; set; }
        public int NumberOfChildren { get; set; }
        public string Country { get; set; }
    }
}
