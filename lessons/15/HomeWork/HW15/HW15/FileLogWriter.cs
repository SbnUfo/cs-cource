using System.IO;

namespace HW15
{
    class FileLogWriter : AbstractLogWriter
    {
        public string FileName { get; set; }

        public static string DefaultFileName { get; } = "log.txt";

        public FileLogWriter(string fileName) =>
            FileName = fileName ?? DefaultFileName;

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