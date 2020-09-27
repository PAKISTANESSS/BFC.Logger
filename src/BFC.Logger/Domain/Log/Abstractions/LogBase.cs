using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Logger.Domain.Log.Abstractions
{
    public abstract class LogBase
    {
        protected readonly object lockObj = new object();
        public abstract void Log(string message);
    }
}
