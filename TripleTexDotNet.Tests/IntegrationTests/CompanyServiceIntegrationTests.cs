using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using System.Configuration;
using TripleTexDotNet.Classes;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Tests.IntegrationTests
{
    [TestFixture]
    class CompanyServiceIntegrationTests
    {
        private ITripleTexFacade _tripleTexFacade;

        [TestFixtureSetUp]
        public void init()
        {
            _tripleTexFacade = new TripleTexFacade(Convert.ToInt32(ConfigurationManager.AppSettings["TripleTexSyncSystem"]),
                ConfigurationManager.AppSettings["TripleTexSyncPassword"],
                ConfigurationManager.AppSettings["TripleTexUsername"],
                ConfigurationManager.AppSettings["TripleTexPassword"]);
            
        }

        [Test]
        public void Add_Customer_And_Order()
        {
            var c = new Customer()
            {
                Email = "test@example.com",
                InvoiceEmail = "test@example.com",
                MobileNumber = "12345678",
                PhoneNumber = "12345678",
                Name = "Testkunde (DELETE ME)",
                PhysicalAddress1 = "Eksempeladdresse",
                PhysicalCity = "Andeby",
                PhysicalPostalNumber = "1234",
                PhysicalCountryCode = "NO",
                PostalAddress1 = "Postboks 9000",
                PostalCity = "Andeby",
                PostalNumber = "1234",
                PostalCountryCode = "NO",
                LanguageCode = "NO",
                AccountManagerId = "",
                CurrencyCode = "NOK",
                CustomerAccountNumber = "0",
                CustomerCategoryId1 = "0",
                CustomerCategoryId2 = "0",
                CustomerCategoryId3 = "0",
                FaxNumber = "",
                OrganizationNumber = "",
                PhysicalAddress2 = "",
                PostalAddress2 = "",
                VendorAccountNumber = "0"
            };

            _tripleTexFacade.GetCompanyService().SaveCustomerVendor(c);

            var customer = _tripleTexFacade.GetCompanyService()
                                           .SearchForCustomersAndVendors(CustomerVendorType.All, CustomerIsActive.All,
                                                                         "" + c.Name);

            var customers = customer as IList<Customer> ?? customer.ToList();
            if (!customers.Any()) throw new Exception("No Customers where returned");

            var o = new Order()
            {
                CustomerNumber = "" + customers.FirstOrDefault().CustomerAccountNumber,
                ContactFirstName = "Donald",
                ContactLastName = "Duck",
                OrderComment = "Dette er en testordre, DELETE ME",
                OrderDate = DateTime.Now.ToString("yyyy-MM-dd"),
                ProductNumber = "300000",
                VatType = "3",
                Count = "1",
                UnitPrice = "2200,00"
            };

            _tripleTexFacade.GetOrderService().ImportOrdersTripletexCsv(o);

            Assert.Pass();
        }
    }
}
