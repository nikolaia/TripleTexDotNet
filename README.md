# TripleTexDotNet #

a C#.NET Wrapper for TripleTex's Json-RPC API.

This wrapper is third-party and unaffiliated with http://tripletex.no/.

Work in progress (The wrapper is incomplete). 

## Example of usage ##

Initiate the JsonService which keeps our session and does the calls to the Json-RPC API:  
```var jsonService = new JsonService();```  
Before using any methods we have to use the SyncService to Login:  
```var syncSerivce = new SyncService(); syncService.Login(syncSystem, syncPassword, username, password);```  
Now that we have logged in and have a valid session we can use the jsonService in the other TripleTex services:  
```var companyService = new CompanyService(jsonService);```  
Run a method or two:  
```companyService.SearchForCustomersAndVendors(CustomerVendorType.All, CustomerIsActive.All, "");```  
And eventually logout if needed:  
```syncService.Logout();```

## TODO ##

- Implement all methods
- Increase test coverage
- Make available on NuGet

## Based on ##
https://tripletex.no/resources/api/tripletex-api.pdf  
Written by Morten Ekanger  
Last modified: 07.05.2013