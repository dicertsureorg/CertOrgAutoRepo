using CertsureAutomationFramework.Enum;
using CertsureAutomationFramework.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace CertsureAutomationFramework.Pages
{
    public class ExistingCertListPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "CriteriaType")]
        private IWebElement FilterCriteriaType { get; set; }

        [FindsBy(How = How.Id, Using = "Is")]
        private IWebElement CertificateTypeIsOrIsNot { get; set; }

        [FindsBy(How = How.Id, Using = "CertificateTypeId")]
        private IWebElement CertificateTypeDropdown { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Create New Certificate")]
        private IWebElement CreateCertificateButton { get; set; }

        [FindsBy(How = How.Id, Using = "filter_execute")]
        private IWebElement FilterCertButton { get; set; }

        [FindsBy(How = How.Id, Using = "search_results")]
        private IWebElement SearchResultDiv { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Existing Certificates")]
        private IWebElement ExistingCertificateButton { get; set; }

        [FindsBy(How = How.Id, Using = "certificate-table-body")]
        private IWebElement CertificateList { get; set; }

        [FindsBy(How = How.Id, Using = "create-new-certificate")]
        private IWebElement CreateNewCertificateButton { get; set; }

        internal IMN18CPage GotoCertificateView(CertificateType type)
        {
            CreateCertificateButton.Click();
            OpenCertificateView(type);
            return NOCSPageHelper.IMN18C;
        }

        private void OpenCertificateView(CertificateType type)
        {
            var listOfTableRow = CertificateList.FindElements(By.CssSelector("tr[data-id]"));
            foreach (var tableRow in listOfTableRow)
            {
                var td = tableRow.FindElement(By.CssSelector("td[data-label='Code:'"));
                var a = td.FindElement(By.TagName("a"));
                var imgSrc = a.GetAttribute("data-prefix");

                if (imgSrc.Contains(type.ToString()))
                {
                    a.Click();
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CreateNewCertificateButton));

                    CreateNewCertificateButton.Click();
                    break;
                }
            }
        }
        public BaseCertificatePage SelectACertificateOfType(CertificateType certificateType) 
        {
            BaseCertificatePage certificatePage = new BaseCertificatePage();
            //Enable this Only in UAT Environment
            //ExistingCertificateButton.Click(); 
            switch (certificateType)
            {
                case CertificateType.DPN:
                {
                        SelectAnyCertificateOfType(certificateType); 
                        certificatePage = NOCSPageHelper.DPN18C;
                        break;
                }
                case CertificateType.IMN:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.IMN18C;
                        break;
                }
                case CertificateType.DCN:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.DCN18C;
                        break;
                }

                case CertificateType.IPN:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.IPN18C;
                        break;
                }

                case CertificateType.ICN:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.ICN18C;
                        break;
                }

                case CertificateType.XNN:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.XNN18C;
                        break;
                }
                case CertificateType.FAM:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.FAM7C;
                        break;
                }
                case CertificateType.FCM:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.FCM7C;
                        break;
                }
                case CertificateType.FDM:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.FDM7C;
                        break;
                }
                case CertificateType.FIN:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.FIN7C;
                        break;
                }
                case CertificateType.FMN:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.FMN7C; 
                        break;
                }
                case CertificateType.FSM:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.FSM7C;
                        break;
                }
                case CertificateType.FVM:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.FVM7C;
                        break;
                }
                case CertificateType.DFHN:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.DFHN19C;
                        break;
                }
                case CertificateType.DVN:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.DVN18C;
                        break;
                }
                case CertificateType.ECN:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.ECN6C;
                        break;
                }

                case CertificateType.EPM:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.EPM6C;
                        break;
                }
                case CertificateType.ESN:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.ESN4C;
                        break;
                }
                case CertificateType.EVM:
                {
                        SelectAnyCertificateOfType(certificateType);
                        certificatePage = NOCSPageHelper.EVM2C;
                        break;
                }
                default:
                    break;
            }

            return certificatePage;
        }

        public bool DownloadPDFCertificateOfType(CertificateType certificateType, TestContext context)
        {
            //Enable this Only in UAT Environment
            //ExistingCertificateButton.Click();
            return DownloadAnyPDFCertificateOfType(certificateType, context);
        }

        private bool DownloadAnyPDFCertificateOfType(CertificateType certificateType, TestContext context)
        {
            FilterBy(Enum.FilterBy.CertificateType);
            CertificateTypeIs(Enum.CertificateTypeIs.Is);
            SelectTypeFromDropdownListOfTypes(certificateType);
            FilterCertButton.Click();
            return DownloadFirstCertificateInList(context); 
        }

        private void SelectAnyCertificateOfType(CertificateType dPN18C)
        {
            FilterBy(Enum.FilterBy.CertificateType);
            CertificateTypeIs(Enum.CertificateTypeIs.Is);
            SelectTypeFromDropdownListOfTypes(dPN18C);
            FilterCertButton.Click();
            SelectFirstUnLockCertificateInList();
            Thread.Sleep(2500);
        }

        private void SelectFirstUnLockCertificateInList()
        {

            Thread.Sleep(3000);
            var listOfTableRow = SearchResultDiv.FindElements(By.CssSelector("tr[id]"));
            foreach (var tableRow in listOfTableRow)
            {
                //System.Threading.Thread.Sleep(4000);
                var td = tableRow.FindElement(By.CssSelector("td[data-label='Details:'"));
                var img = td.FindElement(By.TagName("img"));
                var imgSrc = img.GetAttribute("src");
                
                if (imgSrc.Contains("/images/in_progress_32.png"))
                {
                    var div = td.FindElement(By.TagName("div"));
                    var anchor = div.FindElement(By.TagName("a"));
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    js.ExecuteScript("arguments[0].click()", anchor);
                    break;
                }
            }
        }

        private bool DownloadFirstCertificateInList(TestContext context)
        {
            bool isDownloaded = false;
            DeleteDownloadFolder(context);
            Thread.Sleep(2000);
            var listOfTableRow = SearchResultDiv.FindElements(By.CssSelector("tr[id]"));
            foreach (var tableRow in listOfTableRow)
            {
                var td = tableRow.FindElement(By.CssSelector("td[data-label='Actions:'"));
                var pdfAnchor = td.FindElement(By.CssSelector("a[class='create-pdf-item']"));
                var downloadLink =  pdfAnchor.GetAttribute("href"); 
                driver.Navigate().GoToUrl(downloadLink);
                isDownloaded = DownloadHelper.CheckDownLoadComplete(context);
                break;
            }
            return isDownloaded;
        }

        private void DeleteDownloadFolder(TestContext TestContext)
        {
            if(Directory.Exists(TestContext.Properties["DownloadPath"].ToString()))
            {
                var listOfPdfDownloaded = Directory.GetFiles(TestContext.Properties["DownloadPath"].ToString());
                foreach (var item in listOfPdfDownloaded)
                {
                    File.Delete(item);
                }
            }
        } 

        private ExistingCertListPage SelectTypeFromDropdownListOfTypes(CertificateType dPN18C)
        {
            CertificateTypeDropdown.Click();
            var listOfOptions = CertificateTypeDropdown.FindElements(By.TagName("option"));
            bool isCertificateFound = false;
            foreach (var option in listOfOptions) 
            {
                if (option.Text.Contains(dPN18C.ToString()))
                {
                    isCertificateFound = true;
                    option.Click();
                    break;
                }      
            }

            if (!isCertificateFound)
                throw new Exception("Certificate type now found.");

            return this;
        }

        public ExistingCertListPage FilterBy(FilterBy filterCriteria)
        {
            FilterCriteriaType.Click();
            FilterCriteriaType.FindElement(By.CssSelector(string.Format("option[value = {0}]", filterCriteria))).Click();
            return this;
        }

        public ExistingCertListPage CertificateTypeIs(CertificateTypeIs isOrIsNot)
        {
            string value = string.Empty;
            CertificateTypeIsOrIsNot.Click();
            value = (isOrIsNot == Enum.CertificateTypeIs.Is) ? "True" : "False";
            CertificateTypeIsOrIsNot.FindElement(By.CssSelector(string.Format("option[value = {0}]", value))).Click();
            return this;
        }
    }
}