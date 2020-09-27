using BFC.Logger.Domain.Log.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Logger.Domain.Log
{
    internal class EventLogger : LogBase
    {
        public override void Log(string message)
        {
            //EventLog eventLog = new EventLog("");
            //eventLog.Source = "IDGEventLog";
            //eventLog.WriteEntry(message);
        }
    }
}
