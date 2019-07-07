using CertsureAutomationFramework;
using CertsureAutomationFramework.Helpers;
using CertsureAutomationFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CertsureAutomationTest
{
    public class BaseTest
    {
        public TestContext TestContext { get; set; }
        public DashboardPage dashboardPage; 

        [TestInitialize]
        public void Init()
        {
            Driver.initialize(TestContext);
           // dashboardPage = NOCSPageHelper.Login(TestContext);
        }

        [TestCleanup]
        public void Close()
        {
            Driver.Close();
        }

    }
}
