using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class ClientPost
    {
        public ClientPost()
        {
        }

        public ClientPost(ClientEntity client)
        {
            Client = client;
        }

        [JsonPropertyName("client")]
        public ClientEntity Client { get; set; }
    }
}
