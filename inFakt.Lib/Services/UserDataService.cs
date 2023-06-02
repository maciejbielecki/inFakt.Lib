using inFakt.Lib.Models;
using System.Net.Http.Json;

namespace inFakt.Lib.Services
{
    public interface IUserDataService
    {
        Task<(UserData? data, string error)> Get();

    }
    public class UserDataService : IUserDataService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public UserDataService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        public async Task<(UserData? data, string error)> Get()
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, InFaktUrls.GetUserData);

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<UserData>(), string.Empty);
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
