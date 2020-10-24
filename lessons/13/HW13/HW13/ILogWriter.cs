namespace HW13
{
    interface ILogWriter
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}
