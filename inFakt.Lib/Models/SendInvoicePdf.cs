using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class SendInvoicePdf
    {
        #region print_type
        //- original – Orginał
        //- copy – Kopia
        //- original_duplicate – Duplikat orginału
        //- copy_duplicate – Duplikat kopii
        //- duplicate – Duplikat
        //- regular – Bez adnotacji
        #endregion
        [JsonPropertyName("print_type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? PrintType { get; set; } = "original";
        [JsonPropertyName("locale")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Locale { get; set; } = "pl";
        [JsonPropertyName("recipient")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Recipient { get; set; }
        [JsonPropertyName("send_copy")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool SendCopy { get; set; }
    }
}
