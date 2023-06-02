using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class AccountData
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("uuid")]
        public string? Uuid { get; set; }
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        [JsonPropertyName("site")]
        public string? Site { get; set; }
        [JsonPropertyName("role")]
        public string? Role { get; set; }

    }
}
