using Modele;
using System;

namespace NaukaProgramowania
{
    public static class CzlowiekExtensionsMethod
    {
        public static void PrzedstawSie(this Czlowiek czlowiek)
        {
            Console.WriteLine($"Nazywam się {czlowiek.Imie} {czlowiek.Nazwisko} i mam {czlowiek.Wiek} lat i jestem " +
                $"{(czlowiek.CzyChlop ? "chłopem" : "chłopką")}");
        }

        public static void ZmienPlec(this Czlowiek czlowiek)
        {
            czlowiek.CzyChlop = !czlowiek.CzyChlop;
        }
    }
}
