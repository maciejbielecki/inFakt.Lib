using inFakt.Lib.Models;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace inFakt.Lib.Services
{
    public interface IClientService
    {
        Task<(Clients? data, string error)> Get();
        Task<(ClientEntity? data, string error)> Get(int id);
        Task<(ClientEntity? data, string error)> Create(string? firstName = null, string? lastName = null, string? street = null, string? streetNumber = null, string? flatNumber = null, string? city = null, string? country = null, string? postalCode = null, string? businessActivityKind = "private_person", string? companyName = null, string? nip = null);
        Task<(ClientEntity? data, string error)> Create(ClientEntity client);
        Task<(ClientEntity? data, string error)> Update(int id, ClientEntity client);
        Task<(string? data, string error)> Delete(int id);
    }
    public class ClientService : IClientService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public ClientService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<(Clients? data, string error)> Get()
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, InFaktUrls.GetClients);

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<Clients>(), string.Empty);
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

        public async Task<(ClientEntity? data, string error)> Get(int id)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, string.Format(InFaktUrls.GetClient, id));

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

        public async Task<(ClientEntity? data, string error)> Create(string? firstName = null, string? lastName = null, string? street = null, string? streetNumber = null, string? flatNumber = null, string? city = null, string? country = null, string? postalCode = null, string? businessActivityKind = null, string? companyName = null, string? nip = null)
        {
            return await CreateClient(new(businessActivityKind, firstName, lastName, street, streetNumber, flatNumber, city, country, postalCode, companyName, nip));
        }

        public async Task<(ClientEntity? data, string error)> Create(ClientEntity client)
        {
            return await CreateClient(client);
        }

        private async Task<(ClientEntity? data, string error)> CreateClient(ClientEntity client)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, InFaktUrls.PostClient);
            request.Content = new StringContent(JsonSerializer.Serialize(new ClientPost(client)), Encoding.UTF8, "application/json");

            var response = await httpClient.SendAsync(request);

            try
            {
                Console.WriteLine(await response.Content.ReadAsStringAsync());

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

        public async Task<(ClientEntity? data, string error)> Update(int id, ClientEntity client)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, string.Format(InFaktUrls.PutClient, id));
            request.Content = new StringContent(JsonSerializer.Serialize(new ClientPost(client)), Encoding.UTF8, "application/json");

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

        public async Task<(string? data, string error)> Delete(int id)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, string.Format(InFaktUrls.DeleteClient, id));

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
