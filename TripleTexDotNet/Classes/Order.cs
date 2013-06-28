namespace TripleTexDotNet.Classes
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public string OrderDate { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerPostalNumber { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerEmail { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string AttnFirstName { get; set; }
        public string AttnLastName { get; set; }
        public string ReferenceNumber { get; set; }
        public string DeliveryDate { get; set; } //If not provided, the order date will be used.
        public string DeliveryLocation { get; set; }
        public string OrderComment { get; set; }
        public string SubscriptionUnitPricePeriod { get; set; } // Number of months/years.
        public string SubscriptionUnitPricePeriodUnit { get; set; } // 0: Months. 2: Years
        public string SubscriptionInvoicePeriod { get; set; }
        public string SubscriptionInvoicingType { get; set; } // 0: In advance. 1: In arrears
        public string SubscriptionInvoicingPeriodCount { get; set; } // Number of months/days in advance or in arrears.
        public string SubscriptionInvoicingPeriodUnit { get; set; } // 0: Months. 1: Days
        public string SubscriptionStartDate { get; set; }
        public string Count { get; set; }
        public string UnitPrice { get; set; }
        public string DiscountPercentage { get; set; }
        public string VatType { get; set; } // 3: High vat. 31: Medium vat. 32: Low vat. 5: No vat (inside). 6: No vat (outside).
        public string OrderLineDescription { get; set; }
        public string ProductNumber { get; set; }
        public string ProductName { get; set; }
        public string DepartmentNumber { get; set; }
        public string DepartmentName { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectName { get; set; }
        public string CurrencyCode { get; set; }
        public string WarehouseNumber { get; set; }
        public string WarehouseName { get; set; }

    }
}
