using inFakt.Lib;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddInFakt("9a6732c99e58005e443de26290f865ed1b239f1e", ApiType.Sandbox);
    })
    .Build();

//var pId = (await host.Services.GetService<IProductService>().Create("Testowy 4", 1, 40000, 9200, 49200)).data.Id;
//await host.Services.GetService<IProductService>().Update(pId.ToString(), new() { Name = "Produkt testowy 4" });

//var cId = (await host.Services.GetService<IClientService>().Create("Test", "Testowy", "UlTestowa", "123", "4", "Poznan", "PL", "66-666")).data.Id;
//await host.Services.GetService<IClientService>().Update("206", new() { Street = "Testowa" });

//var uuid = (await host.Services.GetService<IInvoiceService>().Create(null, "Test", "Testowy", "payu", new Service[] { new("Produkt testowy 4", 40000, 49200) })).data.Uuid;
//Console.WriteLine(JsonSerializer.Serialize((await host.Services.GetService<IInvoiceService>().Update("986bd8eb-9aca-4f53-9512-f980ef1eba1a", new() { PaymentMethod = "paypal" })).data));
//await host.Services.GetService<IInvoiceService>().SetAsPaid("986bd8eb-9aca-4f53-9512-f980ef1eba1a");
//await host.Services.GetService<IInvoiceService>().Delete("7828eb84-c811-4cc6-a606-be7ee2be8392");

//using var writer = new BinaryWriter(File.Create("invoice.pdf"));
//writer.Write((await host.Services.GetService<IInvoiceService>().GetPdf("92c3f958-beb8-493e-a968-b6b02f6b24b0", locale: "pl")).data);

//File.WriteAllText("products.json", JsonSerializer.Serialize((await host.Services.GetService<IProductService>().Get()).data));
//File.WriteAllText("clients.json", JsonSerializer.Serialize((await host.Services.GetService<IClientService>().Get()).data));
//File.WriteAllText("invoices.json", JsonSerializer.Serialize((await host.Services.GetService<IInvoiceService>().Get()).data));
//File.WriteAllText("userdata.json", JsonSerializer.Serialize((await host.Services.GetService<IUserDataService>().Get()).data));

await host.RunAsync();