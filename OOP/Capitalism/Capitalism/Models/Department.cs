using Capitalism.Models.Interfaces;
using System;
using System.Collections.Generic;
namespace Capitalism.Models
{
    public class Department:ICompanyStructure
    {
        public Department()
        {
            this.Employee = new List<IEmployee>();
        }

        public string Name { get; set; }

        public Manager Manager { get; set; }

        public ICollection<IEmployee> Employee { get; set; }
    }
}
