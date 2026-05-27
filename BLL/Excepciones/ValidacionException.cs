using System;

namespace BLL
{
    public class ValidacionException : Exception
    {
        public ValidacionException(string message) : base(message) { }
    }
}
