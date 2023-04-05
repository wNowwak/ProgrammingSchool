namespace NaukaProgramowania.KalkulatorTemperatury
{
    public class KalkulatorPetegWhile : IKalkulatorPoteg
    {
        public double ObliczPotege(double podstawa, int wykladnik)
        {
            var wynik = 1.0;

            var iterator = 0;
            while (iterator < wykladnik)
            {
                wynik *= podstawa;
                iterator++;
            }

            return wynik;
        }
    }
}
