using System.Collections.Generic;

namespace HW13
{
    class MultipleLogWriter : AbstractLogWriter
    {
        private List<AbstractLogWriter> _logsList;

        public MultipleLogWriter(List<AbstractLogWriter> logsList) =>
            _logsList = logsList;

        public override void LogInfo(string message)
        {
            foreach (var log in _logsList)
                log.LogInfo(message);
        }

        public override void LogWarning(string message)
        {
            foreach (var log in _logsList)
                log.LogWarning(message);
        }

        public override void LogError(string message)
        {
            foreach (var log in _logsList)
                log.LogError(message);
        }
    }
}
