using CertsureAutomationFramework.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace CertsureAutomationFramework.Pages
{
    public class ECN6CPage : BaseCertificatePage  
    {
        [FindsBy(How = How.PartialLinkText, Using = "Next")]
        private IWebElement NextButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "switch")]
        private IWebElement ViewModeCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "view-mode-label")]
        private IWebElement ViewModeLabel { get; set; }
        public ECN6CPage EnableViewMode(ViewMode viewMode)
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
        public ECN6CPage ClickNext()
        {
            NextButton.Click();
            return this;
        }

        public ECN6CPage VerifyPage1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 1 :DETAILS OF THE CONTRACTOR, CLIENT AND INSTALLATION"), "Part 1 title not present");
            Assert.IsTrue(viewSource.Contains("PART 2 : DETAILS OF THE EMERGENCY LIGHTING INSTALLATION COVERED BY THIS CERTIFICATE "), "Part 2 title not present");
            Assert.IsTrue(viewSource.Contains("PART 3: DECLARATION OF CONFORMITY"), "Part 3 title not present");
            Assert.IsTrue(viewSource.Contains("PART 5 : RELATED REFERENCE DOCUMENTS"), "Part 5 title not present");
            return this;
        }

        public ECN6CPage VerifyPage2Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 1 :   DETAILS OF THE CONTRACTOR, CLIENT AND INSTALLATION"), "Part 1 title not present");
            Assert.IsTrue(viewSource.Contains("PART 2 : DETAILS OF THE EMERGENCY LIGHTING INSTALLATION COVERED BY THIS CERTIFICATE "), "Part 2 title not present");
            Assert.IsTrue(viewSource.Contains("PART 3 : DESIGN DECLARATION OF CONFORMITY "), "Part 3 title not present");
            return this;
        }

        public ECN6CPage VerifyPage3Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 3 : DESIGN DECLARATION OF CONFORMITY "), "Part  3 continuation title not present");
            Assert.IsTrue(viewSource.Contains("PART 4 : DETAILS OF DEVIATIONS FROM THE RECOMMENDATIONS OF "), "Part 4 title not present");
            Assert.IsTrue(viewSource.Contains("PART 5 : DESIGN"), "Part 5 title not present");
            return this;
        }

        public ECN6CPage VerifyPage4Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 1 : DETAILS OF THE CONTRACTOR, CLIENT AND INSTALLATION"), "Part 4 url, Part 1 title not present");
            Assert.IsTrue(viewSource.Contains("PART 2 : DETAILS OF THE EMERGENCY LIGHTING INSTALLATION COVERED BY THIS CERTIFICATE "), "Part 4 url part 2 title not present");
            Assert.IsTrue(viewSource.Contains("PART 3 : DESIGN DECLARATION OF CONFORMITY "), "Part 4 url part 3 title not present");
            return this;
        }

        public ECN6CPage VerifyPage5Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 4 : DETAILS OF DEVIATIONS FROM THE RECOMMENDATIONS OF "), "Part 5 url part 4 title not present");
            Assert.IsTrue(viewSource.Contains("PART 5 : INSTALLATION"), "Part 5 url part 5 title not present");
            return this;
        }
        public ECN6CPage VerifyPage6Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 1 :   DETAILS OF THE CONTRACTOR, CLIENT AND INSTALLATION"), "Part 6 url part 1 title not present");
            Assert.IsTrue(viewSource.Contains("PART 2 : DETAILS OF THE EMERGENCY LIGHTING INSTALLATION COVERED BY THIS CERTIFICATE "), "Part 6 url part 2 title not present");
            Assert.IsTrue(viewSource.Contains("PART 3 : VERIFICATION DECLARATION OF CONFORMITY"), "Part 0 url part 3 continue title not present");
            return this;
        }

        public ECN6CPage VerifyPage7Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=7"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 4 : TEST INSTRUMENTS USED "), "Part 7 part 4 title not present");
            Assert.IsTrue(viewSource.Contains("PART 5 : DETAILS OF DEVIATIONS FROM THE RECOMMENDATIONS OF "), "Part 7 part 5 title not present");
            Assert.IsTrue(viewSource.Contains("PART 6 : VERIFICATION"), "Part 7 part 6 title not present");

            return this;
        }

        public ECN6CPage VerifyPageContinuationPageLoads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Add Image(s)"), " Add Image(s) title is not present");
            return this;
        }

        public ECN6CPage VerifyPart1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS OF THE CONTRACTOR"), "Part 1 title is not present");
            return this;
        }

        public ECN6CPage VerifyPart2Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" DECLARATION OF CONFORMITY "), "Part 2 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart3Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("  RELATED REFERENCE DOCUMENTS"), "Part 3 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart4Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS OF THE DESIGNER"), "Part 4 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart5Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DESIGN DECLARATION OF CONFORMITY"), "Part 5 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart6Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DESIGN"), "Part 6 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart7Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=7"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS OF THE CONTRACTOR"), "Part 7 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart8Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=8"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DESIGN DECLARATION OF CONFORMITY"), "Part 8 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart9Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=9"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" INSTALLATION "), "Part 9 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart10Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=10"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS OF THE CONTRACTOR"), "Part 10 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart11Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=11"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("VERIFICATION DECLARATION OF CONFORMITY"), "Part 11 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart12Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=12"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" TEST INSTRUMENTS USED "), "Part 12 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart13Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=13"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("VERIFICATION "), "Part 13 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart14Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=14"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" DETAILS OF THE EMERGENCY LIGHTING INSTALLATION COVERED BY THIS CERTIFICATE"), "Part 14 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart15Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=15"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Details of Deviations from the Recommendations - Form 2 (Design) "), "Part 15 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart16Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=16"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Details of Deviations from the Recommendations - Form 3 (Installation) "), "Part 16 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart17Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=17"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Details of Deviations from the Recommendations - Form 4 (Verification) "), "Part 17 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart18Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=18"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Images and Notes"), "Part 18 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart19Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=19"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Comments"), "Part 19 title is not present");
            return this;
        }
        public ECN6CPage VerifyPart20Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=20"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Summary & problems"), "Part 20 title is not present");
            return this;
        }
    }
}