using System;
using System.Globalization;

namespace InsertButtonWatcher.Logging
{
    public static class LogHelper
    {
        private static readonly ILogger logger = new Logger();

        public static void LogInfo(string message)
        {
            logger.LogInfoMessage(message);
        }

        public static void LogInfo(string pattern, params object[] args)
        {
            LogInfo(string.Format(CultureInfo.InvariantCulture, pattern, args));
        }

        public static void LogDebug(string message)
        {
            logger.LogDebug(message);
        }

        public static void LogDebug(string pattern, params object[] args)
        {
            LogDebug(string.Format(CultureInfo.InvariantCulture, pattern, args));
        }

        public static void LogError(string message)
        {
            logger.LogError(message);
        }

        public static void LogError(string pattern, params object[] args)
        {
            LogError(string.Format(CultureInfo.InvariantCulture, pattern, args));
        }

        public static void LogException(Exception exception, string message)
        {
            logger.LogException(exception, message);
        }

        public static void LogException(
            Exception exception, string pattern, params object[] args)
        {
            string message = string.Format(CultureInfo.InvariantCulture, pattern, args);
            LogException(exception, message);
        }

        public static void LogException(Exception ex)
        {
            logger.LogException(ex);
        }

        public static void SetThreadVariable(string key, string variable)
        {
            log4net.ThreadContext.Properties[key] = variable;
        }

        public static void SetGlobalVariable(string key, string variable)
        {
            log4net.GlobalContext.Properties[key] = variable;
        }
    }
}