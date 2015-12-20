using Blobs.Models;
using System.Collections.Generic;
namespace Blobs.Interfaces
{
    public interface IDatabase
    {
        ICollection<Blob> Blobs { get; }
    }
}
