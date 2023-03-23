using System;

namespace NaukaProgramowania.Pojazdy
{
    internal class Pojazd
    {
        public int IloscKol { get; set; }
        public int IloscMiejsc { get; set; }
        public int PredkoscMaks { get; set; }
        public string Producent { get; set; }

        public virtual void Jedz()
        {
            Console.WriteLine("Rozpoczynam jazdę");
        }
    }
}
