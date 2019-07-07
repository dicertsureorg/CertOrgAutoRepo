using CertsureAutomationFramework.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace CertsureAutomationFramework.Pages
{
    public class FIN7CPage : BaseCertificatePage  
    {
        [FindsBy(How = How.PartialLinkText, Using = "Next")]
        private IWebElement NextButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "switch")]
        private IWebElement ViewModeCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "view-mode-label")]
        private IWebElement ViewModeLabel { get; set; }
        public FIN7CPage EnableViewMode(ViewMode viewMode)
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
        public FIN7CPage ClickNext()
        {
            NextButton.Click();
            return this;
        }
        public FIN7CPage SpecialClick()
        {
            var url = driver.Url.Split('=');
            string desurl = (int.Parse(url[2]) + 1).ToString();
            driver.Navigate().GoToUrl(url[0] + "=" + url[1] + "=" + desurl); ;
            return this;
        }

        public FIN7CPage VerifyPageContinuationPageLoads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Add Image(s)"), " Add Image(s) title is not present");
            return this;
        }
        public FIN7CPage VerifyPage1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 1 : DETAILS OF THE CONTRACTOR, CLIENT AND INSTALLATION"), "Part 1 title not present");
            Assert.IsTrue(viewSource.Contains("PART 2 : DETAILS OF THE FIRE DETECTION AND FIRE ALARM SYSTEM COVERED BY THIS CERTIFICATE"), "Part 2 title not present");
            Assert.IsTrue(viewSource.Contains("PART 3 :  INSPECTION AND TESTING OF WIRING SYSTEM(S)  "), "Part 3 title not present");
            Assert.IsTrue(viewSource.Contains("PART 4 : CERTIFICATION OF INSTALLATION"), "Part 4 title not present");
            Assert.IsTrue(viewSource.Contains("PART 5 : RELATED REFERENCE DOCUMENTS"), "Part 5 title not present");
            return this;
        }

        public FIN7CPage VerifyPage2Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 3 : INSPECTION AND TESTING OF WIRING SYSTEM(S)"), "Part 3 title not correct");
            Assert.IsTrue(viewSource.Contains("ADDITIONAL TEST(S) REQUIRED BY MANUFACTURER OR OTHER"), "FIN7C Page 2 part 4 title not correct");
            return this;
        }

        public FIN7CPage VerifyPart1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS OF THE CLIENT"), "Part 1 title is not present");
            return this;
        }
        public FIN7CPage VerifyPart2Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" DETAILS OF THE FIRE DETECTION AND FIRE ALARM SYSTEM COVERED BY THIS CERTIFICATE"), "Part 2 title is not present");
            return this;
        }
        public FIN7CPage VerifyPart3Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("  INSPECTION AND TESTING OF WIRING SYSTEM(S) "), "Part 3 title is not present");
            return this;
        }

        public FIN7CPage VerifyPart4Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" CERTIFICATION OF INSTALLATION "), "Part 4 title is not present");
            return this;
        }
        public FIN7CPage VerifyPart5Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("  RELATED REFERENCE DOCUMENTS"), "Part 5 title is not present");
            return this;
        }
        public FIN7CPage VerifyPart6Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" Test Results"), "Part 6 title is not present");
            return this;
        }
        public FIN7CPage VerifyPart7Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=7"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Images and Notes"), "Part 7 title is not present");
            return this;
        }
        public FIN7CPage VerifyPart8Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=8"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Comments"), "Part 8 title is not present");
            return this;
        }
        public FIN7CPage VerifyPart9Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=9"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Summary &amp; problems"), "Part 9 title is not present");
            return this;
        }
    }
}