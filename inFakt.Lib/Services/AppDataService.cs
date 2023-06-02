using inFakt.Lib.Models;
using System.Net.Http.Json;

namespace inFakt.Lib.Services
{
    public interface IAppDataService
    {
        Task<(VatRates? data, string error)> GetVatRates();
        Task<(OSSVatRates? data, string error)> GetOSSVatRates();
        Task<(Countries? data, string error)> Countries();
    }

    public class AppDataService : IAppDataService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public AppDataService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<(VatRates? data, string error)> GetVatRates()
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, InFaktUrls.GetVatRates);

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<VatRates>(), string.Empty);
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

        public async Task<(OSSVatRates? data, string error)> GetOSSVatRates()
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, InFaktUrls.GetOSSVatRates);

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<OSSVatRates>(), string.Empty);
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

        public async Task<(Countries? data, string error)> Countries()
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, InFaktUrls.GetCountries);

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<Countries>(), string.Empty);
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
