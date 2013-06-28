using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet.Classes
{
    public class Customer
    {
        public string Name { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string VendorAccountNumber { get; set; }
        public string OrganizationNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public string InvoiceEmail { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalNumber { get; set; }
        public string PostalCity { get; set; }
        public string PostalCountryCode { get; set; }
        public string PhysicalAddress1 { get; set; }
        public string PhysicalAddress2 { get; set; }
        public string PhysicalPostalNumber { get; set; }
        public string PhysicalCity { get; set; }
        public string PhysicalCountryCode { get; set; }
        public string AccountManagerId { get; set; }
        public string CustomerCategoryId1 { get; set; }
        public string CustomerCategoryId2 { get; set; }
        public string CustomerCategoryId3 { get; set; }
        public string LanguageCode { get; set; }
        public string CurrencyCode { get; set; }
    }
}
