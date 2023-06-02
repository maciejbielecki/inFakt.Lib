using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class Countries
    {
        [JsonPropertyName("metainfo")]
        public MetaInfo MetaInfo { get; set; }

        [JsonPropertyName("entities")]
        public CountryEntity[] Entities { get; set; }
    }
}
