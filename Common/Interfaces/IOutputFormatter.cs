using Common.Enums;

namespace Common.Interfaces
{
    public interface IOutputFormatter
    {
        string Format(string message, LogType logType);
    }
}
