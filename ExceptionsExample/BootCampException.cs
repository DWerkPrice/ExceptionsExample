using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsExample
{
    public class BootCampException : Exception  // 3 constructors should be created
    {
        public BootCampException() : base() {}  // 1st constructor

        public BootCampException(string message) : base(message) { }

        public BootCampException(string message , Exception innerException) : base(message , innerException) { }

    }
}
