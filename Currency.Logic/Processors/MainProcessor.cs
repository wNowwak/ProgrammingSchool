using Currency.Logic.Extensions;
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
        Console.WriteLine("Pobierz aktualny kurs waluty - 1" +
            "Pobierz kilka kursów waluty - 2" +
            "Pobierz kurs w konkretnym dniu - 3");
        var option = Console.ReadLine();
        Console.WriteLine("Jaką walutę pobrać?");
        var currency = Console.ReadLine()!;
        switch (option)
        {
            case "1":
                _currencyWebClient.GetCurrencyByCode(currency).Display();
                break;
            case "2":
                Console.WriteLine("Ile kursów pobrać?");
                var count = int.Parse(Console.ReadLine()!);
                _currencyWebClient.GetLastCurrencyRateByCode(currency, count).Display();
                break;
            case "3":
                var data = 
                _currencyWebClient.GetCurrencyRateInSpecificDate(currency);
                break;
            default:
                break;
        }
        Console.ReadLine();
    }
}
