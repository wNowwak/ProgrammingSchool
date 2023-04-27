using Common.Enums;
using Common.Interfaces;
using System.IO;

namespace Common.Loggers
{
    public class FileLogger : IUserLogger
    {
        private const string _fileName = @"F:\repo\NaukaProgramowania\Logi\logi.txt";
        private readonly IOutputFormatter _outputFormatter;

        public FileLogger(IOutputFormatter outputFormatter)
        {
            _outputFormatter = outputFormatter;
        }

        public void Log(string message, LogType logType)
        {
            using (var writer = new StreamWriter(_fileName,true))
            {
                writer.WriteLine(_outputFormatter.Format(message, logType));
            }
        }
    }
}
