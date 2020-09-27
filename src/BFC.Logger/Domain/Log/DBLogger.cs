using BFC.Logger.Domain.Log.Abstractions;

namespace BFC.Logger.Domain.Log
{
    internal class DBLogger : LogBase
    {
        string connectionString = string.Empty;
        public override void Log(string message)
        {
            //Code to log data to the database
        }
    }
}
