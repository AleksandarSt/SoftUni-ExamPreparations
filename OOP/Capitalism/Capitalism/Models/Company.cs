using System;
using Capitalism.Models.Interfaces;
using System.Collections.Generic;
namespace Capitalism.Models
{
    public class Company : ICompanyStructure
    {
        private string name;
        private CEO ceo;

        public Company(string name,CEO ceo)
        {
            this.Name = name;
            this.CEO = ceo;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name","The name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public CEO CEO 
        {
            get 
            { return this.ceo; }
            set
            {
                if (value==null)
                {
                    throw new ArgumentNullException("CEO","A company must have CEO");
                }
                this.ceo = value;
            }
        }

        public ICollection<Department> Department { get; set; }
    }
}
