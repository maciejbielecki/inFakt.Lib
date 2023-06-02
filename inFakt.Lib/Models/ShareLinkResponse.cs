using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class ShareLinkResponse
    {
        [JsonPropertyName("share_link")]
        public string? ShareLink { get; set; }
        [JsonPropertyName("expiration_date")]
        public DateTime? ExpirationDate { get; set; }
    }
}
