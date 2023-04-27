using Common.Enums;

namespace Common.Interfaces
{
    public interface IUserLogger
    {
        void Log(string message, LogType logType);
    }
}
