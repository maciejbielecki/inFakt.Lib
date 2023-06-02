using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class GetInvoicePdf
    {
        public GetInvoicePdf(string? documentType = "original", string locale = "en")
        {
            DocumentType = documentType;
            Locale = locale;
        }

        [JsonPropertyName("document_type")]
        public string? DocumentType { get; set; }
        [JsonPropertyName("locale")]
        public string? Locale { get; set; } = "pl";
    }
}
