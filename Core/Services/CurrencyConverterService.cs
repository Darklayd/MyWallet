using Core.DTO.JsonModels;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.Services
{
    public class CurrencyConverterService
    {
        private readonly HttpClient _client;

        public CurrencyConverterService()
        {
            _client = new HttpClient();
        }

        public async Task<double> CurrencyConverter(CurrencyConverterModel currencyConverter)
        {
            
            var fromRateData = await _client
                .GetStringAsync(
                    $"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode={currencyConverter.FromMoneyType.ToUpper()}&date={DateTime.UtcNow.ToString("yyyy.MM.dd").Replace(".", "")}&json");
            var toRateData = await _client
                .GetStringAsync(
                    $"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode={currencyConverter.ToMoneyType.ToUpper()}&date={DateTime.UtcNow.ToString("yyyy.MM.dd").Replace(".", "")}&json");

            JsonCurrency fromRateInfo;
            JsonCurrency toRateInfo;

            //перевіряєм чи відповідає тип гривні
            if (currencyConverter.FromMoneyType == "UAH")
            {
                fromRateInfo = new JsonCurrency()
                    {
                        Rate = 1, 
                        ExchangeDate = DateTime.UtcNow.ToString("dd.MM.yyyy"), 
                        NameMoney = "UAH"
                    };
            }
            else
            {
                fromRateInfo = JsonSerializer.Deserialize<List<JsonCurrency>>(fromRateData)[0];
            }
            
            if (currencyConverter.ToMoneyType == "UAH")
            {
                toRateInfo = new JsonCurrency()
                {
                    Rate = 1,
                    ExchangeDate = DateTime.UtcNow.ToString("dd.MM.yyyy"),
                    NameMoney = "UAH"
                };
            }
            else
            {
                toRateInfo = JsonSerializer.Deserialize<List<JsonCurrency>>(toRateData)[0];
            }

                // If currency's are empty abort
            if (currencyConverter.FromMoneyType == null || currencyConverter.ToMoneyType == null)
                return 0;

            // Convert UAH to UAH
            if (currencyConverter.FromMoneyType == "UAH" && currencyConverter.ToMoneyType == "UAH")
                return currencyConverter.Amount;

            try
            {
                // First Get the exchange rate of both currencies in euro
                double toRate = Double.Parse(toRateInfo.Rate.ToString());
                double fromRate = Double.Parse(fromRateInfo.Rate.ToString());


                // Convert Between UAH to Other Currency
                if (currencyConverter.FromMoneyType == "UAH")
                {
                    return (currencyConverter.Amount * toRate);
                }
                else if (currencyConverter.ToMoneyType == "UAH")
                {
                    return (currencyConverter.Amount / fromRate);
                }
                else
                {
                    // Calculate non UAH exchange rates From A to B
                    return (currencyConverter.Amount * toRate) / fromRate;
                }
            }
            catch { return 0; }
        }
    }
}
