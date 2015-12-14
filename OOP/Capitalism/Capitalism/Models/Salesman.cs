namespace Capitalism.Models
{
    public class Salesman : Employee
    {
        protected override double SalaryFactor
        {
            get
            {
                return 1.015;
            }
        }
    }
}
