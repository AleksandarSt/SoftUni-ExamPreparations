using Capitalism.Models.Interfaces;
namespace Capitalism.Models
{
    public abstract class PaidPerson:IPerson,IPaidPerson
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }
    }
}
