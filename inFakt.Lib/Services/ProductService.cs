using inFakt.Lib.Models;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace inFakt.Lib.Services
{
    public interface IProductService
    {
        Task<(Products? data, string error)> Get();
        Task<(ProductEntity? data, string error)> Get(int id);
        Task<(ClientEntity? data, string error)> Create(string? name = null, int quantity = 1, int netPrice = 0, int taxPrice = 0, int grossPrice = 0);
        Task<(ClientEntity? data, string error)> Create(ProductEntity product);
        Task<(ProductEntity? data, string error)> Update(int id, ProductEntity product);
        Task<(string? data, string error)> Delete(int id);
    }

    public class ProductService : IProductService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public ProductService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<(Products? data, string error)> Get()
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, InFaktUrls.GetProducts);

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<Products>(), string.Empty);
                }
                else
                {
                    return (null, await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }

        public async Task<(ClientEntity? data, string error)> Create(string? name = null, int quantity = 1, int netPrice = 0, int taxPrice = 0, int grossPrice = 0)
        {
            return await CreateProduct(new(name, quantity, netPrice, taxPrice, grossPrice));
        }

        public async Task<(ClientEntity? data, string error)> Create(ProductEntity product)
        {
            return await CreateProduct(product);
        }

        private async Task<(ClientEntity? data, string error)> CreateProduct(ProductEntity product)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, InFaktUrls.PostProduct);
            request.Content = new StringContent(JsonSerializer.Serialize(new ProductPost(product)), Encoding.UTF8, "application/json");
            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<ClientEntity>(), string.Empty);
                }
                else
                {
                    return (null, await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }

        public async Task<(ProductEntity? data, string error)> Get(int id)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, string.Format(InFaktUrls.GetProductById, id));

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<ProductEntity>(), string.Empty);
                }
                else
                {
                    return (null, await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }

        public async Task<(ProductEntity? data, string error)> Update(int id, ProductEntity product)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, string.Format(InFaktUrls.PutProduct, id));
            request.Content = new StringContent(JsonSerializer.Serialize(new ProductPost(product)), Encoding.UTF8, "application/json");

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<ProductEntity>(), string.Empty);
                }
                else
                {
                    return (null, await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }

        public async Task<(string? data, string error)> Delete(int id)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, string.Format(InFaktUrls.DeleteProduct, id));

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadAsStringAsync(), string.Empty);
                }
                else
                {
                    return (null, await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }
    }
}
