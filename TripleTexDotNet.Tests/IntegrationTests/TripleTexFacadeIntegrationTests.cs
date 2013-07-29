using System;
using NUnit.Framework;
using System.Configuration;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Tests.IntegrationTests
{
    [TestFixture]
    class TripleTexFacadeIntegrationTests
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
        public void Check_If_AppConfig_Is_Present_And_Has_Correct_Values()
        {
            Assert.IsTrue(ConfigurationManager.AppSettings.Count == 4,
                "Make sure you have an app.config in the test project with the appSetting keys TripleTexSyncSystem, TripleTexSyncPassword, TripleTexUsername and TripleTexPassword.");
        }

        [Test]
        public void Check_If_Dependency_Injection_Is_Working()
        {
            Assert.IsNotNull(_tripleTexFacade.GetCompanyService(), "Should be type ICompanyService.");
        }

        [Test]
        public void Make_Sure_JsonService_Keeps_The_Session_Cookie()
        {
            _tripleTexFacade.GetCompanyService()
                            .SearchForCustomersAndVendors(CustomerVendorType.All, CustomerIsActive.All, "");


            _tripleTexFacade.GetCompanyService()
                            .SearchForCustomersAndVendors(CustomerVendorType.All, CustomerIsActive.All, "");

            Assert.Pass();
        }
    }
}
