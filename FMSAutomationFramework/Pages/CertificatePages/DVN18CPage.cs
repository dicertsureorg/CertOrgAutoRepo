using CertsureAutomationFramework.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace CertsureAutomationFramework.Pages
{
    public class DVN18CPage : BaseCertificatePage  
    {
        [FindsBy(How = How.PartialLinkText, Using = "Next")]
        private IWebElement NextButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "switch")]
        private IWebElement ViewModeCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "view-mode-label")]
        private IWebElement ViewModeLabel { get; set; }
        public DVN18CPage EnableViewMode(ViewMode viewMode)
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
        public DVN18CPage ClickNext()
        {
            NextButton.Click();
            return this;
        }
        public DVN18CPage SpecialClick()
        {
            var url = driver.Url.Split('=');
            string desurl = (int.Parse(url[2]) + 1).ToString();
            driver.Navigate().GoToUrl(url[0] + "=" + url[1] + "=" + desurl); ;
            return this;
        }
        public DVN18CPage VerifyPage1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 1 : DETAILS OF THE APPROVED CONTRACTOR AND INSTALLATION"), "Part 1 title not present");
            Assert.IsTrue(viewSource.Contains("PART 2 : SUMMARY OF THE CONDITION OF THE INSTALLATION "), "Part 2 title not present");
            Assert.IsTrue(viewSource.Contains("PART 3 : NEXT INSPECTION"), "Part 3 title not present");
            Assert.IsTrue(viewSource.Contains("PART 4 : DECLARATION "), "Part 4 title not present");
            Assert.IsTrue(viewSource.Contains("PART 5 : CONSUMER UNIT"), "Part 5 title not present");
            return this;
        }

        public DVN18CPage VerifyPage2Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 6 : ORIGIN OF THE INSTALLATION"), "Part 6 title not present");
            Assert.IsTrue(viewSource.Contains("PART 7 : OBSERVATIONS AND RECOMMENDATIONS FOR ACTIONS TO BE TAKEN"), "Part 7 title not present");
            Assert.IsTrue(viewSource.Contains("PART 8 : LOCATION CONTAINING A BATH OR SHOWER"), "Part 8 title not present");
            return this;
        }

        public DVN18CPage VerifyPageContinuationPageLoads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Add Image(s)"), " Add Image(s) title is not present");
            return this;
        }

        public DVN18CPage VerifyPart1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Details of the Client"), "Part 1 title is not present");
            return this;
        }

        public DVN18CPage VerifyPart2Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" SUMMARY OF THE CONDITION OF THE INSTALLATION"), "Part 2 title is not present");
            return this;
        }
        public DVN18CPage VerifyPart3Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" NEXT INSPECTION"), "Part 3 title is not present");
            return this;
        }
        public DVN18CPage VerifyPart4Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" DECLARATION "), "Part 4 title is not present");
            return this;
        }
        public DVN18CPage VerifyPart5Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" CONSUMER UNIT "), "Part 5 title is not present");
            return this;
        }
        public DVN18CPage VerifyPart6Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" ORIGIN OF THE INSTALLATION "), "Part 6 title is not present");
            return this;
        }
        public DVN18CPage VerifyPart7Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=7"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" LOCATION CONTAINING A BATH OR SHOWER "), "Part 7 title is not present");
            return this;
        }
        public DVN18CPage VerifyPart8Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=8"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("OBSERVATIONS AND RECOMMENDATIONS FOR ACTIONS TO BE TAKEN"), "Part 8 title is not present");
            return this;
        }

        public DVN18CPage VerifyPart9Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=9"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Comments"), "Part 9 title is not present");
            return this;
        }
        public DVN18CPage VerifyPart10Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=10"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Images and Notes"), "Part 10 title is not present");
            return this;
        }
        public DVN18CPage VerifyPart11Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=11"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Summary &amp; problems"), "Part 11 title is not present");
            return this;
        }
    }
}