using System;

namespace NaukaProgramowania.KalkulatorTemperatury
{
    public class KelvinToCelsiusCalculator
    {
        public decimal PrzeliczNaCeliusze(decimal temperaturaWKelvinach, ref string bledy)
        {
            Console.WriteLine($"Przeliczam {temperaturaWKelvinach} na celsiusze");
            var result = temperaturaWKelvinach - 273;
            Console.WriteLine($"Temperatura w celsiuszach to {result}");
            bledy += "BRAK";
            Test(out string  bledy1);
            return result;
        }
        private void Test(out string x)
        {
            x = "Hello world";
        }
    }
}
