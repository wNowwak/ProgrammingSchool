using Common.Enums;
using Common.Interfaces;
using System;

namespace Common.Formatters
{
    public class OutputFormatter : IOutputFormatter
    {
        public string Format(string message, LogType logType)
        {
            message = $"{DateTime.Now} - {message}";
            switch (logType)
            {
                case LogType.Warning:
                    return $"#WARNING: {message}";
                case LogType.Error:
                    return $"#ERROR: {message}";
                case LogType.Info:
                default:
                    return $"#INFO: {message}";
            }
        }
    }
}
