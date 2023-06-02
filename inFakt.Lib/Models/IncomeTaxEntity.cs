using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class IncomeTaxEntity
    {
        [JsonPropertyName("symbol")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? symbol { get; set; }
        [JsonPropertyName("period")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? period { get; set; }
        [JsonPropertyName("period_name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? period_name { get; set; }
        [JsonPropertyName("period_type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? period_type { get; set; }
        [JsonPropertyName("correction_counter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? correction_counter { get; set; }
        [JsonPropertyName("payment_date")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? payment_date { get; set; }
        [JsonPropertyName("period_income_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? period_income_price { get; set; }
        [JsonPropertyName("incremental_income_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? incremental_income_price { get; set; }
        [JsonPropertyName("period_cost_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? period_cost_price { get; set; }
        [JsonPropertyName("incremental_cost_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? incremental_cost_price { get; set; }
        [JsonPropertyName("period_proceeds_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? period_proceeds_price { get; set; }
        [JsonPropertyName("incremental_proceeds_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? incremental_proceeds_price { get; set; }
        [JsonPropertyName("incremental_social_insurance_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? incremental_social_insurance_price { get; set; }
        [JsonPropertyName("incremental_health_insurance_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? incremental_health_insurance_price { get; set; }
        [JsonPropertyName("tax_paid_in_year_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? tax_paid_in_year_price { get; set; }
        [JsonPropertyName("to_pay_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? to_pay_price { get; set; }
        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? status { get; set; }
        [JsonPropertyName("real_pay")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? real_pay { get; set; }
        [JsonPropertyName("tax_office")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? tax_office { get; set; }
        [JsonPropertyName("extensions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Extensions? Extensions { get; set; }
    }
}
