using System;
using ExceptionsCourse;
using ExceptionsCourse.Entities;
using ExceptionsCourse.Entities.Exceptions;

namespace ExceptionsCourse.Entities.Exceptions
{
    public sealed class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
