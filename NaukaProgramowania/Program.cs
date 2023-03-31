using NaukaProgramowania.KalkulatorTemperatury;
using NaukaProgramowania.Pojazdy;
using System;
using System.Collections.Generic;

namespace NaukaProgramowania
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var calculator = new KelvinToCelsiusCalculator();
            var tempWKelvinach = 273.0m;
            string bledy = "";
            var tempWCelsiuszach = calculator.PrzeliczNaCeliusze(tempWKelvinach, ref bledy);
            tempWCelsiuszach = calculator.PrzeliczNaCeliusze(tempWKelvinach, ref bledy);
            tempWCelsiuszach = calculator.PrzeliczNaCeliusze(tempWKelvinach, ref bledy);
            tempWCelsiuszach = calculator.PrzeliczNaCeliusze(tempWKelvinach, ref bledy);
            

            //var magazynier = new Magazynier(2500.0m, "Jan Kowalski", "CHŁOP");
            //var kasjer = new Kasjer(2400.0m, "Janina Nowak", "CHŁOKPKA");
            //var kierownik = new Kierownik(2600.0m, "Michał Wiśniewski", "CHŁOP");
            //var pracownicy = new List<Pracownik>();

            //pracownicy.Add(kierownik);
            //pracownicy.Add(kasjer);
            //pracownicy.Add(magazynier);

            //foreach (var pracownik in pracownicy)
            //{
            //    pracownik.Pracuj();
            //    pracownik.PowiedzCoRobisz();
            //}

            //Pojazd samochod = new Samochod();
            //Pojazd motor = new Motor();
            //Pojazd rower = new Rower();
            //var listaPojazdow = new List<Pojazd>();
            //listaPojazdow.Add(samochod);
            //listaPojazdow.Add(motor);
            //listaPojazdow.Add(rower);

            //foreach (var pojazd in listaPojazdow)
            //{
            //    pojazd.Jedz();
            //}

            Console.ReadLine();
        }
    }
}
