using Capitalism.Models.Interfaces;
using System.Collections.Generic;
namespace Capitalism.Models
{
    public class Company : ICompanyStructure
    {
        public string Name { get; set; }

        public ICollection<Department> Department { get; set; }

        public Ceo Ceo { get; set; }
    }
}
