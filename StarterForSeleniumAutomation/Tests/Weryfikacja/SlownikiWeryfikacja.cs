using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarterForSeleniumAutomation.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using excel = Microsoft.Office.Interop.Excel;

namespace StarterForSeleniumAutomation.Tests.Slowniki
{
    [TestClass]
    public class SlownikiWeryfikacja : BaseTest
    {


        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            testContextInstance = context;
        }

        [TestInitialize]
        public void TestInitialization()
        {
            LaunchBrowser(ConstantStrings.GetUrl());
        }

        [TestMethod]
        public void TestSlownikiWeryfikacja()
        {
            #region Test Data
            string loginData = "admin";
            string passwordData = "Test123";
            #endregion

            //zalogowanie się na admina
            homePage.Login(loginData, passwordData);
            Thread.Sleep(1000);//Wait 1 sec.
            weryfikacja.WeryfikacjaSlownikiStawkiVat();

        }
        [TestCleanup]
        public void TestCleanup()
        {
            CloseBrowser();
        }
    }
}
