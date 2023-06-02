using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class InsuranceFees
    {
        [JsonPropertyName("metainfo")]
        public MetaInfo MetaInfo { get; set; }

        [JsonPropertyName("entities")]
        public ZUSEntity[] Entities { get; set; }
    }
}
