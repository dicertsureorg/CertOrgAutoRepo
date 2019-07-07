using System;
using CertsureAutomationFramework.Enum;
using CertsureAutomationFramework.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace CertsureAutomationFramework.Pages
{
    public class IMN18CPage : BaseCertificatePage
    {

        #region 
        
       [FindsBy(How = How.Id, Using = "Imn18TestResult_ContinuityR1R2")]
        private IWebElement ProtectiveConductor { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18TestResult_ContinuityR2")]
        private IWebElement ProtectiveConductorOR { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18TestResult_InsulationLiveLive")]
        private IWebElement RingFinalCircuitLL { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18TestResult_LoopNeutral")]
        private IWebElement RingFinalCircuitNN { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18TestResult_LoopCpc")]
        private IWebElement RingFinalCircuitCPC { get; set; }
        
        [FindsBy(How = How.Id, Using = "Imn18TestResult_InsulationLiveLive")]
        private IWebElement InsulationResistanceLL { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18TestResult_InsulationLiveEarth")]
        private IWebElement InsulationResistanceLE { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18TestResult_TestVoltage")]
        private IWebElement InsulationResistanceTestVolt { get; set; }




        [FindsBy(How = How.Id, Using = "postcode-to-search")]
        private IWebElement PostCodeToSearch { get; set; }

        [FindsBy(How = How.Id, Using = "lookup-address")]
        private IWebElement FindAddressButton { get; set; }

        [FindsBy(How = How.Id, Using = "address-dropdown")]
        private IWebElement AddressDropdown { get; set; }

        public IMN18CPage AddRingFinalCircuit(string v1, string v2, string v3)
        {
            RingFinalCircuitLL.SendKeys(v1);
            RingFinalCircuitNN.SendKeys(v2);
            RingFinalCircuitCPC.SendKeys(v3);

            return this;
        }

        public IMN18CPage AddInsullationResistance(string v1, string v2, string v3)
        {
            InsulationResistanceLL.SendKeys(v1);
            InsulationResistanceLE.SendKeys(v2);
            InsulationResistanceTestVolt.SendKeys(v3);
            return this;
        }

        public IMN18CPage AddContinuity(string v1, string v2)
        {
            ProtectiveConductor.SendKeys(v1);
            ProtectiveConductorOR.SendKeys(v2);
            return this;
        }

        [FindsBy(How = How.Id, Using = "select-address")]
        private IWebElement SelectAddress { get; set; }

        [FindsBy(How = How.Id, Using = "client-telephone")]
        private IWebElement ClientTelephone { get; set; }

        [FindsBy(How = How.Id, Using = "client-name")]
        private IWebElement ClientNameField { get; set; }

        [FindsBy(How = How.Id, Using = "installation-occupier")]
        private IWebElement OccupierNameField { get; set; }

        [FindsBy(How = How.Id, Using = "installation-telephone")]
        private IWebElement OccupierTelephoneNumber { get; set; }
        [FindsBy(How = How.PartialLinkText, Using = "Next")]
        private IWebElement NextButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "switch")]
        private IWebElement ViewModeCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "view-mode-label")]
        private IWebElement ViewModeLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-certificate-form\"]/div[3]/div/div/div/div/div/div[2]/button")]
        private IWebElement FindAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-certificate-form\"]/div[3]/div/div/div/div/div/div[3]/button")]
        private IWebElement FindInstallationAddress { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Detail_MinorWorksDescriptionComment")]
        private IWebElement DescriptionInputField { get; set; }

        [FindsBy(How = How.Id, Using = "date-completed")]
        private IWebElement DateCompletedInputField { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Detail_ZsFinalCircuit")]
        private IWebElement ConsumerUnitSupplyingBoardInputField { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Detail_EarthConductorVerifiedType-verified")]
        private IWebElement EarthConductorVerifiedTypeInputField { get; set; }
        
        [FindsBy(How = How.Id, Using = "Imn18Detail_BondingWaterInstallationVerifiedType-verified")]
        private IWebElement ProtectiveBondingWaterConductorVerifiedTypeInputField { get; set; }

        [FindsBy(How = How.ClassName, Using = "me-signature")]
        private IWebElement MeEngineerSignedDateInputField { get; set; }

        [FindsBy(How = How.Id, Using = "complete-certifcate")]
        private IWebElement CompleteCertifcate { get; set; }

        [FindsBy(How = How.Id, Using = "test-instruments-table")]
        private IWebElement TestInstrumentsTable { get; set; }
        
        [FindsBy(How = How.ClassName, Using = "certifyName")]
        private IWebElement EngineerNameInputField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[class=\"\"]")]
        private IWebElement SupervisorDiv { get; set; }

        [FindsBy(How = How.Id, Using = "position-signature-b304c629-8eab-4a7c-81bb-a80700279257")]
        private IWebElement EngineerPositionInputField { get; set; }

        [FindsBy(How = How.ClassName, Using = "ui-segment")]
        private IWebElement EarthConductorVerifiedTypePopUp { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Detail_BondingWaterInstallationVerifiedType-verified-popup")]
        private IWebElement ProtectiveBondingWaterPopup { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Detail_BondingGasInstallationVerifiedType-verified")]
        private IWebElement GasInputField { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Detail_BondingGasInstallationVerifiedType-verified-popup")]
        private IWebElement ProtectiveBondingGasPopup { get; set; } 

        [FindsBy(How = How.Id, Using = "Imn18Detail_BondingOilInstallationVerifiedType-verified-popup")]
        private IWebElement ProtectiveBondingOilPopup { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Detail_BondingOilInstallationVerifiedType-verified")]
        private IWebElement OilInputField { get; set; } 

        [FindsBy(How = How.Id, Using = "Imn18Detail_BondingOther")]
        private IWebElement DetailsMinorWorkOthers { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Detail_ExistingInstallationComment")]
        private IWebElement CommentOnExistingInstallationField { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Detail_SystemAndEarthTypeId")]
        private IWebElement SystemTypeAndEarthingDrpdown { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Circuit_DescriptionRefNo")]
        private IWebElement CircuitDescriptionRefNoInputField { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Circuit_DbCuRefNo")]
        private IWebElement Circuit_DbCuRefNo { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Circuit_LocationType")]
        private IWebElement Circuit_LocationTypeInputField { get; set; }

        [FindsBy(How = How.Id, Using = "protective-device-type")]
        private IWebElement ProtectiveDeviceTypeInputField { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Circuit_CurrentRatingId")]
        private IWebElement Circuit_CurrentRatingInputField { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Circuit_LiveCableConductorSizeId")]
        private IWebElement CircuitLiveCableConductorSizeInputField { get; set; }

        [FindsBy(How = How.Id, Using = "Imn18Circuit_CpcCableConductorSizeId")]
        private IWebElement CircuitCpcCableConductorSizeInputField { get; set; }
    #endregion

        public IMN18CPage NameOfSupervisor(string name)
        {
            var div1 = SupervisorDiv.FindElement(By.CssSelector("div[class=\"name-signature-wrap\"]"));
            var input = div1.FindElement(By.TagName("input"));
            input.Clear();
            input.SendKeys(name);
            return this;
        }

        public IMN18CPage SupervisorSignedDate(string name)
        {
            var div = driver.FindElement(By.CssSelector("div[class=\"\"]"));
            var list = div.FindElements(By.TagName("button"));
            foreach (var item in list)
            {
                if (item.Text == "Me")
                {
                    System.Threading.Thread.Sleep(2000);
                    item.Click();
                    break;
                }
            }
            return this;
        }

        public IMN18CPage EngineerSignedDate(string date)
        {
            MeEngineerSignedDateInputField.Click();
            return this;
        }

        public IMN18CPage PositionOfEngineer(string position)
        {
            EngineerPositionInputField.Clear();
            EngineerPositionInputField.SendKeys(position);
            return this;
        }
        public IMN18CPage NameOfEngineer(string engineerName)
        {

            EngineerNameInputField.Clear();
            EngineerNameInputField.SendKeys(engineerName);
            return this;
        }

        public IMN18CSummaryPage CompleteCertificate()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("complete-certifcate")));
            CompleteCertifcate.Click();
            return NOCSPageHelper.IMN18CSummaryPage;
        }

        public IMN18CPage AddTestInstrument()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[data-number='1'"))).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("test-instruments-table_length"))).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("test-instruments-table_length")));
            var el = driver.FindElement(By.Name("test-instruments-table_length"));
            wait.Until(ExpectedConditions.ElementToBeClickable(el.FindElement(By.CssSelector("option[value = '100']")))).Click();

            var listOfTr = wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("tr[id]")));

            System.Threading.Thread.Sleep(3000);
            foreach (var item in listOfTr)
            {
                if (item.Text.Contains("123") && item.Text.Contains("45") && item.Text.Contains("NaMe") && item.Text.Contains("Other"))
                {
                    item.FindElement(By.TagName("input")).Click();
                    break;
                }
            }
            return this;
        }

        public IMN18CPage SystemTypeAndEarthingArrangements(string systemType)
        {
            SystemTypeAndEarthingDrpdown.Click();
            var options = SystemTypeAndEarthingDrpdown.FindElements(By.TagName("option"));
            foreach (IWebElement item in options)
            {
                if (item.Text == systemType)
                {
                    item.Click();
                    break;
                }  
            }
            return this;
        }

        /// <summary>
        /// Please only enter values as describe.
        /// If adequate earthing conductor enter "Tick". 
        /// If not applicable enter "NA", 
        /// Else enter "LIM"
        /// </summary>
        /// <param name="verifyConductorType"></param>
        /// <returns></returns>
        public IMN18CPage EarthingConductor(string verifyConductorType) 
        {
            EarthConductorVerifiedTypeInputField.Click();
            EarthConductorVerifiedTypePopUp.FindElement(By.CssSelector(string.Format("span[value=\"{0}\"]", verifyConductorType))).Click();
            return this;
        }

        public IMN18CPage Oil(string verifyConductorType)
        {
            OilInputField.Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementToBeClickable(ProtectiveBondingOilPopup.FindElement(By.CssSelector(string.Format("span[value=\"{0}\"]", verifyConductorType)))));
            ProtectiveBondingOilPopup.FindElement(By.CssSelector(string.Format("span[value=\"{0}\"]", verifyConductorType))).Click();
            return this;
        }

        public IMN18CPage CommentOnExistingInstallation(string comment)
        {
            CommentOnExistingInstallationField.Clear();
            CommentOnExistingInstallationField.SendKeys(comment);
            return this;
        }

        public IMN18CPage DBCURefNo(string dBCURefNo)
        {
            Circuit_DbCuRefNo.Clear();
            Circuit_DbCuRefNo.SendKeys(dBCURefNo);
            return this;
        }

        public IMN18CPage CSAOfConductorLive(string conductorSize)
        {
            CircuitLiveCableConductorSizeInputField.Click();
            var options = CircuitLiveCableConductorSizeInputField.FindElements(By.TagName("option"));
            foreach (IWebElement item in options)
            {
                if (item.Text == conductorSize)
                {
                    item.Click();
                    break;
                }
            }
            return this;
        }

        public IMN18CPage MmSquaredCPC(string cpcSize)
        {
            CircuitCpcCableConductorSizeInputField.Click();
            var options = CircuitCpcCableConductorSizeInputField.FindElements(By.TagName("option"));
            foreach (IWebElement item in options)
            {
                if (item.Text == cpcSize)
                {
                    item.Click();
                    break;
                }
            }
            return this;
        }

        public IMN18CPage CircuitDetailsRating(string rating)
        {
            Circuit_CurrentRatingInputField.Click();
            var options = Circuit_CurrentRatingInputField.FindElements(By.TagName("option"));
            foreach (IWebElement item in options)
            {
                if (item.Text == rating)
                {
                    item.Click();
                    break;
                }
            }
            return this;
        }

        public IMN18CPage OverCurrentProtectionDevice_BS_EN(string protectiveDeviceType)
        {
            ProtectiveDeviceTypeInputField.Click();
            var options = ProtectiveDeviceTypeInputField.FindElements(By.TagName("option"));
            foreach (IWebElement item in options)
            {
                if (item.Text == protectiveDeviceType)
                {
                    item.Click();
                    break;
                }
            }
            return this;
        }

        public IMN18CPage LocationAndType(string locationAndType)
        {
            Circuit_LocationTypeInputField.Clear();
            Circuit_LocationTypeInputField.SendKeys(locationAndType);
            return this;
        }

        public IMN18CPage CircuitDescriptionAndRefNo(string circuitDescriptionAndRefNo)
        {
            CircuitDescriptionRefNoInputField.Clear();
            CircuitDescriptionRefNoInputField.SendKeys(circuitDescriptionAndRefNo);
            return this;
        }

        public IMN18CPage Other(string comment)
        {
            DetailsMinorWorkOthers.Clear();
            DetailsMinorWorkOthers.SendKeys(comment);
            return this;
        }

        public IMN18CPage Gas(string verifyConductorType)
        {
            GasInputField.Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementToBeClickable(ProtectiveBondingGasPopup.FindElement(By.CssSelector(string.Format("span[value=\"{0}\"]", verifyConductorType)))));
            ProtectiveBondingGasPopup.FindElement(By.CssSelector(string.Format("span[value=\"{0}\"]", verifyConductorType))).Click();
            return this;
        }

        public IMN18CPage ProtectiveBondingConductorToWater(string verifyConductorType)
        {
            ProtectiveBondingWaterConductorVerifiedTypeInputField.Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementToBeClickable(ProtectiveBondingWaterPopup.FindElement(By.CssSelector(string.Format("span[value=\"{0}\"]", verifyConductorType)))));
            ProtectiveBondingWaterPopup.FindElement(By.CssSelector(string.Format("span[value=\"{0}\"]", verifyConductorType))).Click();
            return this;
        }

        public IMN18CPage ConsumerUnitSupplyingBoard(string consumerUnit)
        {
            ConsumerUnitSupplyingBoardInputField.Clear();
            ConsumerUnitSupplyingBoardInputField.SendKeys(consumerUnit);
            return this;
        }

        public IMN18CPage DateCompleted(string DateCompleted)
        {
            DateCompletedInputField.Clear();
            DateCompletedInputField.SendKeys(DateCompleted);
            return this;
        }

        public IMN18CPage DescriptionOfMinorWork(string description)
        {
            DescriptionInputField.Clear();
            DescriptionInputField.SendKeys(description);
            return this;
        }

        public IMN18CPage WithAddress(int houseNumber, string postCode)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            var FindAddress = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main-certificate-form\"]/div[3]/div/div/div/div/div/div[2]/button")));
            FindAddress.Click();
            var PostCodeToSearch = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("postcode-to-search")));
            PostCodeToSearch.Clear();
            PostCodeToSearch.SendKeys(postCode);
            var FindAddressButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("lookup-address")));
            FindAddressButton.Click();;
            var AddressDropdown = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("address-dropdown")));
            AddressDropdown.Click();
            AddressDropdown.FindElement(By.CssSelector(string.Format("option[value^= '{0}']", houseNumber))).Click();
            SelectAddress.Click();
            return this;
        }

        public IMN18CPage WithOccupierAddress(int houseNumber, string postCode)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));       
            var FindInstallationAddress = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main-certificate-form\"]/div[3]/div/div/div/div/div/div[3]/button")));
            FindInstallationAddress.Click();
            var PostCodeToSearch = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("postcode-to-search")));
            PostCodeToSearch.Clear();
            PostCodeToSearch.SendKeys(postCode);
            var FindAddressButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("lookup-address")));
            FindAddressButton.Click();
            var AddressDropdown = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("address-dropdown")));
            AddressDropdown.Click();
            AddressDropdown.FindElement(By.CssSelector(string.Format("option[value^= '{0}']", houseNumber))).Click();
            SelectAddress.Click();
            return this;
        }

        public IMN18CPage WithOccupierPhoneNumber(long occupierNumber)
        {
            OccupierTelephoneNumber.Clear();
            OccupierTelephoneNumber.SendKeys(occupierNumber.ToString());
            return this;
        }

        public IMN18CPage WithClientPhoneNumber(long clientPhoneNumber) 
        {
            ClientTelephone.Clear();
            ClientTelephone.SendKeys(clientPhoneNumber.ToString());
            return this;
        }

        public IMN18CPage ForOccupier(string occupierName)
        {
            OccupierNameField.Clear();
            OccupierNameField.SendKeys(occupierName);
            return this;
        }
        public IMN18CPage ForClient(string clientName) 
        {
            ClientNameField.Clear();
            ClientNameField.SendKeys(clientName);
            return this;
        }

        public IMN18CPage EnableViewMode(ViewMode viewMode)
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

        public IMN18CPage ClickNext()
        {
            NextButton.Click();
            return this;
        }

        public IMN18CPage SpecialClick()
        {
            var url = driver.Url.Split('=');
            string  desurl = (int.Parse(url[2]) + 1).ToString();
            driver.Navigate().GoToUrl(url[0] +"=" + url[1] + "=" + desurl);;
            return this;
        }

        public IMN18CPage VerifyPage1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("PART 1 : DETAILS OF THE CONTRACTOR, CLIENT AND THE INSTALLATION"), "Part 1 title not present");
            Assert.IsTrue(viewSource.Contains("PART 2 : DETAILS OF THE MINOR WORKS, SUPPLY CHARACTERISTICS AND EARTHING ARRANGEMENTS"), "Part 2 title not present");
            Assert.IsTrue(viewSource.Contains("PART 3 : CIRCUIT DETAILS"), "Part 3 title not present");
            Assert.IsTrue(viewSource.Contains("PART 4 : TEST RESULTS FOR THE CIRCUIT ALTERED OR EXTENDED"), "Part 4 title not present");
            Assert.IsTrue(viewSource.Contains("PART 5 : DECLARATION"), "Part 5 title not present");
            return this;
        }

        public IMN18CPage VerifyPageContinuationPageLoads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Add Image(s)"), " Add Image(s) title is not present");
            return this;
        }

        public IMN18CPage VerifyPart1Loads()
        {
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Details of the Client"), "part 1 title is not present");
            return this;
        }
        public IMN18CPage VerifyPart2Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=2"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Details of the Minor Works, Supply Characteristics and Earthing Arrangements"), "part 2 title is not present");
            return this;
        }

        public IMN18CPage VerifyPart3Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=3"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Circuit Details"), "part 3 title is not present");
            return this;
        }

        public IMN18CPage VerifyPart4Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=4"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("TEST RESULTS FOR THE CIRCUIT ALTERED OR EXTENDED "), "part 4 title is not present");
            return this;
        }
        public IMN18CPage VerifyPart5Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=5"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Declaration"), "part 5 title is not present");
            return this;
        }
        public IMN18CPage VerifyPart6Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=6"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Images and Notes"), "part 6 title is not present");
            return this;
        }
        public IMN18CPage VerifyPart7Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=7"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Attach Comments"), "part 7 title is not present");
            return this;
        }
        public IMN18CPage VerifyPart8Loads()
        {
            Assert.IsTrue(driver.Url.Contains("&part=8"));
            string viewSource = driver.PageSource;
            Assert.IsTrue(viewSource.Contains("Summary &amp; problems"), "part 8 title is not present");
            return this;
        }
    }
}