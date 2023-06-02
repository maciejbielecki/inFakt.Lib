using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class BankAccounts
    {
        [JsonPropertyName("metainfo")]
        public MetaInfo MetaInfo { get; set; }

        [JsonPropertyName("entities")]
        public BankAccountEntity[] Entities { get; set; }
    }
}
