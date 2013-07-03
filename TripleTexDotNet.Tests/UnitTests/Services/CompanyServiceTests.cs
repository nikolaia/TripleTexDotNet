using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using TripleTexDotNet.Classes;
using TripleTexDotNet.Interfaces;
using TripleTexDotNet.Services;

namespace TripleTexDotNet.Tests.UnitTests.Services
{
    [TestFixture]
    public class CompanyServiceTests
    {
        [Test]
        public void Should_Return_One_Customer_With_Name_Test()
        {
            // Setup
            var jsMock = new Mock<IJsonService>();
            var data = new List<Customer>() {new Customer() {Name = "test"}};
            jsMock.Setup(j => j.Call<IEnumerable<Customer>>("Company.searchForCustomersAndVendors", It.IsAny<int>(), It.IsAny<int>(), It.IsAny<string>())).Returns(data);

            var companyService = new CompanyService(jsMock.Object);

            // Action
            var customers = companyService.SearchForCustomersAndVendors(CustomerVendorType.All, CustomerIsActive.All, "");

            // Verify the result
            Assert.AreEqual(1, customers.Count(c => c.Name == "test"), "Should return 1.");
        }
    }
}
