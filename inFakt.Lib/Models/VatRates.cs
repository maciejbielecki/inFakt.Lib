using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class VatRates
    {
        [JsonPropertyName("metainfo")]
        public MetaInfo MetaInfo { get; set; }

        [JsonPropertyName("entities")]
        public VatEntity[] Entities { get; set; }
    }
}
