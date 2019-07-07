using CertsureAutomationFramework.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace CertsureAutomationFramework.Pages
{
    public class EVM2CPage : BaseCertificatePage  
    {
        [FindsBy(How = How.PartialLinkText, Using = "Next")]
        private IWebElement NextButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "switch")]
        private IWebElement ViewModeCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "view-mode-label")]
        private IWebElement ViewModeLabel { get; set; }
        public EVM2CPage EnableViewMode(ViewMode viewMode)
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
        public EVM2CPage ClickNext()
        {
            NextButton.Click();
            return this;
        }

        public EVM2CPage VerifyPage1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 1: DETAILS OF THE CONTRACTOR, CLIENT AND INSTALLATION"), "Part 1 title not present");
            Assert.IsTrue(viewSource.Contains("PART 2: DETAILS OF THE EMERGENCY LIGHTING INSTALLATION COVERED BY THIS CERTIFICATE"), "Part 2 title not present");
            Assert.IsTrue(viewSource.Contains("PART 3: DECLARATION OF CONFORMITY"), "Part 3 title not present");
            Assert.IsTrue(viewSource.Contains("PART 4 : RELATED REFERENCE DOCUMENTS (If any)"), "Part 4 title not correct");
            return this;
        }

        public EVM2CPage VerifyPage2Loads()
        {
            //Url contains part=2
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 5 : COMPLIANCE CHECKLIST "), "Part 5 title not correct");
            return this;
        }

        public EVM2CPage VerifyPage3Loads()
        {
            //Url contains part=2
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 5 : COMPLIANCE CHECKLIST "), "Part 5 continuation title not correct");

            Assert.IsTrue(viewSource.Contains("PART 6 : DETAILS OF DEVIATIONS FROM THE RECOMMENDATIONS OF BS 5266-1  "), "Part 6 continuation title not correct");
            Assert.IsTrue(viewSource.Contains("PART 7 : COMMENTS ON EXISTING INSTALLATION "), "Part 7 title not correct");
            return this;
        }

        public EVM2CPage VerifyPageContinuationPageLoads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Add Image(s)"), "Add Image(s) title is not present");
            return this;
        }

        public EVM2CPage VerifyPart1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS OF THE CONTRACTOR"), "Part 1 title is not present");
            return this;
        }
        public EVM2CPage VerifyPart2Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS OF THE EMERGENCY LIGHTING INSTALLATION COVERED BY THIS CERTIFICATE"), "Part 2 title is not present");
            return this;
        }
        public EVM2CPage VerifyPart3Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" DECLARATION OF CONFORMITY "), "Part 3 title is not present");
            return this;
        }
        public EVM2CPage VerifyPart4Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("  RELATED REFERENCE DOCUMENTS"), "Part 4 title is not present");
            return this;
        }
        public EVM2CPage VerifyPart5Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("COMPLIANCE CHECKLIST"), "Part 5 title is not present");
            return this;
        }
        public EVM2CPage VerifyPart6Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("COMPLIANCE CHECKLIST - Continuation"), "Part 6 title is not present");
            return this;
        }
        public EVM2CPage VerifyPart7Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=7"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS OF DEVIATIONS FROM THE RECOMMENDATIONS OF "), "Part 7 title is not present");
            return this;
        }
        public EVM2CPage VerifyPart8Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=8"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("  COMMENTS ON EXISTING INSTALLATION "), "Part 8 title is not present");
            return this;
        }
        public EVM2CPage VerifyPart9Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=9"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Images and Notes"), "Part 9 title is not present");
            return this;
        }
        public EVM2CPage VerifyPart10Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=10"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Comments"), "Part 10 title is not present");
            return this;
        }
        public EVM2CPage VerifyPart11Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=11"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Summary & problems"), "Part 11 title is not present");
            return this;
        }
    }
}