using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class ClientEntity
    {
        public ClientEntity()
        {
        }
        public ClientEntity(string? businessActivityKind = null, string? firstName = null, string? lastName = null, string? street = null, string? streetNumber = null, string? flatNumber = null, string? city = null, string? country = null, string? postalCode = null, string? companyName = null, string? nip = null)
        {
            BusinessActivityKind = businessActivityKind; // private_person, self_employed, other_business
            Nip = nip;
            FirstName = firstName;
            LastName = lastName;
            CompanyName = companyName;
            Street = street;
            StreetNumber = streetNumber;
            FlatNumber = flatNumber;
            City = city;
            Country = country;
            PostalCode = postalCode;
        }

        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? Id { get; set; }
        [JsonPropertyName("company_name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? CompanyName { get; set; }
        [JsonPropertyName("street")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Street { get; set; }
        [JsonPropertyName("street_number")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? StreetNumber { get; set; }
        [JsonPropertyName("flat_number")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? FlatNumber { get; set; }
        [JsonPropertyName("city")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? City { get; set; }
        [JsonPropertyName("country")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Country { get; set; }
        [JsonPropertyName("postal_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? PostalCode { get; set; }
        [JsonPropertyName("nip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Nip { get; set; }
        [JsonPropertyName("phone_number")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? PhoneNumber { get; set; }
        [JsonPropertyName("web_site")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? WebSite { get; set; }
        [JsonPropertyName("email")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Email { get; set; }
        [JsonPropertyName("note")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Note { get; set; }
        [JsonPropertyName("receiver")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Receiver { get; set; }
        [JsonPropertyName("mailing_company_name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? MailingCompanyName { get; set; }
        [JsonPropertyName("mailing_street")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? MailingStreet { get; set; }
        [JsonPropertyName("mailing_city")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? MailingCity { get; set; }
        [JsonPropertyName("mailing_postal_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? MailingPostalCode { get; set; }
        [JsonPropertyName("days_to_payment")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? DaysToPayment { get; set; }
        [JsonPropertyName("payment_method")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? PaymentMethod { get; set; }
        [JsonPropertyName("invoice_note")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? InvoiceNote { get; set; }
        [JsonPropertyName("same_forward_address")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool SameForwardAddress { get; set; }
        [JsonPropertyName("first_name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? FirstName { get; set; }
        [JsonPropertyName("last_name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? LastName { get; set; }
        [JsonPropertyName("business_activity_kind")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? BusinessActivityKind { get; set; }
    }
}
