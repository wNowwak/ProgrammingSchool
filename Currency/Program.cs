using Currency;
using Currency.Logic.Extensions;
using Currency.Logic.Interfaces;
using Currency.Logic.Processors;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddDependencies();

        var provider = services.BuildServiceProvider();
        var processor = provider.GetService<MainProcessor>();

       processor!.Process();
    }
}