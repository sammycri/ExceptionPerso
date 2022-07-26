using System;
using System.Collections.Generic;
using System.Text;

namespace Exception01.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message): base(message)
        {
        }
    }
}
