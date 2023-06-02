using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class Vats
    {
        [JsonPropertyName("metainfo")]
        public MetaInfo MetaInfo { get; set; }

        [JsonPropertyName("entities")]
        public VatEntity[] Entities { get; set; }
    }
}
