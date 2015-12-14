namespace Capitalism.Models
{
    public class CleaningLady : Employee
    {
        protected override double SalaryFactor
        {
            get 
            {
                return 0.98;
            }
        }
    }
}
