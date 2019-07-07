using System;
using CertsureAutomationFramework.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace CertsureAutomationFramework.Pages
{
    public class EPM6CPage : BaseCertificatePage
    {
        [FindsBy(How = How.PartialLinkText, Using = "Next")]
        private IWebElement NextButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "switch")]
        private IWebElement ViewModeCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "view-mode-label")]
        private IWebElement ViewModeLabel { get; set; }
        public EPM6CPage EnableViewMode(ViewMode viewMode)
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
        public EPM6CPage ClickNext()
        {
            NextButton.Click();
            return this;
        }

        public EPM6CPage VerifyPage1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 1 :   DETAILS OF THE CONTRACTOR, CLIENT AND INSTALLATION"), "Part 1 title not correct");
            Assert.IsTrue(viewSource.Contains("PART 2: DETAILS OF THE EMERGENCY LIGHTING INSTALLATION COVERED BY THIS CERTIFICATE"), "Part 2 title not correct");
            Assert.IsTrue(viewSource.Contains("PART 3 : CERTIFICATION "), "Part 3 title not correct");
            Assert.IsTrue(viewSource.Contains("PART 4 : DETAILS OF DEVIATIONS FROM THE RECOMMENDATIONS OF "), "Part 4 title not correct");
            Assert.IsTrue(viewSource.Contains("PART 5 : RELATED REFERENCE DOCUMENTS"), "Part 5 title not correct");
            Assert.IsTrue(viewSource.Contains("PART 6 : NEXT INSPECTION"), "Part 6 title not correct");
            return this;
        }

        public EPM6CPage VerifyPage2Loads()
        {
            //Url contains part=2
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 7 : INSTALLED EMERGENCY LIGHTING SYSTEM "), "Part 7 title not correct");
            Assert.IsTrue(viewSource.Contains("PART 8 : RESULTS OF INSPECTION AND TESTING "), "Part 8 title not correct");
            return this;
        }

        public EPM6CPage VerifyPage3Loads()
        {
            //Url contains part=3
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 8 : RESULTS OF INSPECTION AND TESTING – Continued "), "Part 8 continuation title not correct");
            Assert.IsTrue(viewSource.Contains("PART 9 : TEST INSTRUMENTS USED "), "Part 9 title not correct");
            Assert.IsTrue(viewSource.Contains("PART 10 : ADDITIONAL DETAILS OF DEVIATIONS FROM THE RECOMMENDATIONS OF "), "Part 10 title not correct");
            Assert.IsTrue(viewSource.Contains("PART 11 : DETAILS ON ALTERNATIVE METHOD USED TO VERIFY ILLUMINATION REQUIREMENT"), "Part 11 title not correct");
            return this;
        }

        public EPM6CPage VerifyPageContinuationPageLoads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Add Image(s)"), " Add Image(s) title is not present");
            return this;
        }

        public EPM6CPage VerifyPart1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS OF THE CONTRACTOR"), "Part 1 title is not present");
            return this;
        }
        public EPM6CPage VerifyPart2Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" DETAILS OF THE EMERGENCY LIGHTING INSTALLATION COVERED BY THIS CERTIFICATE"), "Part 2 title is not present");
            return this;
        }
        public EPM6CPage VerifyPart3Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("   CERTIFICATION "), "Part 3 title is not present");
            return this;
        }
        public EPM6CPage VerifyPart4Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("  DETAILS OF DEVIATIONS FROM THE RECOMMENDATIONS OF "), "Part 4 title is not present");
            return this;
        }
        public EPM6CPage VerifyPart5Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("  RELATED REFERENCE DOCUMENTS"), "Part 5 title is not present");
            return this;
        }
        public EPM6CPage VerifyPart6Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("NEXT INSPECTION"), "Part 6 title is not present");
            return this;
        }
        public EPM6CPage VerifyPart7Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=7"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" INSTALLED EMERGENCY LIGHTING SYSTEM "), "Part 7 title is not present");
            return this;
        }
        public EPM6CPage VerifyPart8Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=8"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" RESULTS OF INSPECTION AND TESTING"), "Part 8 title is not present");
            return this;
        }
        public EPM6CPage VerifyPart9Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=9"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("RESULTS OF INSPECTION AND TESTING – Continued"), "Part 9 title is not present");
            return this;
        }
        public EPM6CPage VerifyPart10Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=10"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("  TEST INSTRUMENTS USED "), "Part 10 title is not present");
            return this;
        }
        public EPM6CPage VerifyPart11Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=11"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" DETAILS ON ALTERNATIVE METHOD USED TO VERIFY ILLUMINATION REQUIREMENT "), "Part 11 title is not present");
            return this;
        }
        public EPM6CPage VerifyPart12Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=12"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Images and Notes"), "Part 12 title is not present");
            return this;
        }
        public EPM6CPage VerifyPart13Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=13"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Comments"), "Part 13 title is not present");
            return this;
        }
        public EPM6CPage VerifyPart14Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=14"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Summary & problems"), "Part 14 title is not present");
            return this;
        }
    }
}