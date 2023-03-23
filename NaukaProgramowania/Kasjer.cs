using System;

namespace NaukaProgramowania
{
    public class Kasjer : Pracownik
    {
        public int IloscKlientow { get; set; }
        public Kasjer(decimal wyplata, string imieNazwisko, string plec) : base(wyplata, imieNazwisko, plec)
        {

        }

        public override void PowiedzCoRobisz()
        {
            Console.WriteLine("Pracuję na tego złodzieja");
        }

        public override void Pracuj()
        {
            Console.WriteLine($"Przeciążona metoda działa inaczej");
        }
    }
}
