using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class ResponseMessage
    {
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
