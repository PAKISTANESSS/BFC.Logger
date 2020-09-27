using BFC.Logger.Domain.Log.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BFC.Logger.Domain.Log
{
    internal class FileLogger : LogBase
    {
        public override void Log(string message)
        {
            lock (lockObj)
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.WriteLine(message);
                    streamWriter.Close();
                }
            }
        }
    }
}
