using System.Text.Json.Serialization;

namespace Core.DTO.JsonModels
{
    public class RateItem
    {
        [JsonPropertyName("exchangedate")]
        public string Date { get; set; }
        [JsonPropertyName("rate")]
        public double Rate_UAH { get; set; }
    }
}
