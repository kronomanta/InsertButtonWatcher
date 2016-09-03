using System;

namespace InsertButtonWatcher.Logging
{
    public interface ILogger
    {
        void LogException(Exception exception);
        void LogException(Exception exception, string customMessage);
        void LogError(string message);
        void LogDebug(string message);
        void LogWarningMessage(string message);
        void LogInfoMessage(string message);
    }
}