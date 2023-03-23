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
        }
    }
}
