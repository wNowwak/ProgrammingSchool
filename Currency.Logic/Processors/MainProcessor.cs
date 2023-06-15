using Currency.Logic.Extensions;
using Currency.Logic.Interfaces;
using Currency.Models;
using System.Globalization;

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
        Console.WriteLine("Pobierz aktualny kurs waluty - 1 \n" +
            "Pobierz kilka kursów waluty - 2 \n" +
            "Pobierz kurs w konkretnym dniu - 3 \n" +
            "Średnia ostatnich 10 notowań - 4 \n" +
            "Najwyższe notowanie z ostatnich 10 - 5 \n");
        var option = Console.ReadLine();
        Console.WriteLine("Jaką walutę pobrać?");
        var currencyCode = Console.ReadLine()!;
        var currency = new CurrencyDto();
        switch (option)
        {
            case "1":
                currency = _currencyWebClient.GetCurrencyByCode(currencyCode);
                currency!.Display();
                break;
            case "2":
                Console.WriteLine("Ile kursów pobrać?");
                var count = int.Parse(Console.ReadLine()!);
                currency = _currencyWebClient.GetLastCurrencyRateByCode(currencyCode, count);
                currency!.Display();
                break;
            case "3":
                Console.WriteLine("Podaj datę w formacie DD-MM-YYYY");
                var data = Console.ReadLine();
                currency = _currencyWebClient.GetCurrencyRateInSpecificDate(currencyCode, DateTime.ParseExact(data!, "dd-MM-yyyy",
                    CultureInfo.InvariantCulture));
                currency!.Display();
                break;
            case "4": //Piotrek
                //Średnia ostatnich 10 notowań
                currency = _currencyWebClient.GetLastCurrencyRateByCode(currencyCode, 10);
                //var sumanotowan = 0.0m;
                //foreach (var rates in currency.Rates)
                //{
                //    sumanotowan += rates.Mid;
                //}
                //var srednia = sumanotowan / currency.Rates.Count;
                var srednia2 = currency!.Rates.Average(rate => rate.Mid);
                break;
            case "5": //Marcin
                currency = _currencyWebClient.GetLastCurrencyRateByCode(currencyCode, 10);
                var currencyHighestRate = currency!.Rates.Select(_ => _.Mid).ToList();
                decimal max = currencyHighestRate.Max();
                break;
            default:
                break;

        }

        Console.ReadLine();
    }
}
