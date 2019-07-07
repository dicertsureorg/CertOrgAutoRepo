using System;
using CertsureAutomationFramework.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace CertsureAutomationFramework.Pages
{
    public class ICN18CPage : BaseCertificatePage
    {
        [FindsBy(How = How.PartialLinkText, Using = "Next")]
        private IWebElement NextButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "switch")]
        private IWebElement ViewModeCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "view-mode-label")]
        private IWebElement ViewModeLabel { get; set; }
        public ICN18CPage EnableViewMode(ViewMode viewMode)
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
        public ICN18CPage ClickNext()
        {
            NextButton.Click();
            return this;
        }
        public ICN18CPage SpecialClick()
        {
            var url = driver.Url.Split('=');
            string desurl = (int.Parse(url[2]) + 1).ToString();
            driver.Navigate().GoToUrl(url[0] + "=" + url[1] + "=" + desurl); ;
            return this;
        }
        public ICN18CPage VerifyPage1Loads()
        {
            //Url contains part=1
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 1 : DETAILS OF THE CONTRACTOR, CLIENT AND INSTALLATION"), "Part 1 title not correct");
            Assert.IsTrue(viewSource.Contains("PART 2 : DETAILS OF THE ELECTRICAL WORK COVERED BY THIS INSTALLATION CERTIFICATE"), "Part 2 title not correct");
            Assert.IsTrue(viewSource.Contains("PART 3 : NEXT INSPECTION OF THE ELECTRICAL INSTALLATION"), "Part 3 title not correct");
            Assert.IsTrue(viewSource.Contains("PART 4 : DECLARATION FOR THE ELECTRICAL INSTALLATION WORK"), "Part 4 title not correct");
            return this;
        }

        public ICN18CPage VerifyPage2Loads()
        {
            //Url contains part=2
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 4 : DECLARATION FOR THE ELECTRICAL INSTALLATION WORK"), "Part 4 title not correct");
            Assert.IsTrue(viewSource.Contains("PART 5 : COMMENTS ON THE EXISTING INSTALLATION"), "Part 5 title not correct");
            return this;
        }

        public ICN18CPage VerifyPage3Loads()
        {
            //Url contains part=3
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 6 : DETAILS OF THE ORGANISATION(S) RESPONSIBLE FOR THE ELECTRICAL INSTALLATION"), "Part 6 title not correct");
            Assert.IsTrue(viewSource.Contains("PART 7 : SUPPLY CHARACTERISTICS AND EARTHING ARRANGEMENTS"), "Part 7 title not correct");
            Assert.IsTrue(viewSource.Contains("PART 8 : PARTICULARS OF INSTALLATION REFERRED TO IN THIS CERTIFICATE"), "Part 8 title not correct");
            return this;
        }

        public ICN18CPage VerifyPage4Loads()
        {
            //Url contains part=4
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 9 : SCHEDULE OF ITEMS INSPECTED"), "Part 9 title not correct");
            return this;
        }

        public ICN18CPage VerifyPage5Loads()
        {
            //Url contains part=5
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 9 : SCHEDULE OF ITEMS INSPECTED"), "Part 9 continuation title not correct");
            Assert.IsTrue(viewSource.Contains("PART 10 : SCHEDULES AND ADDITIONAL PAGES"), "Part 10 title not correct");
            return this;
        }

        public ICN18CPage VerifyPage6Loads()
        {
            //Url contains part=6
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 11 : SCHEDULE OF CIRCUIT DETAILS AND TEST RESULTS"));
            return this;
        }
        public ICN18CPage VerifyPart1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Details of the Client"), "Part 1 title not present");
            return this;
        }
        //public ICN18CPage VerifyPart2Loads()
        //{
        //    string viewSource = driver.PageSource;
        //    Assert.IsTrue(viewSource.Contains("Details of the Client"), "Part 2 title not present");
        //    return this;
        //}

        public ICN18CPage VerifyPart2Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" DETAILS OF THE ELECTRICAL WORK COVERED BY THIS INSTALLATION CERTIFICATE"), "Part 2 title not present");
            return this;
        }
        public ICN18CPage VerifyPart3Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains(" NEXT INSPECTION OF THE ELECTRICAL INSTALLATION"), "Part 3 title not present");
            return this;
        }

        public ICN18CPage VerifyPart4Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DECLARATION FOR THE ELECTRICAL INSTALLATION WORK"), "Part 4 title not present");
            return this;
        }
        public ICN18CPage VerifyPart5Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("COMMENTS ON THE EXISTING INSTALLATION"), "Part 5 title not present");
            return this;
        }

        public ICN18CPage VerifyPart6Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS OF THE ORGANISATION(S) RESPONSIBLE FOR THE ELECTRICAL INSTALLATION"), "Part 6 title not present");
            return this;
        }
        public ICN18CPage VerifyPart7Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=7"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SUPPLY CHARACTERISTICS AND EARTHING ARRANGEMENTS"), "Part 7 title not present");
            return this;
        }

        public ICN18CPage VerifyPart8Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=8"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PARTICULARS OF INSTALLATION REFERRED TO IN THE REPORT"), "Part 8 title not present");
            return this;
        }

        public ICN18CPage VerifyPart9Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=9"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED - continues on next page"), "Part 9 title not present");
            return this;
        }

        public ICN18CPage VerifyPart10Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=10"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED - continues on next page"), "Part 10 title not present");
            return this;
        }
        public ICN18CPage VerifyPart11Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=11"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED - continues on next page"), "Part 11 title not present");
            return this;
        }
        public ICN18CPage VerifyPart12Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=12"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED - continues on next page"), "Part 12 title not present");
            return this;
        }
        public ICN18CPage VerifyPart13Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=13"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED - continues on next page"), "Part 13 title not present");
            return this;
        }
        public ICN18CPage VerifyPart14Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=14"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED - continues on next page"), "Part 14 title not present");
            return this;
        }
        public ICN18CPage VerifyPart15Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=15"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED"), "Part 15 title not present");
            return this;
        }
        public ICN18CPage VerifyPart16Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=16"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("CIRCUITS DETAILS AND TEST RESULTS"), "Part 16 title not present");
            return this;
        }
        public ICN18CPage VerifyPart17Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=17"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Comments"), "Part 17 title not present");
            return this;
        }

        public ICN18CPage VerifyPart18Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=18"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Images and Notes"), "Part 18 title not present");
            return this;
        }
        public ICN18CPage VerifyPart19Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=19"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Summary &amp; problems"), "Part 19 title not present");
            return this;
        }
    }
}