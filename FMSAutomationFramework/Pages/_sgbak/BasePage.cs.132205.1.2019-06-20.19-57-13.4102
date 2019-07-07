
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CertsureAutomationFramework.Pages
{
    public class BasePage
    {
        public TestContext TestContext { get; set; }

        protected IWebDriver driver = Driver.Instance;

        public BasePage()
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
