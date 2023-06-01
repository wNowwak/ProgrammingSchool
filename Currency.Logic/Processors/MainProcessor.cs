using Currency.Logic.Interfaces;

namespace Currency.Logic.Processors;

public class MainProcessor
{
    private readonly ICurrencyWebClient _currencyWebClient = default!;

    public MainProcessor(ICurrencyWebClient currencyWebClient)
    {
        _currencyWebClient = currencyWebClient;
    }

    public void Process()
    {
        _currencyWebClient.GetCurrencyByCode("USD");
    }
}
