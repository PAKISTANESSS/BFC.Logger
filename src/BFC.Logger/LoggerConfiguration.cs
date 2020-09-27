using BFC.Logger.Domain;
using BFC.Logger.Exceptions;
using System.IO;

namespace BFC.Logger
{
    public static class LoggerConfiguration
    {
        internal static LogTarget? _loggerTarget = null;
        internal static string _pathToLogs = null;

        /// <summary>
        /// Setups a Logger for a file
        /// </summary>
        /// <param name="pathToLogs">Path to log files</param>
        /// <returns></returns>
        public static LogTarget Setup(string pathToLogs)
        {
            if (string.IsNullOrEmpty(pathToLogs))
            {
                throw new LoggerException("Path to Log cannot be null or empty");
            }

            if (!Directory.Exists(pathToLogs))
            {
                throw new LoggerException("Path to Log cannot be null or empty");
            }

            _pathToLogs = pathToLogs;
            _loggerTarget = LogTarget.File;

            return _loggerTarget.Value;
        }
    }
}
