using System;

namespace NaukaProgramowania
{
    public class Samochod
    {
        public string Marka { get; set; }
        public string Kolor { get; set; }
        public int RokProdukcji { get; set; }
        public int IloscDrzwi { get; set; }
        private bool _czySilnikJestOdpalony;

        public Samochod(int rokProdukcji, int iloscDrzwi, string marka, string kolor)
        {
            RokProdukcji = rokProdukcji;
            IloscDrzwi = iloscDrzwi;
            Marka = marka;
            Kolor = kolor;
            _czySilnikJestOdpalony = false;
        }

        public void WyswietlSzczegoly()
        {
            Console.WriteLine($"Samochód marki: {Marka}, kolor: {Kolor} " +
                $"rok produkcji: {RokProdukcji} ilość drzwi: {IloscDrzwi}");
        }
        public void PrzemalujSamochod(string nowyKolor)
        {
            Kolor = nowyKolor;
        }
        public void OdpalSilnik()
        {
            if(_czySilnikJestOdpalony)
            {
                Console.WriteLine("Silnik jest już odpalony");
            }
            else
            {
                Console.WriteLine("Silnik został odpalony");
                _czySilnikJestOdpalony = true;
            }
        }
        public void ZgasSilnik()
        {
            if (!_czySilnikJestOdpalony)
            {
                Console.WriteLine("Silnik jest już zgaszony");
            }
            else
            {
                Console.WriteLine("Silnik został zgaszony");
                _czySilnikJestOdpalony = false;
            }
        }
    }
}
