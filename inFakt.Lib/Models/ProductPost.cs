using System.Text.Json.Serialization;

namespace inFakt.Lib.Models
{
    public class ProductPost
    {
        public ProductPost()
        {

        }

        public ProductPost(ProductEntity product)
        {
            Product = product;
        }

        [JsonPropertyName("product")]
        public ProductEntity Product { get; set; }
    }
}
