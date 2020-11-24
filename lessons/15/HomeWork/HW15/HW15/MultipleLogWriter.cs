using System.Collections.Generic;

namespace HW15
{
    class MultipleLogWriter : ILogWriter
    {
        private List<ILogWriter> _logsList;

        public MultipleLogWriter(List<ILogWriter> logsList) =>
            _logsList = logsList;

        public void LogInfo(string message) =>
            _logsList.ForEach(x => x.LogInfo(message));

        public void LogWarning(string message) =>
            _logsList.ForEach(x => x.LogWarning(message));

        public void LogError(string message) =>
            _logsList.ForEach(x => x.LogError(message));
    }
}