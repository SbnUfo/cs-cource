using System;

namespace HW15
{
    class ConsoleLogWriter : AbstractLogWriter
    {
        public override void LogInfo(string message) =>
            ConsoleWriteColorized(FormatMessage(message, "Info"), ConsoleColor.Cyan);

        public override void LogWarning(string message) =>
            ConsoleWriteColorized(FormatMessage(message, "Warning"), ConsoleColor.Yellow);

        public override void LogError(string message) =>
            ConsoleWriteColorized(FormatMessage(message, "Error"), ConsoleColor.Red);

        private void ConsoleWriteColorized(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}