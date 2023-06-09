using Currency.Logic.Interfaces;
using Currency.Models;
using System.Net.Http.Json;

namespace Currency.Logic.WebClients;

internal class NBPCurrencyWebClient : ICurrencyWebClient
{
    private readonly HttpClient _client = new();
    private const string _dateFormat = "yyyy-MM-dd";

    public NBPCurrencyWebClient(HttpClient client)
    {
        _client = client;
    }

    public CurrencyDto? GetCurrencyByCode(string code)
    {
        var result = new CurrencyDto();

        result = _client.GetFromJsonAsync<CurrencyDto>($"exchangerates/rates/a/{code}").Result;

        return result!;
    }

    public CurrencyDto? GetCurrencyRateInSpecificDate(string code, DateTime date)
    {
        try
        {
            var result = _client.GetFromJsonAsync<CurrencyDto>($"exchangerates/rates/a/{code}/{date.ToString(_dateFormat)}").Result;
            return result!;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd podczas pobierania danych." +
                $"Błąd: {ex}");
            return null;
        }
    }

    public CurrencyDto? GetLastCurrencyRateByCode(string code, int count)
    {
        try
        {
            var result = _client.GetFromJsonAsync<CurrencyDto>($"exchangerates/rates/a/{code}/last/{count}").Result;
            return result!;
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd podczas pobierania danych." +
                $"Błąd: {ex}");
            return null;
        }
    }
}
