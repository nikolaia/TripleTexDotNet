using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripleTexDotNet.Classes;

namespace TripleTexDotNet.Services
{
    public class CompanyService
    {
        private readonly SyncService _syncService;

        public CompanyService(SyncService syncService)
        {
            _syncService = syncService;
        }

        public IEnumerable<Customer> SearchForCustomersAndVendors(CustomerVendorType vendorType, CustomerIsActive isActive, string searchString)
        {
            return _syncService.GetService().Call<IEnumerable<Customer>>("Company.searchForCustomersAndVendors", (int)vendorType, (int)isActive, searchString);
        }

        public Customer SaveCustomerVendor(Customer customer)
        {
            return _syncService.GetService().Call<Customer>("Project.saveCustomerVendor", Helpers.ObjectToObjectArray(customer));
        }
    }
}
