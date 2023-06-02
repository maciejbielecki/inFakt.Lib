using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class UserData
    {
        [JsonPropertyName("account_data")]
        public AccountData AccountData { get; set; }

        [JsonPropertyName("company_data")]
        public CompanyData CompanyData { get; set; }

        [JsonPropertyName("current_subscription")]
        public CurrentSubscription CurrentSubscription { get; set; }

        [JsonPropertyName("accounting_settings")]
        public AccountingSettings AccountingSettings { get; set; }
        [JsonPropertyName("foundation_process")]
        public FoundationProcess FoundationProcess { get; set; }

        [JsonPropertyName("extentions")]
        public Extensions Extensions { get; set; }

    }
}
