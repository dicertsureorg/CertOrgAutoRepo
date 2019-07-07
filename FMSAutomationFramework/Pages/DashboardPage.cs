using CertsureAutomationFramework.Enum;
using CertsureAutomationFramework.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;



namespace CertsureAutomationFramework.Pages
{
    public class DashboardPage : BasePage
    {
        [FindsBy(How = How.PartialLinkText, Using = "Log out")]
        private IWebElement LogoutButton { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Certificate")]
        private IWebElement CertificateLink { get; set; }

        [FindsBy(How = How.Id, Using = "18ed")]
        private IWebElement CertificateLinkBlue18Edition { get; set; }

        public IMN18CPage CreateCertificateType(CertificateType iMN18C)
        {
            ExistingCertListPage existingCertListPage = GotoCertificateTab();
            existingCertListPage.GotoCertificateView(iMN18C);
            return NOCSPageHelper.IMN18C;
        }
       

        private ExistingCertListPage GotoCertificateTab()
        {
            CertificateLink.Click();
            CertificateLinkBlue18Edition.Click();
            return NOCSPageHelper.ExistingCertListPage;
        }

        [FindsBy(How = How.PartialLinkText, Using = "Existing Certificates")]
        private IWebElement ExistingCertificates { get; set; }

        public DashboardPage VerifyLogOutButtonIsPresent()
        {
            Assert.AreEqual("Log out", LogoutButton.Text, "log out button does not contain log out text");
            return this;
        }

        public ExistingCertListPage Goto18EdExistingCertListPage(TestContext context)
        {
            CertificateLink.Click();
            CertificateLinkBlue18Edition.Click();
            //In UAT environment, uncomment this line
            //ExistingCertificates.Click(); //In UAT environment, uncomment this line 

            return NOCSPageHelper.ExistingCertListPage;
        }
    }
}