using System;
using CertsureAutomationFramework.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;


namespace CertsureAutomationFramework.Pages
{
    public class IMN18CSummaryPage : BaseCertificatePage 
    {
      
        [FindsBy(How = How.Id, Using = "SummaryOptions_EmailChecked")]
        private IWebElement SummaryOptionsEmailChecked { get; set; }

        [FindsBy(How = How.Id, Using = "complete-certificate")]
        private IWebElement CompleteCertificate { get; set; }

        public IMN18CSummaryPage EmailPdfToCustomer(bool emailPdfToCustomer)
        {
            if (emailPdfToCustomer)
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("SummaryOptions_EmailChecked")));
                SummaryOptionsEmailChecked.Click();

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("SummaryOptions_EmailDetails_EmailTo")));
                driver.FindElement(By.Id("SummaryOptions_EmailDetails_EmailTo")).Clear();
                driver.FindElement(By.Id("SummaryOptions_EmailDetails_EmailTo")).SendKeys("divine_agbor@yahoo.com");

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("SummaryOptions_EmailDetails_EmailBody")));
                driver.FindElement(By.Id("SummaryOptions_EmailDetails_EmailBody")).Clear();
                driver.FindElement(By.Id("SummaryOptions_EmailDetails_EmailBody")).SendKeys("Here is your attached certificate in pdf");
            }
            else
            { }
            return this;
        }

        public IMN18CSummaryPage Finalized()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("complete-certificate")));
            CompleteCertificate.Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("complete-certificate")));
            Assert.IsFalse(driver.FindElement(By.Id("complete-certificate")).GetAttribute("Enabled") == "false", "Finalized certificate button is not disable");
            return this;
        }
    }
}