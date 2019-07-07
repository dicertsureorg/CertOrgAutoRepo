using CertsureAutomationFramework.Enum;
using CertsureAutomationFramework.Helpers;
using CertsureAutomationFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CertsureAutomationTest
{
    [TestClass]
    public class DownloadCertificateInPDFModeTest : BaseTest   
    {
        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void DPN18C_Certificate_Pdf_Download_Test() 
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.DPN, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.DPN));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void IMN18C_Certificate_Pdf_Download_Test() 
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);
            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.IMN, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.IMN));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void DCN18C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.DCN, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.DCN));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void IPN18C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.IPN, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.IPN));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void ICN18C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.ICN, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.ICN));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void XNN18C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.XNN, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.XNN));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FAM7C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.FAM, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.FAM));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FCM7C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.FCM, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.FCM));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FDM7C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.FDM, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.FDM));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FIN7C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.FIN, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.FIN));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FMN7C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.FMN, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.FMN));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FSM7C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.FSM, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.FSM));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void FVM7C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.FVM, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.FVM));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void DFHN19C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.DFHN, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.DFHN));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        public void DVN18C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.DVN, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.DVN));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        [Ignore] //certificate type not present in production
        public void ECN6C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.ECN, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.ECN));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        [Ignore] //certificate type not present in production
        public void EPM6C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.EPM, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.EPM));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        [Ignore] //certificate type not present in production
        public void ESN4C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.ESN, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.ESN));
        }

        [TestMethod]
        [TestCategory("PostProductionRelease")]
        [Ignore] //certificate type not present in production
        public void EVM2C_Certificate_Pdf_Download_Test()
        {
            ExistingCertListPage existingCertListPage = NOCSPageHelper.LoginPage.LoginAsAdmin(TestContext)
                                                                      .VerifyLogOutButtonIsPresent()
                                                                      .Goto18EdExistingCertListPage(TestContext);

            Assert.IsTrue(existingCertListPage.DownloadPDFCertificateOfType(CertificateType.EVM, TestContext), string.Format("Certificate of type {0} can not be downloaded", CertificateType.EVM));
        }

    }
}
