using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class ZUSEntity
    {
        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [JsonPropertyName("period_name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? PeriodName { get; set; }

        [JsonPropertyName("payment_date")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime PaymentDate { get; set; }

        [JsonPropertyName("social_amount_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int SocialAmountPrice { get; set; }

        [JsonPropertyName("health_amount_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int HealthAmountPrice { get; set; }

        [JsonPropertyName("work_amount_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int WorkAmountPrice { get; set; }

        [JsonPropertyName("social_amount_paid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int SocialAmountPaid { get; set; }

        [JsonPropertyName("health_amount_paid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int HealthAmountPaid { get; set; }
        [JsonPropertyName("work_amount_paid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int WorkAmountPaid { get; set; }
        [JsonPropertyName("sum_amount_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int SumAmountPrice { get; set; }
        [JsonPropertyName("show_payment_option")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool ShowPaymentOption { get; set; }
        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Status { get; set; }
    }
}
