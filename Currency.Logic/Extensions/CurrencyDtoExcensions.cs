using Currency.Models;

namespace Currency.Logic.Extensions;

public static class CurrencyDtoExcensions
{
    public static void Display(this CurrencyDto currency)
    {
        var rates = string.Join(", \n", currency.Rates
            .Select(_ => $"Data: {_.EffectiveDate.ToString("dd-MM-yyyy")} cena: {_.Mid}"));
        Console.WriteLine($"Waluta: {currency.Code} - kursy {rates}");
    }
}
