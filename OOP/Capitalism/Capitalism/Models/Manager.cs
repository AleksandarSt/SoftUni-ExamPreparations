using Capitalism.Models.Interfaces;
using System;
namespace Capitalism.Models
{
    public class Manager:IBoss
    {
        public System.Collections.Generic.ICollection<IEmployee> SubordinateEmployees { get; }
    }
}
