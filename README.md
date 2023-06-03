# inFakt.Lib

The inFakt API is vast and complex and this project exposes it with minimum modifications - support is very limited. Library do not contains every endpoints for now, but is sufficient to manage the account.
For now this version allow you to manage invoices, clients and products.

Contributions are always welcome! 

# License

[![CC0](https://licensebuttons.net/p/zero/1.0/88x31.png)](https://creativecommons.org/publicdomain/zero/1.0/)


# Table of Contents

* [inFakt.Lib](#inFakt-lib)
  * [Add to project](#Addtoproject)
  * [ClientService](#ClientService)
  * [IncomeTaxService](#IncomeTaxService)
  * [InsuranceService](#InsuranceService)
  * [ProductService](#ProductService)
  * [InvoiceService](#InvoiceService)
  * [AppDataService](#AppDataService)
  * [BankAccountService](#BankAccountService)
  * [UserDataService](#UserDataService)


## Add to project

* .builder.Services.AddInFakt(<api key>, <api type>)

## ClientService

* [Get] - Get all clients connected to account
* [Get(int id)] - Get client by id
* [Create] - Create new client
* [Update(int id, ClientEntity client)] - Update client by id
* [Delete(int id)] - Delete client by id

## IncomeTaxService

* [Get] - Get account income taxes
* [Get(string id)] - Get specified income tax by id

## InsuranceService

* [Get] - Get account insurance fees
* [Get(int id)] - Get specified insurance fee by id

## ProductService

* [Get] - Get all products connected to account
* [Get(int id)] - Get product by id
* [Create] - Create new product
* [Update(int id, ProductEntity product)] - Update product by id
* [Delete(int id)] - Delete product by id

## InvoiceService

* [Get] - Get all invoices connected to account
* [Get(string uuid)] - Get invoice by id
* [Create] - Create new invoice
* [Update(string uuid, InvoiceEntity invoice)] - Update invoice by id
* [Delete(string uuid)] - Delete invoice by id
* [SetAsPaid(string uuid)] - Set invoice as paid
* [GetPdf(string uuid, string documentType = "original", string locale = "en")] - Get invoice as pdf
* [CreateShareLink(string uuid)] - Create invoice share link
* [GetShareLink(string uuid)] - Get invoice share link
* [ProlongShareLink(string uuid)] - Prolong invoice share link
* [DeleteShareLink(string uuid)] - Delete invoice share link
* [CreateQuickPayment(string uuid)] - Create invoice quick payment link
* [GetQuickPayment(string uuid)] - Get invoice quick payment link
* [DeleteQuickPayment(string uuid)] - Delete invoice quick payment link

## AppDataService

* [GetVatRates] - Get all vat rates
* [GetOSSVatRates] -  Get all moss vat rates
* [Countries] -  Get all countries

## ProductService

* [Get] - Get all bank accounts connected to account
* [Get(int id)] - Get bank account by id
* [Create] - Create new bank account
* [Update(int id, ProductEntity product)] - Update bank account by id
* [Delete(int id)] - Delete bank account by id

## UserDataService

* [Get] - Get user account data