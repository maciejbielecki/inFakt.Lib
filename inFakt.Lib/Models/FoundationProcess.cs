using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class FoundationProcess
    {

        [JsonPropertyName("in_progress")]
        public bool InPrograss { get; set; }

        [JsonPropertyName("completed")]
        public bool Completed { get; set; }
    }
}
