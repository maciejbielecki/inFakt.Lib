using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class CurrentSubscription
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("expired_on")]
        public DateTime ExpiredOn { get; set; }
        [JsonPropertyName("days_until_expiration")]
        public int DaysUntilExpiration { get; set; }
        [JsonPropertyName("user_type_symbol")]
        public string? UserTypeSymbol { get; set; }
    }
}
