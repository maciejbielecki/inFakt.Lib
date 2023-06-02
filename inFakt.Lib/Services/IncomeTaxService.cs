using inFakt.Lib.Models;
using System.Net.Http.Json;

namespace inFakt.Lib.Services
{
    public interface IIncomeTaxService
    {
        Task<(IncomeTaxes? data, string error)> Get();
        Task<(IncomeTaxEntity? data, string error)> Get(string id);
    }

    public class IncomeTaxService : IIncomeTaxService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public IncomeTaxService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<(IncomeTaxes? data, string error)> Get()
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, InFaktUrls.GetIncomeTaxes);

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<IncomeTaxes>(), string.Empty);
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

        public async Task<(IncomeTaxEntity? data, string error)> Get(string id)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, string.Format(InFaktUrls.GetIncomeTaxById, id));

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<IncomeTaxEntity>(), string.Empty);
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
