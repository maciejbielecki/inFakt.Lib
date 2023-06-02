using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class Service
    {
        public Service()
        {
        }

        public Service(string? name = null, int netPrice = 0, int taxPrice = 0, int grossPrice = 0, int quantity = 1)
        {
            Name = name;
            NetPrice = netPrice;
            TaxPrice = taxPrice;
            GrossPrice = grossPrice;
            Quantity = quantity;
        }

        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Name { get; set; }
        [JsonPropertyName("tax_symbol")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? TaxSymbol { get; set; } = "23";
        [JsonPropertyName("quantity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? Quantity { get; set; }
        [JsonPropertyName("unit_net_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? InitNetPrice { get; set; }
        [JsonPropertyName("net_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? NetPrice { get; set; }
        [JsonPropertyName("gross_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? GrossPrice { get; set; }
        [JsonPropertyName("tax_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? TaxPrice { get; set; }
        [JsonPropertyName("symbol")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Symbol { get; set; }
        [JsonPropertyName("pkwiu")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Pkwiu { get; set; }
        [JsonPropertyName("cn")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Cn { get; set; }
        [JsonPropertyName("pkob")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Pkob { get; set; }
        [JsonPropertyName("discount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Discount { get; set; }
        [JsonPropertyName("unit_net_price_before_discount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? UnitNetPriceBeforeDiscount { get; set; }
        [JsonPropertyName("gtu_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? GtuId { get; set; }
    }
}
