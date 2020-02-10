using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarterForSeleniumAutomation.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using excel = Microsoft.Office.Interop.Excel;

namespace StarterForSeleniumAutomation.Tests.Uprawnienia
{
    [TestClass]
    public class Uzytkownicy : BaseTest
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
        public void TestUprawnieniaUzytkownicy()
        {
            #region Test Data
            string loginData = "admin";
            string passwordData = "Test123";
            #endregion

            //zalogowanie się na admina
            homePage.Login(loginData, passwordData);
            Thread.Sleep(1000);//Wait 1 sec.
            //uprawnieniaUzytkownicy.UzytkownicyDodawanie();
            //Thread.Sleep(1000);
            uprawnieniaUzytkownicy.UzytkownicyEdycja();
            Thread.Sleep(1000);
            uprawnieniaUzytkownicy.UzytkownicyUsuwanie();
            Thread.Sleep(1000);
            uprawnieniaUzytkownicy.UzytkownicyDezaktywacja();
            Thread.Sleep(1000);
            uprawnieniaUzytkownicy.UzytkownicyAktywacja();
            Thread.Sleep(1000);

        }

        [TestCleanup]
        public void TestCleanup()
        {
            CloseBrowser();
        }
    }
}
