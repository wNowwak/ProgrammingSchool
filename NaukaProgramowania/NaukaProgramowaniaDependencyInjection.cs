using NaukaProgramowania.KalkulatorTemperatury;
using NaukaProgramowania.Pojazdy;
using Ninject.Modules;

namespace NaukaProgramowania
{
    public class NaukaProgramowaniaDependencyInjection : NinjectModule
    {
        public override void Load()
        {
            Bind<IKalkulatorPoteg>().To<KalkulatorPotegReukrencyjny>();
            Bind<IKalkulatorMnozenia>().To<KalkulatoMnozenia>();
            Bind<IKalkulator>().To<KalkulatorOgolny>();
        }
    }
}
