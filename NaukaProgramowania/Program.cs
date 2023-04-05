using NaukaProgramowania.KalkulatorTemperatury;
using NaukaProgramowania.Pojazdy;
using Ninject;
using System;
using System.Collections.Generic;

namespace NaukaProgramowania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var kernel = new StandardKernel(new NaukaProgramowaniaDependencyInjection()))
            {
                var kalkulator = kernel.Get<IKalkulator>();

                var wynikMnozenia = kalkulator.Pomnoz(2, 5);
                var wynikPotegowania = kalkulator.ObliczPotege(2, 5);
            }

            


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
