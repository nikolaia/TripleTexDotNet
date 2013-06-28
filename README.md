# TripleTexDotNet 

a C#.NET Wrapper for TripleTex's Json-RPC API.

This wrapper is third-party and unaffiliated with http://tripletex.no/.

Work in progress (The wrapper is incomplete). 

Example of usage:

```var syncService = new SyncService(syncSystem, syncPassword, username, password);
var companyService = new CompanyService(syncService.GetService());
companyService.SearchForCustomersAndVendors(CustomerVendorType.All, CustomerIsActive.All, "");
syncService.Logout();```

## TODO

- Implement all methods
- Add tests
- Make available on NuGet

## Based on
https://tripletex.no/resources/api/tripletex-api.pdf 
Written by Morten Ekanger
Last modified: 07.05.2013