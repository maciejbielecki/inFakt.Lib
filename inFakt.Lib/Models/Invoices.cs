using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class Invoices
    {

        [JsonPropertyName("metainfo")]
        public MetaInfo MetaInfo { get; set; }

        [JsonPropertyName("entities")]
        public InvoiceEntity[] Entities { get; set; }
    }
}
