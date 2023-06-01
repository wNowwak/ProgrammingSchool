using Currency.Logic.Interfaces;
using Currency.Models;
using System.Net.Http.Json;

namespace Currency.Logic.WebClients;

internal class NBPCurrencyWebClient : ICurrencyWebClient
{
    private readonly HttpClient _client = new();

    public NBPCurrencyWebClient(HttpClient client)
    {
        _client = client;
    }

    public CurrencyDto GetCurrencyByCode(string code)
    {
        var result = new CurrencyDto();

        result = _client.GetFromJsonAsync<CurrencyDto>($"exchangerates/rates/a/{code}").Result;

        return result!;
    }
}
