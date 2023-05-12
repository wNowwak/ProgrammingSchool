using Common.Enums;
using Common.Formatters;
using Common.Interfaces;
using Common.Loggers;
using Modele;
using System;

namespace NaukaProgramowania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOutputFormatter outputFormatter = new OutputFormatter();
            IUserLogger userLogger = new ConsoleLogger(outputFormatter);

            var czlowiek = new Czlowiek
            {
                Imie = "Marcin",
                Nazwisko = "Hasiak",
                Wiek = 26,
                CzyChlop = true
            };

            czlowiek.PrzedstawSie();
            czlowiek.ZmienPlec();
            czlowiek.PrzedstawSie();



            Console.ReadLine();
        }
    }
}
