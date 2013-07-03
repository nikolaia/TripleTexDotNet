# TripleTexDotNet #

a C#.NET Wrapper for TripleTex's Json-RPC API.

This wrapper is third-party and unaffiliated with http://tripletex.no/.

Work in progress (The wrapper is incomplete). 

## Example of usage ##

	var tripleTexFacade = new TripleTexFacade(syncSystem, syncPassword, username, password);
	tripleTexFacade.GetCompanyService().SearchForCustomersAndVendors(CustomerVendorType.All, CustomerIsActive.All, "");

## Integration tests ##

To run the integration tests you need to create an app.config file in the .Tests project:

	<configuration>
		<appSettings>
			<add key="TripleTexSyncSystem" value="7"/>
			<add key="TripleTexSyncPassword" value="loremipsum"/>
			<add key="TripleTexUsername" value="loremipsum"/>
			<add key="TripleTexPassword" value="loremipsum"/>
		</appSettings>
	</configuration>

## TODO ##

- Implement all methods
- Increase test coverage
- Make available on NuGet

## Based on ##
https://tripletex.no/resources/api/tripletex-api.pdf  
Written by Morten Ekanger  
Last modified: 07.05.2013