using inFakt.Lib.Models;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace inFakt.Lib.Services
{
    public interface IInvoiceService
    {
        Task<(Invoices? data, string error)> Get();
        Task<(InvoiceEntity? data, string error)> Get(string uuid);
        Task<(InvoiceEntity? data, string error)> Create(string? clientCompanyName = null, string? clientFirstName = null, string? clientLastName = null, string paymentMethod = "payu", Service[]? services = null);
        Task<(InvoiceEntity? data, string error)> Create(InvoiceEntity invoice);
        Task<(InvoiceEntity? data, string error)> Update(string uuid, InvoiceEntity invoice);
        Task<(string? data, string error)> SetAsPaid(string uuid);
        Task<(string? data, string error)> Delete(string uuid);
        Task<(byte[]? data, string error)> GetPdf(string uuid, string documentType = "original", string locale = "en");
        Task<(ShareLinkResponse? data, string error)> CreateShareLink(string uuid);
        Task<(ShareLinkResponse? data, string error)> GetShareLink(string uuid);
        Task<(ShareLinkResponse? data, string error)> ProlongShareLink(string uuid);
        Task<(ResponseMessage? data, string error)> DeleteShareLink(string uuid);
        Task<(string? data, string error)> CreateQuickPayment(string uuid);
        Task<(string? data, string error)> GetQuickPayment(string uuid);
        Task<(string? data, string error)> DeleteQuickPayment(string uuid);
    }

    public class InvoiceService : IInvoiceService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public InvoiceService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<(Invoices? data, string error)> Get()
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, InFaktUrls.GetInvoices);

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<Invoices>(), string.Empty);
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

        public async Task<(InvoiceEntity? data, string error)> Get(string uuid)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, InFaktUrls.GetInvoices);

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<InvoiceEntity>(), string.Empty);
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

        public async Task<(InvoiceEntity? data, string error)> Create(string? clientCompanyName = null, string? clientFirstName = null, string? clientLastName = null, string paymentMethod = "payu", Service[]? services = null)
        {
            return await CreateInvoice(new(clientCompanyName, clientFirstName, clientLastName, paymentMethod, services));
        }

        public async Task<(InvoiceEntity? data, string error)> Create(InvoiceEntity invoice)
        {
            return await CreateInvoice(invoice);
        }

        private async Task<(InvoiceEntity? data, string error)> CreateInvoice(InvoiceEntity invoice)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, InFaktUrls.PostInvoice);
            request.Content = new StringContent(JsonSerializer.Serialize(new InvoicePost(invoice)), Encoding.UTF8, "application/json");

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<InvoiceEntity>(), string.Empty);
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

        public async Task<(InvoiceEntity? data, string error)> Update(string uuid, InvoiceEntity invoice)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, string.Format(InFaktUrls.PutInvoiceById, uuid));
            request.Content = new StringContent(JsonSerializer.Serialize(new InvoicePost(invoice)), Encoding.UTF8, "application/json");

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<InvoiceEntity>(), string.Empty);
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

        public async Task<(string? data, string error)> SetAsPaid(string uuid)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, string.Format(InFaktUrls.PostInvoiceSetAsPaidByUuid, uuid));

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

        public async Task<(string? data, string error)> Delete(string uuid)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, string.Format(InFaktUrls.DeleteInvoiceByUuid, uuid));

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

        public async Task<(byte[]? data, string error)> GetPdf(string uuid, string documentType = "original", string locale = "en")
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, string.Format(InFaktUrls.GetInvoicePdfByUuid, uuid));
            request.Content = new StringContent(JsonSerializer.Serialize(new GetInvoicePdf(documentType, locale)), Encoding.UTF8, "application/json");

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadAsByteArrayAsync(), string.Empty);
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
        public async Task<(ShareLinkResponse? data, string error)> CreateShareLink(string uuid)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, string.Format(InFaktUrls.PostInvoiceCreateShareLinkByUuid, uuid));

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<ShareLinkResponse>(), string.Empty);
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

        public async Task<(ShareLinkResponse? data, string error)> GetShareLink(string uuid)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, string.Format(InFaktUrls.GetInvoiceShareLinkByUuid, uuid));

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<ShareLinkResponse>(), string.Empty);
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

        public async Task<(ShareLinkResponse? data, string error)> ProlongShareLink(string uuid)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, string.Format(InFaktUrls.PostInvoiceShareLinkProlongByUuid, uuid));

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<ShareLinkResponse>(), string.Empty);
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

        public async Task<(ResponseMessage? data, string error)> DeleteShareLink(string uuid)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, string.Format(InFaktUrls.DeleteInvoiceShareLinkByUuid, uuid));

            var response = await httpClient.SendAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return (await response.Content.ReadFromJsonAsync<ResponseMessage>(), string.Empty);
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

        public async Task<(string? data, string error)> CreateQuickPayment(string uuid)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, string.Format(InFaktUrls.PostInvoiceCreateQuickPaymentByUuid, uuid));

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

        public async Task<(string? data, string error)> GetQuickPayment(string uuid)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, string.Format(InFaktUrls.GetInvoiceQuickPaymentByUuid, uuid));

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

        public async Task<(string? data, string error)> DeleteQuickPayment(string uuid)
        {
            var httpClient = httpClientFactory.CreateClient("InFakt");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, string.Format(InFaktUrls.DeleteInvoiceQuickPaymentByUuid, uuid));

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
