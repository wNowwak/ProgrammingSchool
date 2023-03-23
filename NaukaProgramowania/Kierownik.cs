using System;

namespace NaukaProgramowania
{
    public class Kierownik : Pracownik
    {
        public int IloscPodwladnych { get; set; }
        public Kierownik(decimal wyplata, string imieNazwisko, string plec) : base(wyplata, imieNazwisko, plec)
        {
            IloscPodwladnych = 10;
        }

        public override void PowiedzCoRobisz()
        {
            Console.WriteLine($"Siedze na dupie");
        }
    }
}
