﻿using Blobs.Interfaces;
using System;

namespace Blobs.UserInterface
{
    public class ConsoleUI : IUserInterface
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }

        public void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }
    }
}
