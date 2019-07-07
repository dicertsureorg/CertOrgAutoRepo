using CertsureAutomationFramework.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace CertsureAutomationFramework.Pages
{
    public class IPN18CPage : BaseCertificatePage
    {
        [FindsBy(How = How.PartialLinkText, Using = "Next")]
        private IWebElement NextButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "switch")]
        private IWebElement ViewModeCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "view-mode-label")]
        private IWebElement ViewModeLabel { get; set; }
        public IPN18CPage EnableViewMode(ViewMode viewMode)
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
        public IPN18CPage ClickNext()
        {
            NextButton.Click();
            return this;
        }

        public IPN18CPage SpecialClick()
        {
            var url = driver.Url.Split('=');
            string desurl = (int.Parse(url[2]) + 1).ToString();
            driver.Navigate().GoToUrl(url[0] + "=" + url[1] + "=" + desurl); ;
            return this;
        }

        public IPN18CPage VerifyPage1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 1 : DETAILS OF THE CONTRACTOR AND INSTALLATION"), "Part 1 title not present");
            Assert.IsTrue(viewSource.Contains("PART 2 : PURPOSE OF THE REPORT"), "Part 2 title not present");
            Assert.IsTrue(viewSource.Contains("PART 3 : SUMMARY OF THE CONDITION OF THE INSTALLATION"), "Part 3 title not present");
            Assert.IsTrue(viewSource.Contains("PART 4 : DECLARATION"), "Part 4 title not present");
            return this;
        }

        public IPN18CPage VerifyPage2Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 5 : NEXT INSPECTION"), "Part 5 title is not present");
            Assert.IsTrue(viewSource.Contains("PART 6 : OBSERVATIONS AND RECOMMENDATIONS FOR ACTIONS TO BE TAKEN"), "Part 6 title is not present");
            return this;
        }

        public IPN18CPage VerifyPage3Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 7 : DETAILS AND LIMITATIONS OF THE INSPECTION AND TESTING"), "Part 7 title is not present");
            Assert.IsTrue(viewSource.Contains("PART 8 : SUPPLY CHARACTERISTICS AND EARTHING ARRANGEMENTS"), "Part 8 title is not present");
            Assert.IsTrue(viewSource.Contains("PART 9 : PARTICULARS OF INSTALLATION REFERRED TO IN THIS REPORT"), "Part 9 title is not present");

            return this;
        }

        public IPN18CPage VerifyPage4Loads()
        {
            //Url contains part=4
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 10 : SCHEDULE OF ITEMS INSPECTED"), "Part 10 title is not present");
            return this;
        }

        public IPN18CPage VerifyPage5Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 10 : SCHEDULE OF ITEMS INSPECTED"), "Part 10 continuation title is not present");
            Assert.IsTrue(viewSource.Contains("PART 11 : SCHEDULES AND ADDITIONAL PAGES"), "Part 11 title is not present");
            return this;
        }

        public IPN18CPage VerifyPage6Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 12 : SCHEDULE OF CIRCUIT DETAILS AND TEST RESULTS"), "Part 12 title is not present");
            return this;
        }

        public IPN18CPage VerifyPage7Loads()
        {
            string viewSource = driver.PageSource;
            //Assert.IsTrue(viewSource.Contains("PART 12 : SCHEDULE OF CIRCUIT DETAILS AND TEST RESULTS"), "Part 7 title is not present"); //NOTES in UAT
            return this;
        }

        public IPN18CPage VerifyPage9Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Add Image(s)"), " Add Image(s) title is not present");
            return this;
        }

        public IPN18CPage VerifyPart1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Details of the Client"), "part 1 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart2Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PURPOSE OF THE REPORT"), "part 2 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart3Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SUMMARY OF THE CONDITION OF THE INSTALLATION"), "part 3 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart4Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS AND LIMITATIONS OF THE INSPECTION AND TESTING"), "part 4 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart5Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SUPPLY CHARACTERISTICS AND EARTHING ARRANGEMENTS"), "part 5 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart6Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PARTICULARS OF INSTALLATION REFERRED TO IN THE REPORT"), "part 6 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart7Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=7"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED - continues on next page"), "part 7 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart8Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=8"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED - continues on next page"), "part 8 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart9Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=9"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED - continues on next page"), "part 9 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart10Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=10"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED - continues on next page"), "part 10 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart11Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=11"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED - continues on next page"), "part 11 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart12Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=12"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED - continues on next page"), "part 12 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart13Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=13"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED"), "part 13 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart14Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=14"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("OBSERVATIONS AND RECOMMENDATIONS FOR ACTIONS TO BE TAKEN"), "part 14 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart15Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=15"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("CIRCUITS DETAILS AND TEST RESULTS"), "part 15 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart16Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=16"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Comments"), "part 16 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart17Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=17"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Images and Notes"), "part 17 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart18Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=18"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Declaration"), "part 18 title is not present");
            return this;
        }
        public IPN18CPage VerifyPart19Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=19"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Summary &amp; problems"), "part 19 title is not present");
            return this;
        }

    }
}