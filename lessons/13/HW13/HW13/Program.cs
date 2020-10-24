using System.Collections.Generic;

namespace HW13
{

    class Program
    {
        static void Main(string[] args)
        {
            var fileLogWriter = new FileLogWriter();
            fileLogWriter.LogError("FileLogWriter says there is an error!");

            var consoleLogWriter = new ConsoleLogWriter();
            consoleLogWriter.LogWarning("ConsoleLogWriter says there is a warning!");

            var multipleLogWriter = new MultipleLogWriter(new List<AbstractLogWriter>
            {
                new FileLogWriter(),
                new ConsoleLogWriter(),
                new MultipleLogWriter(new List<AbstractLogWriter>
                {
                    new ConsoleLogWriter(),
                    new ConsoleLogWriter()
                })
            });
            multipleLogWriter.LogInfo("MultipleLogWriter created");
        }
    }
}
