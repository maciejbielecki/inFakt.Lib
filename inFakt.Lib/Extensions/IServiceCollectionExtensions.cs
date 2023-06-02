using inFakt.Lib;
using inFakt.Lib.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;

namespace Microsoft.AspNetCore.Builder
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddInFakt(this IServiceCollection sc, string apiKey, ApiType type)
        {
            sc = sc
                .AddSingleton(new InFakt(apiKey, type))
                .AddScoped<IClientService, ClientService>()
                .AddScoped<IIncomeTaxService, IncomeTaxService>()
                .AddScoped<IInsuranceService, InsuranceService>()
                .AddScoped<IInvoiceService, InvoiceService>()
                .AddScoped<IProductService, ProductService>()
                .AddScoped<IAppDataService, AppDataService>()
                .AddScoped<IBankAccountService, BankAccountService>()
                .AddScoped<IUserDataService, UserDataService>();

            sc.AddHttpClient("InFakt", httpClient =>
            {
                httpClient.BaseAddress = new Uri(type == ApiType.Sandbox ? "https://api.sandbox-infakt.pl/api/v3/" : "https://api.infakt.pl/api/v3/");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Add("X-inFakt-ApiKey", apiKey);
            });



            return sc;
        }
    }
}