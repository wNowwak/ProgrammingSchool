using NaukaProgramowania.Pojazdy;

namespace NaukaProgramowania.KalkulatorTemperatury
{
    public class KalkulatoMnozenia : IKalkulatorMnozenia
    {
        public double PomnozLiczbe(double x, double y)
        {
            var wynik = 0.0;
            for (int i = 0; i < y; i++)
            {
                wynik += x;
            }
            return wynik;
        }
    }
}
