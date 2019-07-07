using System;
using CertsureAutomationFramework.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace CertsureAutomationFramework.Pages
{
    public class DPN18CPage : BaseCertificatePage
    {
        [FindsBy(How = How.PartialLinkText, Using = "Next")]
        private IWebElement NextButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "switch")]
        private IWebElement ViewModeCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "view-mode-label")]
        private IWebElement ViewModeLabel { get; set; }
        public DPN18CPage EnableViewMode(ViewMode viewMode)
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

        public DPN18CPage VerifyPart3Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SUMMARY OF THE CONDITION OF THE INSTALLATION"), "Part 3 title not present");
            return this;
        }
        public DPN18CPage VerifyPart4Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("DETAILS AND LIMITATIONS OF THE INSPECTION AND TESTING"), "Part 4 title not present");
            return this;
        }
        public DPN18CPage VerifyPart5Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SUPPLY CHARACTERISTICS AND EARTHING ARRANGEMENTS"), "Part 5 title not present");
            return this;
        }
        public DPN18CPage VerifyPart6Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PARTICULARS OF INSTALLATION REFERRED TO IN THE REPORT"), "Part 6 title not present");
            return this;
        }
        public DPN18CPage VerifyPart7Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=7"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED"), "Part 7 title not present");
            return this;
        }
        public DPN18CPage VerifyPart8Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=8"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED"), "Part 8  title not present");
            return this;
        }
        public DPN18CPage VerifyPart9Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=9"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED"), "Part 9 title not present");
            return this;
        }
        public DPN18CPage VerifyPart10Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=10"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED"), "Part 10 title not present");
            return this;
        }
        public DPN18CPage VerifyPart11Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=11"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED"), "Part 11 title not present");
            return this;
        }
        public DPN18CPage VerifyPart12Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=12"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED"), "Part 12 title not present");
            return this;
        }

        public DPN18CPage VerifyPart13Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=13"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("SCHEDULE OF ITEMS INSPECTED"), "Part 13 title not present");
            return this;
        }
        public DPN18CPage VerifyPart14Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=14"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("OBSERVATIONS AND RECOMMENDATIONS FOR ACTIONS TO BE TAKEN"), "Part 14 title not present");
            return this;
        }
        public DPN18CPage VerifyPart15Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=15"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("CIRCUITS DETAILS AND TEST RESULTS"), "Part 15 title not present");
            return this;
        }
        public DPN18CPage VerifyPart16Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=16"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Comments"), "Part 16 title not present");
            return this;
        }
        public DPN18CPage VerifyPart17Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=17"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Images and Notes"), "Part 17 title not present");
            return this;
        }
        public DPN18CPage VerifyPart18Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=18"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Declaration"), "Part 18 title not present");
            return this;
        }
        public DPN18CPage VerifyPart19Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=19"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Summary &amp; problems"), "Part 19 title not present");
            return this;
        }
        public DPN18CPage VerifyPart2Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PURPOSE OF THE REPORT"), "Part 2 title not present");
            return this;
        }

        public DPN18CPage VerifyPart1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Details of the Client"), "Part 1 title not present");
            return this;
        }

        public DPN18CPage ClickNext()
        {
            System.Threading.Thread.Sleep(1000);
            NextButton.Click();
            return this;
        }
        public DPN18CPage SpecialClick()
        {
            var url = driver.Url.Split('=');
            string desurl = (int.Parse(url[2]) + 1).ToString();
            driver.Navigate().GoToUrl(url[0] + "=" + url[1] + "=" + desurl); ;
            return this;
        }
        public DPN18CPage VerifyPage1Loads()
        {
            //Url contains part=1
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 1 : DETAILS OF THE CONTRACTOR AND INSTALLATION"));
            return this;
        }

        public DPN18CPage VerifyPage2Loads()
        {
            //Url contains part=2
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 5 : NEXT INSPECTION"));
            return this;
        }

        public DPN18CPage VerifyPage3Loads()
        {
            //Url contains part=3
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 7 : DETAILS AND LIMITATIONS OF THE INSPECTION AND TESTING"));
            return this;
        }

        public DPN18CPage VerifyPage4Loads()
        {
            //Url contains part=4
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 10 : SCHEDULE OF ITEMS INSPECTED"));
            return this;
        }

        public DPN18CPage VerifyPage5Loads()
        {
            //Url contains part=5
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 10 : SCHEDULE OF ITEMS INSPECTED"));
            return this;
        }

        public DPN18CPage VerifyPage6Loads()
        {
            //Url contains part=6
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 12 : SCHEDULE OF CIRCUIT DETAILS AND TEST RESULTS"));
            return this;
        }
    }
}