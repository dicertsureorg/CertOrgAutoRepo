using System;
using CertsureAutomationFramework.Enum;
using CertsureAutomationFramework.Helpers;
using CertsureAutomationFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CertsureAutomationTest
{
    [TestClass]
    public class CreateIMNCertificateTest : BaseTest   
    {
        [TestMethod]
        [TestCategory("Smoke")]
        public void CreateIMNCertificate()
        {
            NOCSPageHelper.LoginPage
                .LoginAsAdmin(TestContext)
                .CreateCertificateType(CertificateType.IMN)
                .ForClient("Nana Shen")
                .WithAddress(10, "MK5 6JH")
                .WithClientPhoneNumber(07423569845)
                .ForOccupier("Victor Smith")
                .WithOccupierAddress(14, "MK5 6JH")
                .WithOccupierPhoneNumber(01908525635)
                .DescriptionOfMinorWork("The description of work to be done")
                .DateCompleted("24/06/2019")
                .SystemTypeAndEarthingArrangements("TT")
                .ConsumerUnitSupplyingBoard("2")
                .EarthingConductor("LIM")
                .ProtectiveBondingConductorToWater("NA")
                .Gas("LIM")
                .Oil("NA")
                .Other("coment")
                .CommentOnExistingInstallation("Comment on existing installation")
                .CircuitDescriptionAndRefNo("123456")
                .DBCURefNo("456")
                .LocationAndType("loc")
                .OverCurrentProtectionDevice_BS_EN("BS 5419 Isolator")
                .CircuitDetailsRating("10")
                .CSAOfConductorLive("0.5")
                .MmSquaredCPC("0.75")
                .EngineerSignedDate("26/07/2019")
                .NameOfEngineer("Paul")
                .SupervisorSignedDate("26/07/2019")
                .NameOfSupervisor("John Ed")
                .AddTestInstrument()

                .AddContinuity("1", "1")
                .AddRingFinalCircuit("1", "1", "1")
                .AddInsullationResistance("1", "1", "15")

                .CompleteCertificate()
                .EmailPdfToCustomer(true)
                .Finalized();
   


        }


    }
}
