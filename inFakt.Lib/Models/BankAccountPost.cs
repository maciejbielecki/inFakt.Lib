using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class BankAccountPost
    {
        public BankAccountPost()
        {            
        }

        public BankAccountPost(BankAccountEntity bankAccount)
        {
            BankAccount = bankAccount;
        }

        [JsonPropertyName("bank_account")]
        public BankAccountEntity BankAccount { get; set; }
    }
}
