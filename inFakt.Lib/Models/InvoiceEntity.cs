using System.Text.Json.Serialization;
using System.Threading;

namespace inFakt.Lib.Models
{
    public class InvoiceEntity
    {
        public InvoiceEntity()
        {
            
        }
        public InvoiceEntity(string? clientCompanyName = null, string? clientFirstName = null, string? clientLastName = null, string paymentMethod = "payu", Service[]? services = null)
        {
            ClientCompanyName = clientCompanyName;
            ClientFirstName = clientFirstName;
            ClientLastName = clientLastName;
            PaymentMethod = paymentMethod; //transfer,cash,card,barter,check,bill_of_sale,delivery,compensation,accredited,paypal,instalment_sale,payu,tpay,przelewy24,dotpay,other
            Services = services ?? new Service[] { };
        }

        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? Id { get; set; }

        [JsonPropertyName("uuid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Uuid { get; set; }
        [JsonPropertyName("number")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Number { get; set; }
        [JsonPropertyName("currency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Currency { get; set; }
        [JsonPropertyName("paid_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int PaidPrice { get; set; }
        [JsonPropertyName("notes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Notes { get; set; }
        [JsonPropertyName("kind")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Kind { get; set; }
        [JsonPropertyName("payment_method")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? PaymentMethod { get; set; }
        [JsonPropertyName("split_payment")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool SplitPayment { get; set; }
        [JsonPropertyName("split_payment_type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? SplitPaymentType { get; set; }
        [JsonPropertyName("recipient_signature")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? RecipientSignature { get; set; }
        [JsonPropertyName("seller_signature")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? SellerSignature { get; set; }
        [JsonPropertyName("invoice_date")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime? InvoiceDate { get; set; }
        [JsonPropertyName("sale_date")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime? SaleDate { get; set; }
        [JsonPropertyName("continuous_service_start_on")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ContinuousServiceStartOn { get; set; }
        [JsonPropertyName("continuous_service_end_on")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ContinuousServiceEndOn { get; set; }
        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Status { get; set; }
        [JsonPropertyName("payment_date")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime? PaymentDate { get; set; }
        [JsonPropertyName("paid_date")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime? PaidDate { get; set; }
        [JsonPropertyName("net_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int NetPrice { get; set; }
        [JsonPropertyName("tax_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int TaxPrice { get; set; }
        [JsonPropertyName("gross_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int GrossPrice { get; set; }
        [JsonPropertyName("left_to_pay")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int LeftToPay { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("client_id")]
        public int ClientId { get; set; }
        [JsonPropertyName("client_company_name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ClientCompanyName { get; set; }
        [JsonPropertyName("client_first_name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ClientFirstName { get; set; }
        [JsonPropertyName("client_last_name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ClientLastName { get; set; }
        [JsonPropertyName("client_business_activity_kind")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ClientBusinessActivityKind { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("client_street")]
        public string? ClientStreet { get; set; }
        [JsonPropertyName("client_street_number")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ClientStreetNumber { get; set; }
        [JsonPropertyName("client_flat_number")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ClientFlatNumber { get; set; }
        [JsonPropertyName("client_city")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ClientCity { get; set; }
        [JsonPropertyName("client_post_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ClientPostCode { get; set; }
        [JsonPropertyName("client_tax_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ClientTaxCode { get; set; }
        [JsonPropertyName("client_country")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ClientCountry { get; set; }
        [JsonPropertyName("bank_account")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? BankAccount { get; set; }
        [JsonPropertyName("bank_name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? BankName { get; set; }
        [JsonPropertyName("swift")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Swift { get; set; }
        [JsonPropertyName("vat_exemption_reason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? VatExemptionReason { get; set; }
        [JsonPropertyName("sale_type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? SaleType { get; set; }
        [JsonPropertyName("invoice_date_kind")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? InvoiceDateKind { get; set; }
        [JsonPropertyName("document_markings_ids")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int[] DocumentMarkingsIds { get; set; } = new int[] { };
        [JsonPropertyName("transaction_kind_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? TransactionKindId { get; set; }
        [JsonPropertyName("bdo_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? BdoCode { get; set; }
        [JsonPropertyName("receipt_number")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ReceiptNumber { get; set; }
        [JsonPropertyName("not_income")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool NotIncome { get; set; }
        [JsonPropertyName("vat_exchange_date_kind")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? VatExchangeDateKind { get; set; }
        [JsonPropertyName("services")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Service[] Services { get; set; }
        [JsonPropertyName("extensions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Extensions Extensions { get; set; }
    }
}
