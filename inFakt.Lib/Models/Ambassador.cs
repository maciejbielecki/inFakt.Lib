using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class Ambassador
    {
        [JsonPropertyName("active")]
        public bool Active { get; set; }
        [JsonPropertyName("details")]
        public Details Details { get; set; }
    }

    public class Details
    {
        [JsonPropertyName("link")]
        public string? Link { get; set; }
    }
}
