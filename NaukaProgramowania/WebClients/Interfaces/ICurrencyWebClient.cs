using NaukaProgramowania.Models;
using System;

namespace NaukaProgramowania.WebClients.Interfaces
{
    public interface ICurrencyWebClient
    {
        GoldDto GetLastGoldRate();
        GoldDto[] GetLastGoldRates(int count);
        GoldDto GetGoldRateInSpecificDate(DateTime dateTime);
    }
}
