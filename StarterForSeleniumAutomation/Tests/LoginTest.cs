using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarterForSeleniumAutomation.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StarterForSeleniumAutomation.Tests
{
    [TestClass]
    public class LoginTest : BaseTest
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
        public void TestLogowania()
        {
            #region Test Data
            string loginData = "admin";
            string passwordData = "Test123";
            #endregion

            //uzupełenienie danych do logowania           
            homePage.Login(loginData, passwordData);         
            Thread.Sleep(3000);//Wait 3 sec.

            
        }

        [TestCleanup]
        public void TestCleanup()
        {
            CloseBrowser();
        }
    }
}
