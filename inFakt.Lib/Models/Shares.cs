using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class Shares
    {
        [JsonPropertyName("link")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Link { get; set; }
        [JsonPropertyName("available")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Available { get; set; }
        [JsonPropertyName("valid_until")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ValidUntil { get; set; }
    }
}
