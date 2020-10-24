using System.IO;

namespace HW13
{
    class FileLogWriter : AbstractLogWriter
    {
        public string FileName { get; }
        public FileLogWriter(string fileName = "log.txt") =>
            FileName = fileName;

        public override void LogInfo(string message) =>
            File.AppendAllText(FileName, FormatMessage(message, "Info"));

        public override void LogWarning(string message) =>
            File.AppendAllText(FileName, FormatMessage(message, "Warning"));

        public override void LogError(string message) =>
            File.AppendAllText(FileName, FormatMessage(message, "Error"));

        public void ClearLogs() =>
            File.WriteAllText(FileName, "");
    }
}
