using System;

namespace BLL
{
    public class RelacionDuplicadaException : Exception
    {
        public RelacionDuplicadaException(string message) : base(message) { }
    }
}
