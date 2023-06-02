using inFakt.Lib.Models;
using System.Net.Http.Json;

namespace inFakt.Lib.Services
{
    public interface IInsuranceService
    {
        Task<(InsuranceFees? data, string error)> Get();
        Task<(ZUSEntity? data, string error)> Get(int id);
    }

    public class InsuranceService : IInsuranceService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public InsuranceService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<(InsuranceFees? data, string error)> Get()
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, InFaktUrls.GetInsuranceFees);

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<InsuranceFees>(), string.Empty);
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

        public async Task<(ZUSEntity? data, string error)> Get(int id)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, string.Format(InFaktUrls.GetInsuranceFees, id));

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<ZUSEntity>(), string.Empty);
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
