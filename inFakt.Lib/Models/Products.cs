using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class Products
    {

        [JsonPropertyName("metainfo")]
        public MetaInfo MetaInfo { get; set; }

        [JsonPropertyName("entities")]
        public ProductEntity[] Entities { get; set; }
    }
}
