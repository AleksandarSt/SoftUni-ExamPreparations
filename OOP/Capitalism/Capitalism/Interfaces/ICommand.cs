using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Interfaces
{
    public interface ICommand
    {
        string Name { get; }

        IList<string> Parameters { get; }
    }
}
