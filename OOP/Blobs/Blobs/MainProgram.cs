using Blobs.Execution;
using Blobs.Interfaces;

namespace Blobs
{
    class MainProgram
    {
        static void Main()
        {
            IEngine engine = new BlobsEngine();
            engine.Run();
        }
    }
}
