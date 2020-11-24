﻿using System;

namespace HW15
{
    abstract class AbstractLogWriter : ILogWriter
    {
        public abstract void LogInfo(string message);
        public abstract void LogWarning(string message);
        public abstract void LogError(string message);

        protected string FormatMessage(string message, string messageType) =>
            $"{DateTimeOffset.Now}\t{messageType}\t{message}\n";
    }
}