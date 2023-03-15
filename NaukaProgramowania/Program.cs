using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NaukaProgramowania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod(2000, 4, "Seat", "Czerwony");
            samochod.WyswietlSzczegoly();
            samochod.PrzemalujSamochod("Czarny");
            samochod.WyswietlSzczegoly();
            while (true)
            {
                var wcisnietyPrzycisk = Console.ReadKey();
                if (wcisnietyPrzycisk.Key == ConsoleKey.Enter)
                    samochod.OdpalSilnik();
                else if(wcisnietyPrzycisk.Key == ConsoleKey.Escape)
                    samochod.ZgasSilnik();
            }
        }
    }
}
