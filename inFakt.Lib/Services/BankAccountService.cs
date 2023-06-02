using inFakt.Lib.Models;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace inFakt.Lib.Services
{
    public interface IBankAccountService
    {
        Task<(BankAccounts? data, string error)> Get();
        Task<(BankAccountEntity? data, string error)> Get(int id);
        Task<(BankAccountEntity? data, string error)> Create(BankAccountEntity bankAccount);
        Task<(BankAccountEntity? data, string error)> Update(int id, BankAccountEntity bankAccount);
        Task<(string? data, string error)> Delete(int id);
    }
    public class BankAccountService : IBankAccountService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public BankAccountService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<(BankAccounts? data, string error)> Get()
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, InFaktUrls.GetBankAccounts);

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<BankAccounts>(), string.Empty);
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

        public async Task<(BankAccountEntity? data, string error)> Get(int id)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, string.Format(InFaktUrls.GetBankAccount, id));

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<BankAccountEntity>(), string.Empty);
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

        public async Task<(BankAccountEntity? data, string error)> Create(BankAccountEntity bankAccount)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, InFaktUrls.PostBankAccount);
            request.Content = new StringContent(JsonSerializer.Serialize(new BankAccountPost(bankAccount)), Encoding.UTF8, "application/json");

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<BankAccountEntity>(), string.Empty);
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

        public async Task<(BankAccountEntity? data, string error)> Update(int id, BankAccountEntity bankAccount)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, string.Format(InFaktUrls.PutBankAccount, id));
            request.Content = new StringContent(JsonSerializer.Serialize(new BankAccountPost(bankAccount)), Encoding.UTF8, "application/json");

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<BankAccountEntity>(), string.Empty);
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

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, string.Format(InFaktUrls.DeleteBankAccount, id));

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
