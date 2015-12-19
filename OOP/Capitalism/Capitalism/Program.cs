using Capitalism.Execution;
using Capitalism.Interfaces;

namespace Capitalism
{
    public class Program
    {
        public static void Main()
        {
            IEngine engine = new CapitalismEngine();
            engine.Run();
        }
    }
}
