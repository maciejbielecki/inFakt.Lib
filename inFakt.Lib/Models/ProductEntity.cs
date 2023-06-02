using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class ProductEntity
    {
        public ProductEntity()
        {

        }

        public ProductEntity(string? name = null, double quantity = 1.0, int netPrice = 0, int taxPrice = 0, int grossPrice = 0)
        {
            Name = name;
            Quantity = quantity;
            NetPrice = netPrice;
            TaxPrice = taxPrice;
            GrossPrice = grossPrice;
        }

        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? Id { get; set; }
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Name { get; set; }
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
        [JsonPropertyName("unit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Unit { get; set; }
        [JsonPropertyName("tax_symbol")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? TaxSymbol { get; set; } = "23";
        [JsonPropertyName("flat_rate_tax_symbol")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? FlatRateTaxSymbol { get; set; }
        [JsonPropertyName("quantity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double Quantity { get; set; }
        [JsonPropertyName("net_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int NetPrice { get; set; }
        [JsonPropertyName("tax_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int TaxPrice { get; set; }
        [JsonPropertyName("gross_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int GrossPrice { get; set; }
        [JsonPropertyName("unit_net_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int UnitNetPrice { get; set; }
        [JsonPropertyName("purchase_unit_net_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int PurchaseUnitNetPrice { get; set; }
        [JsonPropertyName("purchase_unit_gross_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int PurchaseUnitGrossPrice { get; set; }
        [JsonPropertyName("discount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Discount { get; set; }
        [JsonPropertyName("unit_net_price_before_discount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int UnitNetPriceBeforeDiscount { get; set; }
        [JsonPropertyName("gtu_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? GtuId { get; set; }
    }
}
