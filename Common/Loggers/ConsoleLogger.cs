using Common.Enums;
using Common.Interfaces;
using System;

namespace Common.Loggers
{
    public class ConsoleLogger : IUserLogger
    {
        private readonly IOutputFormatter _outputFormatter;

        public ConsoleLogger(IOutputFormatter outputFormatter)
        {
            _outputFormatter = outputFormatter;
        }

        public void Log(string message, LogType logType)
        {
            Console.WriteLine(_outputFormatter.Format(message,logType));
        }
    }
}
