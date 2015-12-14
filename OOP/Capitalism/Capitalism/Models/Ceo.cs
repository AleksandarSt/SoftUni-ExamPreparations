using Capitalism.Models.Interfaces;
using System;
using System.Collections.Generic;
namespace Capitalism.Models
{
    public class Ceo:PaidPerson,IBoss
    {
        public ICollection<IEmployee> SubordinateEmployees { get; set; }
    }
}
