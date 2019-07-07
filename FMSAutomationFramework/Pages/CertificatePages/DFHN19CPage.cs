using CertsureAutomationFramework.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace CertsureAutomationFramework.Pages
{
    public class DFHN19CPage : BaseCertificatePage  
    {
        [FindsBy(How = How.PartialLinkText, Using = "Next")]
        private IWebElement NextButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "switch")]
        private IWebElement ViewModeCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "view-mode-label")]
        private IWebElement ViewModeLabel { get; set; }
        public DFHN19CPage EnableViewMode(ViewMode viewMode)
        {
            if (viewMode == ViewMode.CertificateMode)
            {
                if (ViewModeLabel.Text == "Certificate Mode")
                    return this;
                else
                {
                    ViewModeCheckBox.Click();
                    return this;
                }
            }
            else
            {
                if (ViewModeLabel.Text == "Data Entry Mode")
                    return this;
                else
                {
                    ViewModeCheckBox.Click();
                    return this;
                }
            }

        }

        public DFHN19CPage ClickNext()
        {
            NextButton.Click();
            return this;
        }

        public DFHN19CPage SpecialClick()
        {
            var url = driver.Url.Split('=');
            string desurl = (int.Parse(url[2]) + 1).ToString();
            driver.Navigate().GoToUrl(url[0] + "=" + url[1] + "=" + desurl); ;
            return this;
        }
        public DFHN19CPage VerifyPage1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 1 : DETAILS OF THE DESIGNER, CLIENT AND INSTALLATION"), "Part 1 title not present");
            Assert.IsTrue(viewSource.Contains("PART 2 :  DETAILS OF THE FIRE DETECTION AND FIRE ALARM SYSTEM COVERED BY THIS CERTIFICATE"), "Part 2 title not present");
            Assert.IsTrue(viewSource.Contains("PART 3 : DESCRIPTION OF SYSTEM GRADE AND SYSTEM CATEGORY  "), "Part 3 title not present");
            Assert.IsTrue(viewSource.Contains("PART 4: COMMISSIONING*  "), "Part 4 title not present");
            return this;
        }

        public DFHN19CPage VerifyPage2Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 5 :  USER INSTRUCTIONS "), "Part 5 title not present");
            Assert.IsTrue(viewSource.Contains("PART 6 : CERTIFICATION OF DESIGN, INSTALLATION AND COMMISSIONING "), "Part 6 title not present");
            return this;
        }
        public DFHN19CPage VerifyPageContinuationPageLoads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Add Image(s)"), " Add Image(s) title is not present");
            return this;
        }

        public DFHN19CPage VerifyPart1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Details of the Client"), "Part 1 title not present");
            return this;
        }
        public DFHN19CPage VerifyPart2Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS OF THE FIRE DETECTION AND FIRE ALARM SYSTEM COVERED BY THIS CERTIFICATE"), "Part 2 title not present");
            return this;
        }
        public DFHN19CPage VerifyPart3Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DESCRIPTION OF SYSTEM GRADE AND SYSTEM CATEGORY"), "Part 3 title not present");
            return this;
        }
        public DFHN19CPage VerifyPart4Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" COMMISSIONING"), "Part 4 title not present");
            return this;
        }
        public DFHN19CPage VerifyPart5Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("USER INSTRUCTIONS "), "Part 5 title not present");
            return this;
        }
        public DFHN19CPage VerifyPart6Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("   CERTIFICATION OF DESIGN CERTIFICATION OF DESIGN, INSTALLATION AND COMMISSIONING "), "Part 6 title not present");
            return this;
        }
        public DFHN19CPage VerifyPart7Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=7"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Images and Notes"), "Part 7 title not present");
            return this;
        }
        public DFHN19CPage VerifyPart8Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=8"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Comments"), "Part 8 title not present");
            return this;
        }
        public DFHN19CPage VerifyPart9Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=9"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Summary &amp; problems"), "Part 9 title not present");
            return this;
        }
    }
}