namespace Capitalism.Models
{
    public class Employee:PaidPerson
    {
        public Department Department { get; set; }

        protected double SalaryFactor { get; set; }
    }
}
