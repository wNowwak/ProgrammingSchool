using Currency.Logic.Interfaces;
using Currency.Logic.Processors;
using Currency.Logic.WebClients;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;

namespace Currency.Logic.Extensions;

public static class DependencyInjectionExtensions
{
    public static void AddDependencies(this IServiceCollection services)
    {
        services.AddSingleton<MainProcessor>();
        //services.AddTransient<ICurrencyWebClient, NBPCurrencyWebClient>();
        services.AddHttpClient<ICurrencyWebClient, NBPCurrencyWebClient>(client =>
        {
            client.BaseAddress = new Uri("http://api.nbp.pl/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        });

    }
}
