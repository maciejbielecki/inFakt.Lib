using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class Clients
    {
        [JsonPropertyName("metainfo")]
        public MetaInfo MetaInfo { get; set; }

        [JsonPropertyName("entities")]
        public ClientEntity[] Entities { get; set; }
    }
}
