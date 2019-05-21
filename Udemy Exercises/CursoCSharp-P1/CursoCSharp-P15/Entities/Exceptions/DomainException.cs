using System;

namespace CursoCSharp_P15.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string message) : base(message) { }
    }
}
