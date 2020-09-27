using BFC.Logger.Domain;
using BFC.Logger.Domain.Log;
using BFC.Logger.Domain.Log.Abstractions;

namespace BFC.Logger
{
    public static class LogHelper
    {
        private static LogBase logger = null;
        public static void Log(string message)
        {
            switch (LoggerConfiguration.loggerTarget)
            {
                case LogTarget.File:
                    logger = new FileLogger();
                    logger.Log(message);
                    break;
                case LogTarget.Database:
                    logger = new DBLogger();
                    logger.Log(message);
                    break;
                case LogTarget.EventLog:
                    logger = new EventLogger();
                    logger.Log(message);
                    break;
                default:
                    return;
            }
        }
    }
}
