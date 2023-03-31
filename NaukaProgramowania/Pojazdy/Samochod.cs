using NaukaProgramowania.Pojazdy;
using System;

namespace NaukaProgramowania
{
    internal class Samochod : Pojazd
    {
        public int IloscDrzwi { get; set; }
        public string RodzajKaroserii { get; set; }

        public override void Jedz()
        {
            OdpalSilnik();
            base.Jedz();
        }

        private void OdpalSilnik()
        {
            Console.WriteLine("Silnik odpalony");
            SkrecWLewoOXStopni(12.0m);
        }

        private void SkrecWLewoOXStopni(decimal x)
        {
            Console.WriteLine($"Skręcam w lewo o {x} stopni");
        }
    }
}
