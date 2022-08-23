using System.Text.Json.Serialization;

namespace Core.DTO.JsonModels
{
    public class JsonTypeMoneyData
    {
        [JsonPropertyName("txt")]
        public string FullName { get; set; }
        [JsonPropertyName("cc")]
        public string Name { get; set; }
    }
}
