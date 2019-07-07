using CertsureAutomationFramework.Enum;
using CertsureAutomationFramework.Helpers;
using CertsureAutomationFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CertsureAutomationTest
{
    [TestClass]
    public class OpenInDataModeTest : BaseTest
    {
        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void DPN18C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.DPN);
            ((DPN18CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .ClickNext()
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads()
                .ClickNext()
                .VerifyPart9Loads()
                .ClickNext()
                .VerifyPart10Loads()
                .ClickNext()
                .VerifyPart11Loads()
                .ClickNext()
                .VerifyPart12Loads()
                .ClickNext()
                .VerifyPart13Loads()
                .ClickNext()
                .VerifyPart14Loads()
                .ClickNext()
                .VerifyPart15Loads()
                .ClickNext()
                .VerifyPart16Loads()
                .ClickNext()
                .VerifyPart17Loads()
                .SpecialClick()
                .VerifyPart18Loads()
                .ClickNext()
                .VerifyPart19Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void IMN18C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.IMN);
            var p = ((IMN18CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                 .VerifyPart1Loads()
                 .ClickNext()
                 .VerifyPart2Loads()
                 .ClickNext()
                 .VerifyPart3Loads()
                 .ClickNext()
                 .VerifyPart4Loads()
                 .ClickNext()
                 .VerifyPart5Loads()
                 .ClickNext()
                 .VerifyPart6Loads()
                 .SpecialClick()    
                 .VerifyPart7Loads()
                 .ClickNext()
                 .VerifyPart8Loads();        
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void DCN18C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.DCN);
            ((DCN18CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .ClickNext()
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads()
                .ClickNext()
                .VerifyPart9Loads()
                .ClickNext()
                .VerifyPart10Loads()
                .ClickNext()
                .VerifyPart11Loads()
                .ClickNext()
                .VerifyPart12Loads()
                .ClickNext()
                .VerifyPart13Loads()
                .ClickNext()
                .VerifyPart14Loads()
                .ClickNext()
                .VerifyPart15Loads()
                .ClickNext()
                .VerifyPart16Loads()
                .ClickNext()
                .VerifyPart17Loads()
                .ClickNext()
                .VerifyPart18Loads()
                .SpecialClick()
                .VerifyPart19Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void IPN18C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.IPN);
            ((IPN18CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .ClickNext()
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads()
                .ClickNext()
                .VerifyPart9Loads()
                .ClickNext()
                .VerifyPart10Loads()
                .ClickNext()
                .VerifyPart11Loads()
                .ClickNext()
                .VerifyPart12Loads()
                .ClickNext()
                .VerifyPart13Loads()
                .ClickNext()
                .VerifyPart14Loads()
                .ClickNext()
                .VerifyPart15Loads()
                .ClickNext()
                .VerifyPart16Loads()
                .ClickNext()
                .VerifyPart17Loads()
                .SpecialClick()
                .VerifyPart18Loads()
                .ClickNext()
                .VerifyPart19Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void ICN18C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.ICN);
            ((ICN18CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .ClickNext()
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads()
                .ClickNext()
                .VerifyPart9Loads()
                .ClickNext()
                .VerifyPart10Loads()
                .ClickNext()
                .VerifyPart11Loads()
                .ClickNext()
                .VerifyPart12Loads()
                .ClickNext()
                .VerifyPart13Loads()
                .ClickNext()
                .VerifyPart14Loads()
                .ClickNext()
                .VerifyPart15Loads()
                .ClickNext()
                .VerifyPart16Loads()
                .ClickNext()
                .VerifyPart17Loads()
                .ClickNext()
                .VerifyPart18Loads()
                .SpecialClick()
                .VerifyPart19Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void XNN18C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.XNN);
            ((XNN18CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .SpecialClick() 
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FAM7C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.FAM);
            ((FAM7CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .SpecialClick() 
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FCM7C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.FCM);
            ((FCM7CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .SpecialClick()
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FDM7C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.FDM);
            ((FDM7CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .ClickNext()
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads()
                .ClickNext()
                .VerifyPart9Loads()
                .ClickNext()
                .VerifyPart10Loads()
                .SpecialClick()
                .VerifyPart11Loads()
                .ClickNext()
                .VerifyPart12Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FIN7C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.FIN);
            ((FIN7CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .ClickNext()
                .VerifyPart7Loads()
                .SpecialClick() 
                .VerifyPart8Loads()
                .ClickNext()
                .VerifyPart9Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FMN7C_Data_Mode_Open_Test() 
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.FMN);
            ((FMN7CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .SpecialClick()
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FSM7C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.FSM);
            ((FSM7CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .ClickNext()
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads()
                .ClickNext()
                .VerifyPart9Loads()
                .ClickNext()
                .VerifyPart10Loads()
                .ClickNext()
                .VerifyPart11Loads()
                .ClickNext()
                .VerifyPart12Loads()
                .SpecialClick()
                .VerifyPart13Loads()
                .ClickNext()
                .VerifyPart14Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FVM7C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.FVM);
            ((FVM7CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .SpecialClick()
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void DFHN19C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.DFHN);
            ((DFHN19CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .ClickNext()
                .VerifyPart7Loads()
                .SpecialClick()
                .VerifyPart8Loads()
                .ClickNext()
                .VerifyPart9Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void DVN18C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.DVN);
            ((DVN18CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .ClickNext()
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads()
                .ClickNext()
                .VerifyPart9Loads()
                .ClickNext()
                .VerifyPart10Loads()
                .SpecialClick()
                .VerifyPart11Loads();

        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        [Ignore] //certificate type not present in production
        public void ECN6C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.ECN);
            ((ECN6CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .ClickNext()
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads()
                .ClickNext()
                .VerifyPart9Loads()
                .ClickNext()
                .VerifyPart10Loads()
                .ClickNext()
                .VerifyPart11Loads()
                .ClickNext()
                .VerifyPart12Loads()
                .ClickNext()
                .VerifyPart13Loads()
                .ClickNext()
                .VerifyPart14Loads()
                .ClickNext()
                .VerifyPart15Loads()
                .ClickNext()
                .VerifyPart16Loads()
                .ClickNext()
                .VerifyPart17Loads()
                .ClickNext()
                .VerifyPart18Loads();
                //.ClickNext()
                //.VerifyPart19Loads()
                //.ClickNext()
                //.VerifyPart20Loads()
                //.ClickNext();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        [Ignore] //certificate type not present in production
        public void EPM6C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.EPM);
            ((EPM6CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .ClickNext()
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads()
                .ClickNext()
                .VerifyPart9Loads()
                .ClickNext()
                .VerifyPart10Loads()
                .ClickNext()
                .VerifyPart11Loads()
                .ClickNext()
                .VerifyPart12Loads();
                //.ClickNext()
                //.VerifyPart13Loads()
                //.ClickNext()
                //.VerifyPart14Loads();

        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        [Ignore] //certificate type not present in production
        public void ESN4C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.ESN);
            ((ESN4CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads()
                .ClickNext()
                .VerifyPart5Loads()
                .ClickNext()
                .VerifyPart6Loads()
                .ClickNext()
                .VerifyPart7Loads()
                .ClickNext()
                .VerifyPart8Loads()
                .ClickNext()
                .VerifyPart9Loads();
                //.ClickNext()
                //.VerifyPart10Loads()
                //.ClickNext()
                //.VerifyPart11Loads();
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        [Ignore] //certificate type not present in production
        public void EVM2C_Data_Mode_Open_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            BaseCertificatePage baseCertificatePage = existingCertListPage.SelectACertificateOfType(CertificateType.EVM);
            ((EVM2CPage)baseCertificatePage).EnableViewMode(ViewMode.DataMode)
                .VerifyPart1Loads()
                .ClickNext()
                .VerifyPart2Loads()
                .ClickNext()
                .VerifyPart3Loads()
                .ClickNext()
                .VerifyPart4Loads();
        }

    }
}
