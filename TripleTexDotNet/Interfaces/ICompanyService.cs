using System.Collections.Generic;
using TripleTexDotNet.Classes;

namespace TripleTexDotNet.Interfaces
{
    public interface ICompanyService
    {
        IEnumerable<Customer> SearchForCustomersAndVendors(CustomerVendorType vendorType, CustomerIsActive isActive,
                                                           string searchString);
        int SaveCustomerVendor(Customer customer);
    }
}
