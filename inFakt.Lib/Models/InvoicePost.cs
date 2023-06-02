using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class InvoicePost
    {
        public InvoicePost()
        {

        }

        public InvoicePost(InvoiceEntity invoice)
        {
            Invoice = invoice;
        }

        [JsonPropertyName("invoice")]
        public InvoiceEntity Invoice { get; set; }
    }
}
