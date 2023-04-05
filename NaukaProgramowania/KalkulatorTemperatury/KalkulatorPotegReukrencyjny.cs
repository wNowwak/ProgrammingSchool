namespace NaukaProgramowania.KalkulatorTemperatury
{
    public class KalkulatorPotegReukrencyjny : IKalkulatorPoteg
    {
        public double ObliczPotege(double podstawa, int wykladnik)
        {
            if (wykladnik == 1)
            {
                return podstawa;
            }
            var x = ObliczPotege(podstawa, wykladnik - 1);
            return podstawa * x;
        }
    }
}
