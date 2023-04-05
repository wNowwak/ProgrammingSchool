namespace NaukaProgramowania.KalkulatorTemperatury
{
    public class KalkulatorPetegFor : IKalkulatorPoteg
    {
        public double ObliczPotege(double podstawa, int wykladnik)
        {
            var wynik = 1.0;

            for (int i = 0; i < wykladnik; i++)
            {
                wynik *= podstawa;
            }

            return wynik;
        }
    }
}
