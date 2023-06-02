using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class CountryEntity
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }
        [JsonPropertyName("alpha_2")]
        public string? Alpha2 { get; set; }
        [JsonPropertyName("alpha_3")]
        public string? Alpha3 { get; set; }
        [JsonPropertyName("english_name")]
        public string? EnglishName { get; set; }
        [JsonPropertyName("polish_name")]
        public string? PolishName { get; set; }
        [JsonPropertyName("continent")]
        public string? Continent { get; set; }
        [JsonPropertyName("european_union")]
        public bool? EuropeanUnion { get; set; }
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
    }
}
