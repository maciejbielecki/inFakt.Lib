using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class BankAccountEntity
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("bank_name")]
        public string? BankName { get; set; }

        [JsonPropertyName("custom_name")]
        public string? CustomName { get; set; }

        [JsonPropertyName("account_number")]
        public string? AccountNumber { get; set; }

        [JsonPropertyName("swift")]
        public string? Swift { get; set; }

        [JsonPropertyName("default")]
        public bool? Default { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
    }
}
