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
    public class Dostawcy : BaseTest
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
        public void TestSlownikiDostawcy()
        {
            #region Test Data
            string loginData = "admin";
            string passwordData = "Test123";
            #endregion
            //zalogowanie się na admina
            homePage.Login(loginData, passwordData);
            Thread.Sleep(1000);//Wait 1 sec.
            //slownikiDostawcy.DostawcyDodowanie();
            //Thread.Sleep(1000);
            //slownikiDostawcy.DostawcyEdycja();
            //Thread.Sleep(1000);
            //slownikiDostawcy.DostawcyUsuwanie();
            //Thread.Sleep(1000);
            slownikiDostawcy.DostawcyTestLogow();
            Thread.Sleep(1000);
     
        }


        [TestCleanup]
        public void TestCleanup()
        {
            CloseBrowser();
        }
    }
}
