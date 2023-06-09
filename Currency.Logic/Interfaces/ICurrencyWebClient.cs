using Currency.Models;

namespace Currency.Logic.Interfaces;

public interface ICurrencyWebClient
{
    CurrencyDto? GetCurrencyByCode(string code);
    CurrencyDto? GetLastCurrencyRateByCode(string code, int count);
    CurrencyDto? GetCurrencyRateInSpecificDate(string code, DateTime date);
}
