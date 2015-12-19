using Capitalism.Models;
using System.Collections.Generic;
namespace Capitalism.Interfaces
{
    public interface IDatabase
    {
        ICollection<Company> Companies { get; }
    }
}
