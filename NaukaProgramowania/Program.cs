using Common.Formatters;
using Common.Interfaces;
using Common.Loggers;
using NaukaProgramowania.WebClients;
using NaukaProgramowania.WebClients.Interfaces;
using System;

namespace NaukaProgramowania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOutputFormatter outputFormatter = new OutputFormatter();
            IUserLogger userLogger = new ConsoleLogger(outputFormatter);
            ICurrencyWebClient currencyWebClient = new NbpWebClient();
            for (int i = 0; i > -60; i--)
            {
                currencyWebClient.GetGoldRateInSpecificDate(DateTime.Now.AddDays(i));
            }
            Console.ReadLine();
        }
    }
}
