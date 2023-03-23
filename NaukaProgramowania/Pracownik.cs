using System;

namespace NaukaProgramowania
{
    public abstract class Pracownik
    {
        protected decimal Wyplata { get; set; }
        protected string ImieNazwisko { get; set; }
        protected string Plec { get; set; }

        public Pracownik(decimal wyplata, string imieNazwisko, string plec)
        {
            Wyplata = wyplata;
            ImieNazwisko = imieNazwisko;
            Plec = plec;
        }

        public virtual void Pracuj()
        {
            Console.WriteLine($"{ImieNazwisko} teraz pracuje");
        }

        public abstract void PowiedzCoRobisz();
    }
}
