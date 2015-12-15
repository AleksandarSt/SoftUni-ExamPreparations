using Capitalism.Models.Interfaces;
using System;
using System.Collections.Generic;
namespace Capitalism.Models
{
    public class Department:ICompanyStructure
    {
        private string name;

        private Manager manager;
        public Department()
        {
            this.Employee = new List<IEmployee>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)||value.Length<5)
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public Manager Manager
        {
            get
            { return this.manager; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("manager", "A department must have manager");
                }
                this.manager = value;
            }
        }

        public ICollection<IEmployee> Employee { get; set; }
    }
}
