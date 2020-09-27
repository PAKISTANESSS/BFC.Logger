using BFC.Logger.Domain;

namespace BFC.Logger
{
    public static class LoggerConfiguration
    {
        internal static LogTarget? loggerTarget = null;

        public static LogTarget Setup(LogTarget target)
        {
            loggerTarget = target;

            return loggerTarget.Value;
        }
    }
}
