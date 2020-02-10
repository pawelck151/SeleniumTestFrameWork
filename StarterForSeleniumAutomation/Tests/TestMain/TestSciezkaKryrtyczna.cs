using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarterForSeleniumAutomation.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using excel = Microsoft.Office.Interop.Excel;

namespace StarterForSeleniumAutomation.Tests.TestMain
{
    [TestClass]
   public  class TestSciezkaKryrtyczna : BaseTest
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
        public void TESTSciezkaKrytyczna()
        {
            #region Test Data
            string loginData = "admin";
            string passwordData = "Test123";
            #endregion

            ////zalogowanie się na admina
            homePage.Login(loginData, passwordData);
            Thread.Sleep(1000);//Wait 1 sec.

            //Dane Podstawowe
            #region Dane Podstawowe


            ////uprawnienia
            //uprawnieniaRole.RoleDodawanie();
            //Thread.Sleep(1000);
            //uprawnieniaUzytkownicy.UzytkownicyDodawanie();
            //Thread.Sleep(1000);

            ////słowniki
            //slownikiStawkiVat.StawkiVatDodowanie();
            //Thread.Sleep(1000);
            //slownikiWaluty.WalutyDodawanie();
            //Thread.Sleep(1000);
            //slownikiRegiony.RegionyDodawanie();
            //Thread.Sleep(1000);
            //slownikiMapowanieStawekVat.MapowanieStawekVatDodawanie();
            //Thread.Sleep(1000);
            //slownikiGrupyTowarowe.GrupyTowaroweDodawanie();
            //Thread.Sleep(1000);
            //slownikiTrasy.TrasyDodawanie();
            //Thread.Sleep(1000);
            //slownikiDostawcy.DostawcyDodowanie();
            //Thread.Sleep(1000);
            //slownikiTowary.TowaryDodawanie();
            //Thread.Sleep(1000);

            ////Klienci
            //klienciKlienci.KlienciDodawanie();
            //Thread.Sleep(1000);
            //klienciPunktySprzedazy.PsdOgolneDodawanie();
            //Thread.Sleep(1000);
            #endregion

            //Magazyn
            magazynDokumentyPrzyjecia.DodanieReczneDP();
            Thread.Sleep(1000);
            

        }

        [TestCleanup]
        public void TestCleanup()
        {
            CloseBrowser();
        }
    }
}
