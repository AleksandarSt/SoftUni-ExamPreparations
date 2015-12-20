﻿using Blobs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blobs.Execution
{
    public class Command : ICommand
    {
        public Command(string commandString)
        {
            string[] commandParts = commandString.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            this.Name = commandParts[0];
            if (commandParts.Length > 1)
            {
                this.Parameters = commandParts.Skip(1).ToArray();
            }


        }

        public string Name { get; set; }

        public IList<string> Parameters { get; set; }

    }
}
