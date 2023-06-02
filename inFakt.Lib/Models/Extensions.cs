using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class Extensions
    {
        [JsonPropertyName("ambassador")]
        public Ambassador? Ambassador { get; set; }
        [JsonPropertyName("ksef")]
        public Ksef? Ksef { get; set; }
        [JsonPropertyName("pragma")]
        public Pragma? Pragma { get; set; }
        [JsonPropertyName("payments")]
        public Payments? Payments { get; set; }
        [JsonPropertyName("shares")]
        public Shares? Shares { get; set; }
    }
}
