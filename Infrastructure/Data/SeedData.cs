using Core.DTO.JsonModels;
using Core.Entities.TypesMoney;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public static class SeedData
    {
        private static readonly HttpClient _client = new HttpClient();

        public static async Task Seed(this ModelBuilder builder)
        {
            await SeedTypeMoney(builder);
        }

        public static async Task SeedTypeMoney(ModelBuilder builder)
        {
            var data = await _client.GetStringAsync("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json");
            var list = JsonSerializer.Deserialize<List<JsonTypeMoneyData>>(data);
            var typeMoneyData = new TypeMoney[list.Count + 1];
            typeMoneyData[0] = new TypeMoney() {Id = 1, FullName = "Гривня", Name = "UAH"};

            for (int i = 1; i < list.Count + 1; i++)
            {
                typeMoneyData[i] = new TypeMoney()
                {
                    Id = i + 1,
                    FullName = list[i - 1].FullName,
                    Name = list[i - 1].Name
                };
            }

            builder.Entity<TypeMoney>().HasData(typeMoneyData);
        }
    }
}

