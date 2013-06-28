using System.Collections.Generic;
using TripleTexDotNet.Classes;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IJsonService _service;

        public CompanyService(IJsonService service)
        {
            _service = service;
        }

        public IEnumerable<Customer> SearchForCustomersAndVendors(CustomerVendorType vendorType, CustomerIsActive isActive, string searchString)
        {
            return _service.Call<IEnumerable<Customer>>("Company.searchForCustomersAndVendors", (int)vendorType, (int)isActive, searchString);
        }

        public Customer SaveCustomerVendor(Customer customer)
        {
            return _service.Call<Customer>("Project.saveCustomerVendor", Helpers.ObjectToObjectArray(customer));
        }
    }
}
