using Blobs.Interfaces;
using Blobs.Models;
using System;
using System.Collections.Generic;

namespace Blobs.Execution
{

    public class BlobsDatabase : IDatabase
    {
        public BlobsDatabase()
        {
            this.Blobs = new List<Blob>();
        }

        public ICollection<Blob> Blobs { get; set; }
    }
}
