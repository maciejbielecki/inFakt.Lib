using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class Pragma
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("active")]
        public bool? Active { get; set; }
    }
}
