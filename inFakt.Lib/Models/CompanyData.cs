using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{

    public class CompanyData
    {
        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }
        [JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }
        [JsonPropertyName("owner_name")]
        public string? OwnerName { get; set; }
        [JsonPropertyName("owner_surname")]
        public string? OwnerSurname { get; set; }
        [JsonPropertyName("street")]
        public string? Street { get; set; }
        [JsonPropertyName("street_name")]
        public string? StreetName { get; set; }
        [JsonPropertyName("street_number")]
        public string? StreetNumber { get; set; }
        [JsonPropertyName("flat_number")]
        public string? FlatNUmber { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
        [JsonPropertyName("postal_code")]
        public string? PostalCode { get; set; }
        [JsonPropertyName("tax_id")]
        public string? TaxId { get; set; }
        [JsonPropertyName("pesel")]
        public string? Pesel { get; set; }
        [JsonPropertyName("regon")]
        public string? Regon { get; set; }
        [JsonPropertyName("phone_number")]
        public string? PhoneNUmber { get; set; }
        [JsonPropertyName("mailing_company_name")]
        public string? MailingCompanyName { get; set; }
        [JsonPropertyName("mailing_street")]
        public string? MailingStreet { get; set; }
        [JsonPropertyName("mailing_city")]
        public string? MailingCity { get; set; }
        [JsonPropertyName("mailing_postal_code")]
        public string? MailingPostalCode { get; set; }
        [JsonPropertyName("business_activity_code")]
        public string? BusinessActivityCode { get; set; }
    }
}
