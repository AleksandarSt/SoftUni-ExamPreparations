using Capitalism.Models.Interfaces;
using System;
using System.Collections.Generic;
namespace Capitalism.Models
{
    public class Ceo:IBoss
    {
        public ICollection<IEmployee> SubordinateEmployees { get;}
    }
}
