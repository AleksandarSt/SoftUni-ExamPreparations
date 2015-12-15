using System;
using Capitalism.Models.Interfaces;
namespace Capitalism.Models
{
    public abstract class PaidPerson:IPerson,IPaidPerson
    {
        private string firstName;

        private string lastName;

        private decimal salary;

        public string FirstName 
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)||value.Length<2)
                {
                    throw new ArgumentException("First name must be at least 2 symbols long");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentException("Last name must be at least 2 symbols long");
                }
                this.lastName = value;
            }
        }

        public decimal Salary {
            get
            {
                return this.salary;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException("salary","The salary should be positive.");
                }
                this.salary = value;
            }
        }
    }
}
