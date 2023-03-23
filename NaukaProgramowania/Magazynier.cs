using System;
using System.Runtime.CompilerServices;

namespace NaukaProgramowania
{
    internal class Magazynier : Pracownik
    {
        public int IloscWypitegoAlkoholu { get; set; }
        public Magazynier(decimal wyplata, string imieNazwisko, string plec) : base(wyplata, imieNazwisko, plec)
        {

        }

        public override void PowiedzCoRobisz()
        {
            Console.WriteLine("To ja tutaj pracuję?");
        }
    }
}
