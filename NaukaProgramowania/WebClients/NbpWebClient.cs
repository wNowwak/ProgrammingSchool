using NaukaProgramowania.Models;
using NaukaProgramowania.WebClients.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace NaukaProgramowania.WebClients
{
    internal class NbpWebClient : ICurrencyWebClient
    {
        private WebClient _client;
        private const string _baseUrl = "http://api.nbp.pl/api/";
        private const string _dateFormat = "yyyy-MM-dd";

        public NbpWebClient()
        {
            _client = new WebClient();
            _client.BaseAddress = _baseUrl;
            _client.Headers.Add("Accept", "application/json");
        }

        public GoldDto GetLastGoldRate()
        {
            var result = new GoldDto();

            using (_client)
            {
                var response = _client.DownloadString("cenyzlota");

                result = JsonConvert.DeserializeObject<GoldDto[]>(response).First();
            }
            return result;
        }

        public GoldDto[] GetLastGoldRates(int count)
        {
            var result = new GoldDto[count];

            using (_client)
            {
                var response = _client.DownloadString($"cenyzlota/last/{count}");

                result = JsonConvert.DeserializeObject<GoldDto[]>(response);
            }
            return result;
        }

        public GoldDto GetGoldRateInSpecificDate(DateTime dateTime)
        {
            var result = new GoldDto();
            
            using (_client)
            {
                try
                {
                    var response = _client.DownloadString($"cenyzlota/{dateTime.ToString(_dateFormat)}");

                    result = JsonConvert.DeserializeObject<GoldDto[]>(response).First();
                    Console.WriteLine($"Notowanie w dniu {result.Data.ToString(_dateFormat)}: {result.Cena}");
                }
                catch (WebException)
                {
                    Console.WriteLine($"Brak notowania w dniu: {dateTime.ToString(_dateFormat)}");
                }
            }

            return result;
        }
    }
}
