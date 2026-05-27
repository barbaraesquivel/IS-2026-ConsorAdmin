using System;

namespace BLL
{
    public class UnidadDuplicadaException : Exception
    {
        public UnidadDuplicadaException(string message) : base(message) { }
    }
}
