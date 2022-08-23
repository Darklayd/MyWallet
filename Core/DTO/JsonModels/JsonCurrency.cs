using System.Text.Json.Serialization;

namespace Core.DTO.JsonModels
{
    public class JsonCurrency
    {
        [JsonPropertyName("rate")]
        public float Rate { get; set; }
        [JsonPropertyName("cc")]
        public string NameMoney { get; set; }
        [JsonPropertyName("exchangedate")]
        public string ExchangeDate { get; set; }
    }
}
