namespace inFakt.Lib
{
    public static class InFaktUrls
    {
        public static string GetUserData => "account/details.json";

        public static string GetInsuranceFees => "insurance_fees.json";
        public static string GetInsuranceFeeById => "insurance_fees/{0}.json";

        public static string GetInvoices => "invoices.json";
        public static string GetInvoiceByUuid => "invoices/{0}.json";
        public static string PostInvoice => "invoices.json";
        public static string PutInvoiceById => "invoices/{0}.json";
        public static string PostInvoiceSetAsPaidByUuid => "invoices/{0}/paid.json";
        public static string DeleteInvoiceByUuid => "invoices/{0}.json";
        public static string GetInvoicePdfByUuid => "invoices/{0}/pdf.json";
        public static string PostInvoiceCreateShareLinkByUuid => "invoices/{0}/share_links.json";
        public static string GetInvoiceShareLinkByUuid => "invoices/{0}/share_links.json";
        public static string PostInvoiceShareLinkProlongByUuid => "invoices/{0}/share_links/prolong.json";
        public static string DeleteInvoiceShareLinkByUuid => "invoices/{0}/share_links.json";
        public static string PostInvoiceCreateQuickPaymentByUuid => "invoices/{0}/quick_payments.json";
        public static string GetInvoiceQuickPaymentByUuid => "invoices/{0}/quick_payments.json";
        public static string DeleteInvoiceQuickPaymentByUuid => "invoices/{0}/quick_payments.json";

        public static string GetClients => "clients.json";
        public static string PostClient => "clients.json";
        public static string GetClient => "clients/{0}.json";
        public static string PutClient => "clients/{0}.json";
        public static string DeleteClient => "clients/{0}.json";


        public static string GetProducts => "products.json";
        public static string GetProductById => "products/{0}.json";
        public static string PostProduct => "products.json";
        public static string PutProduct => "products/{0}.json";
        public static string DeleteProduct => "products/{0}.json";

        public static string GetIncomeTaxes => "income_taxes.json";
        public static string GetIncomeTaxById => "income_taxes/{0}.json";
    }
}
