using CertsureAutomationFramework.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace CertsureAutomationFramework.Pages
{
    public class FSM7CPage : BaseCertificatePage  
    {
        [FindsBy(How = How.PartialLinkText, Using = "Next")]
        private IWebElement NextButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "switch")]
        private IWebElement ViewModeCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "view-mode-label")]
        private IWebElement ViewModeLabel { get; set; }
        public FSM7CPage EnableViewMode(ViewMode viewMode)
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
        public FSM7CPage ClickNext()
        {
            NextButton.Click();
            return this;
        }
        public FSM7CPage SpecialClick()
        {
            var url = driver.Url.Split('=');
            string desurl = (int.Parse(url[2]) + 1).ToString();
            driver.Navigate().GoToUrl(url[0] + "=" + url[1] + "=" + desurl); ;
            return this;
        }
        public FSM7CPage VerifyPage1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 1 : DETAILS OF THE CONTRACTOR, CLIENT AND INSTALLATION"), "Part 1 title not present");
            Assert.IsTrue(viewSource.Contains("PART 2 : DETAILS OF THE FIRE DETECTION AND FIRE ALARM SYSTEM COVERED BY THIS REPORT"), "Part 2 title not present");
            Assert.IsTrue(viewSource.Contains("PART 3 : DETAILS OF THE EXTENT OF THE INSTALLATION AND LIMITATIONS OF THE INSPECTION COVERED BY THIS REPORT"), "Part 3 title not present");
            Assert.IsTrue(viewSource.Contains("PART 4 : CERTIFICATION OF INSPECTION AND SERVICING "), "Part 4 title not present");
            return this;
        }

        public FSM7CPage VerifyPage2Loads()
        { 
            //Part 2 url
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 5 : OBSERVATIONS AND RECOMMENDATIONS FOR ACTIONS TO BE TAKEN"), "Part 5 title not present");
            Assert.IsTrue(viewSource.Contains("PART 6 : SUMMARY OF INSPECTION AND SERVICING"), "Part 6 title not present");
            Assert.IsTrue(viewSource.Contains("PART 7 : NEXT INSPECTION AND SERVICING"), "Part 7 title not present");
            return this;
        }

        public FSM7CPage VerifyPage3Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 8 : RELATED REFERENCE DOCUMENTS"), "Part 5 title not present");
            Assert.IsTrue(viewSource.Contains("PART 9 : QUARTERLY INSPECTION OF VENTED BATTERIES"), "Part 9 title not present");
            Assert.IsTrue(viewSource.Contains("PART 10 : TASKS TO BE INCLUDED IN A PERIODIC INSPECTION AND TEST OF THE SYSTEM"), "Part 10 title not present");
            return this;
        }

        public FSM7CPage VerifyPage4Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 10 : TASKS TO BE INCLUDED IN A PERIODIC INSPECTION AND TEST OF THE SYSTEM"), "Part 10 title not present");
            Assert.IsTrue(viewSource.Contains("PART 11 : TASKS TO BE INCLUDED IN A PERIODIC INSPECTION AND TEST OF THE SYSTEM OVER A TWELVE MONTH PERIOD"), "Part 11 title not present");
            return this;
        }

        public FSM7CPage VerifyPage5Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 11 : TASKS TO BE INCLUDED IN A PERIODIC INSPECTION AND TEST OF THE SYSTEM OVER A TWELVE MONTH PERIOD – "), "Part 11 continuation title not present");
            Assert.IsTrue(viewSource.Contains("PART 12 : ADDITIONAL CHECKS FOR A SPECIAL INSPECTION ON APPOINTMENT OF A NEW SERVICING ORGANISATION"), "Part 12 title not present");
            return this;
        }

        public FSM7CPage VerifyPageContinuationPageLoads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Add Image(s)"), " Add Image(s) title is not present");
            return this;
        }

        public FSM7CPage VerifyPart1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS OF THE CONTRACTOR"), "Part 11 title is not present");
            return this;
        }
        public FSM7CPage VerifyPart2Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("  DETAILS OF THE FIRE DETECTION AND FIRE ALARM SYSTEM COVERED BY THIS REPORT"), "Part 2 title is not present");
            return this;
        }
        public FSM7CPage VerifyPart3Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS OF THE EXTENT OF THE INSTALLATION AND LIMITATIONS OF THE INSPECTION COVERED BY THIS REPORT"), "Part 3 title is not present");
            return this;
        }
        public FSM7CPage VerifyPart4Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("   CERTIFICATION OF INSPECTION AND SERVICING "), "Part 4 title is not present");
            return this;
        }
        public FSM7CPage VerifyPart5Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("OBSERVATIONS AND RECOMMENDATIONS FOR ACTIONS TO BE TAKEN"), "Part 5 title is not present");
            return this;
        }
        public FSM7CPage VerifyPart6Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SUMMARY OF INSPECTION AND SERVICING "), "Part 6 title is not present");
            return this;
        }
        public FSM7CPage VerifyPart7Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=7"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("  RELATED REFERENCE DOCUMENTS"), "Part 7 title is not present");
            return this;
        }
        public FSM7CPage VerifyPart8Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=8"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("QUARTERLY INSPECTION OF VENTED BATTERIES"), "Part 8 title is not present");
            return this;
        }
        public FSM7CPage VerifyPart9Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=9"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("TASKS TO BE INCLUDED IN A PERIODIC INSPECTION AND TEST OF THE SYSTEM"), "Part 9 title is not present");
            return this;
        }
        public FSM7CPage VerifyPart10Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=10"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("TASKS TO BE INCLUDED IN A PERIODIC INSPECTION AND TEST OF THE SYSTEM OVER A TWELVE MONTH PERIOD"), "Part 10 title is not present");
            return this;
        }
        public FSM7CPage VerifyPart11Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=11"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("ADDITIONAL CHECKS FOR A SPECIAL INSPECTION ON APPOINTMENT OF A NEW SERVICING ORGANISATION"), "Part 11 title is not present");
            return this;
        }
        public FSM7CPage VerifyPart12Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=12"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Images and Notes"), "Part 12 title is not present");
            return this;
        }

        public FSM7CPage VerifyPart13Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=13"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Comments"), "Part 13 title is not present");
            return this;
        }
        public FSM7CPage VerifyPart14Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=14"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Summary &amp; problems"), "Part 14 title is not present");
            return this;
        }
    }
}