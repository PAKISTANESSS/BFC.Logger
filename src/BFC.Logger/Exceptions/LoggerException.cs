using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Logger.Exceptions
{
    public class LoggerException : Exception
    {
        public LoggerException(string message) : base(message)
        {
        }

        public LoggerException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
