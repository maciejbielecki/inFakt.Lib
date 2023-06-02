using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class Payments
    {
        [JsonPropertyName("link")]
        public string? Link { get; set; }
        [JsonPropertyName("available")]
        public bool Available { get; set; }
    }
}
