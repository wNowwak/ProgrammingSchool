using Common.Enums;
using Common.Formatters;
using Common.Interfaces;
using Common.Loggers;
using System;

namespace NaukaProgramowania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOutputFormatter outputFormatter = new OutputFormatter();
            IUserLogger userLogger = new ConsoleLogger(outputFormatter);

            userLogger.Log("Test 123", LogType.Info);
            userLogger.Log("Test 123", LogType.Warning);
            userLogger.Log("Test 123", LogType.Error);

            Console.ReadLine();
        }
    }
}
