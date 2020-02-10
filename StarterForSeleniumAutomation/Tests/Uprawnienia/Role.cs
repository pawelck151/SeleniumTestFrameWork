using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarterForSeleniumAutomation.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using excel = Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace StarterForSeleniumAutomation.Tests.Uprawnienia
{
    [TestClass]
    public class Role : BaseTest
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
        public void TestUprawnieniaRole()
        {
            #region Test Data
            string loginData = "admin";
            string passwordData = "Test123";
            #endregion

            //zalogowanie się na admina
            homePage.Login(loginData, passwordData);
            Thread.Sleep(1000);//Wait 1 sec.
            //uprawnieniaRole.RoleDodawanie();
            //Thread.Sleep(1000);
            //uprawnieniaRole.RoleEdycja();
            //Thread.Sleep(1000);
            uprawnieniaRole.RoleUsuwanie();
            Thread.Sleep(1000);
        }


        [TestCleanup]
        public void TestCleanup()
        {
            CloseBrowser();
        }


    }
}
