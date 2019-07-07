using CertsureAutomationFramework.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CertsureAutomationTest
{
    [TestClass]
    public class LoginTest : BaseTest   
    {
        [TestMethod]
        [TestCategory("Smoke")]
        public void Login()
        {
            NOCSPageHelper.LoginPage
                .LoginAsAdmin(TestContext)
                .VerifyLogOutButtonIsPresent();
        }

        
    }
}
