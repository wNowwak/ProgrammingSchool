using NaukaProgramowania.Pojazdy;

namespace NaukaProgramowania.KalkulatorTemperatury
{
    public class KalkulatorOgolny : IKalkulator
    {
        private readonly IKalkulatorPoteg _kalkulatorPoteg;
        private readonly IKalkulatorMnozenia _kalkulatorMnozenia;

        public KalkulatorOgolny(IKalkulatorPoteg kalkulatorPoteg, IKalkulatorMnozenia kalkulatorMnozenia)
        {
            _kalkulatorPoteg = kalkulatorPoteg;
            _kalkulatorMnozenia = kalkulatorMnozenia;
        }

        public double ObliczPotege(double podstawa, int wykladnik)
        {
            return _kalkulatorPoteg.ObliczPotege(podstawa, wykladnik);
        }

        public double Pomnoz(double x, double y)
        {
            return _kalkulatorMnozenia.PomnozLiczbe(x, y);
        }
    }
}
