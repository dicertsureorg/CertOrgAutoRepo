using CertsureAutomationFramework.Enum;
using CertsureAutomationFramework.Helpers;
using CertsureAutomationFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CertsureAutomationTest
{
    [TestClass]
    public class OpenInCertificateModeTest : BaseTest   
    {
        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void DPN18C_Certificate_Mode_Open_Test() 
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.DPN);
            ((DPN18CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext() 
                .VerifyPage2Loads()
                .ClickNext()
                .VerifyPage3Loads()
                .ClickNext()
                .VerifyPage4Loads()
                .ClickNext()
                .VerifyPage5Loads()
                .ClickNext()
                .VerifyPage6Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void IMN18C_Certificate_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.IMN);
            ((IMN18CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPageContinuationPageLoads();

        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void DCN18C_Certificate_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.DCN);
            ((DCN18CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPage2Loads()
                .ClickNext()
                .VerifyPage3Loads()
                .ClickNext()
                .VerifyPage4Loads()
                .ClickNext()
                .VerifyPage5Loads();

        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void IPN18C_Certificate_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.IPN);
            ((IPN18CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPage2Loads()
                .ClickNext()
                .VerifyPage3Loads()
                .ClickNext()
                .VerifyPage4Loads()
                .ClickNext()
                .VerifyPage5Loads()
                .ClickNext()
                .VerifyPage6Loads()
                .ClickNext()
                .VerifyPage7Loads()
                .ClickNext()
                .VerifyPage9Loads();



        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void ICN18C_Certificate_Mode_Open_Test()  
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.ICN);
            ((ICN18CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPage2Loads()
                .ClickNext()
                .VerifyPage3Loads()
                .ClickNext()
                .VerifyPage4Loads()
                .ClickNext()
                .VerifyPage5Loads()
                .ClickNext()
                .VerifyPage6Loads()
                .ClickNext();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void XNN18C_Certificate_Mode_Open_Test() 
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.XNN);
            ((XNN18CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPageContinuationPageLoads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FAM7C_Certificate_Mode_Open_Test() 
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.FAM);
            ((FAM7CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPageContinuationPageLoads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FCM7C_Certificate_Mode_Open_Test() 
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.FCM);
            ((FCM7CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPage2Loads()
                .ClickNext()
                .VerifyPageContinuationPageLoads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FDM7C_Certificate_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.FDM);
            ((FDM7CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPage2Loads()
                .ClickNext()
                .VerifyPageContinuationPageLoads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FIN7C_Certificate_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.FIN);
            ((FIN7CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPage2Loads()
                .ClickNext()
                .VerifyPageContinuationPageLoads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FMN7C_Certificate_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.FMN);
            ((FMN7CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPageContinuationPageLoads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FSM7C_Certificate_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.FSM);
            ((FSM7CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPage2Loads()
                .ClickNext()
                .VerifyPage3Loads()
                .ClickNext()
                .VerifyPage4Loads()
                .ClickNext()
                .VerifyPage5Loads()
                .ClickNext()
                .VerifyPageContinuationPageLoads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FVM7C_Certificate_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.FVM);
            ((FVM7CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPageContinuationPageLoads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void DFHN19C_Certificate_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.DFHN);
            ((DFHN19CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPage2Loads()
                .ClickNext()
                .VerifyPageContinuationPageLoads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void DVN18C_Certificate_Mode_Open_Test() 
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.DVN);
            ((DVN18CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPage2Loads()
                .ClickNext()
                .VerifyPageContinuationPageLoads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        [Ignore] //certificate type not present in production
        public void ECN6C_Certificate_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.ECN);
            ((ECN6CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPage2Loads()
                .ClickNext()
                .VerifyPage3Loads()
                .ClickNext()
                .VerifyPage4Loads()
                .ClickNext()
                .VerifyPage5Loads()
                .ClickNext()
                .VerifyPage6Loads()
                .ClickNext()
                .VerifyPage7Loads()
                .ClickNext()
                .VerifyPageContinuationPageLoads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        [Ignore] //certificate type not present in production
        public void EPM6C_Certificate_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.EPM);
            ((EPM6CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
            .VerifyPage2Loads()
            .ClickNext()
            .VerifyPage3Loads()
            .ClickNext()
            .VerifyPageContinuationPageLoads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        [Ignore] //certificate type not present in production
        public void ESN4C_Certificate_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.ESN);
            ((ESN4CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
            .VerifyPage2Loads()
            .ClickNext()
            .VerifyPage3Loads()
            .ClickNext()
            .VerifyPageContinuationPageLoads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        [Ignore] //certificate type not present in production
        public void EVM2C_Certificate_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.EVM);
            ((EVM2CPage)baseCertificatePage).EnableViewMode(ViewMode.CertificateMode)
                .VerifyPage1Loads()
                .ClickNext()
                .VerifyPage2Loads()
                .ClickNext()
                .VerifyPage3Loads()
                .ClickNext()
                .VerifyPageContinuationPageLoads();
        }

    }
}
