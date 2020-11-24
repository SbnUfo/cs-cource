using System;
using System.Collections.Generic;

namespace HW15
{
    interface ILogWriter
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }

    class LogWriterFactory
    {
        private static LogWriterFactory instance;

        public static LogWriterFactory Instanse =>
            instance ?? new LogWriterFactory();

        private LogWriterFactory() { }

        public ILogWriter GetLogWriter<T>(object parameters)
            where T : ILogWriter
        {
            if (typeof(T) == typeof(FileLogWriter))
                return new FileLogWriter((string)parameters);

            else if (typeof(T) == typeof(ConsoleLogWriter))
                return new ConsoleLogWriter();

            else if (typeof(T) == typeof(MultipleLogWriter))
                return new MultipleLogWriter(parameters as List<ILogWriter>);

            else
                throw new ArgumentOutOfRangeException("<T> Must be FileLogWriter, ConsoleLogWriter or MultipleLogWriter!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var logWriter = LogWriterFactory.Instanse;

            var fileLogWriter = logWriter.GetLogWriter<FileLogWriter>("log_file.txt");

            var consoleLogWriter = logWriter.GetLogWriter<ConsoleLogWriter>(null);

            var multipleLogWriter = logWriter.GetLogWriter<MultipleLogWriter>(
                new List<ILogWriter>
                {
                    fileLogWriter,
                    consoleLogWriter
                });

            multipleLogWriter.LogInfo("Something");
        }
    }
}