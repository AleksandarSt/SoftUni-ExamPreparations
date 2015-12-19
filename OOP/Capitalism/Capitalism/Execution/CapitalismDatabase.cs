using Capitalism.Interfaces;
using Capitalism.Models;
using System;
using System.Collections.Generic;
namespace Capitalism.Execution
{
    public class CapitalismDatabase:IDatabase
    {
        public CapitalismDatabase()
        {
            this.Companies = new List<Company>();
        }

        public ICollection<Company> Companies { get; set; }
    }
}
