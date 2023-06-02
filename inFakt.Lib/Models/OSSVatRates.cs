using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class OSSVatRates
    {
        [JsonPropertyName("metainfo")]
        public MetaInfo MetaInfo { get; set; }

        [JsonPropertyName("entities")]
        public VatOSSEntity[] Entities { get; set; }
    }
}
