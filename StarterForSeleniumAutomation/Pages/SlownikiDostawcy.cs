using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using StarterForSeleniumAutomation.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace StarterForSeleniumAutomation.Pages
{
    public class SlownikiDostawcy : Page
    {
        #region IWebelements
#pragma warning disable 0649
        //slowniki -> dostawcy
        private IWebElement slownikiBTN;
        private IWebElement slownikiDostawcyBTN;
        //panel przycisków
        private IWebElement dostawcyDodajBTN;
        private IWebElement dostawcyEdytujBTN;
        private IWebElement dostawcyUsunBTN;
        private IWebElement dostawcyPrzegladajBTN;
        //filtry
        private IWebElement filtrNazwa;
        private IWebElement szukajBTN;
        private IWebElement pokazFiltryBTN;
        //edytor
        private IWebElement dostawcaIdentyfikatorObcy;
        private IWebElement dostawcaNazwa;
        private IWebElement dostawcaUlica;
        private IWebElement dostawcaKodPocztowy;
        private IWebElement dostawcaMiejscowosc;
        private IWebElement dostawcaNip;
        private IWebElement dostawcaRegon;
        private IWebElement dostawcaOpis;
        private IWebElement dostawcaZapiszBTN;
        private IWebElement dostawcaAnulujBTN;
        //dane
        private int i = 0;
        private string[] identyfikatorObcy =
        {
            "117",
            "264",
            "222",
            "133",
            "194",
            "240",
            "235",
            "288",
            "106",
            "148",
            "200",
            "235",
            "295",
            "295",
            "160",
            "244",
            "176",
            "202",
            "185",
            "270",
            "150",
            "211",
            "182",
            "208",
            "136",
            "218",
            "120",
            "136",
            "218",
            "120"

        };
        private string[] nazwa =
        {
            "Dostawca001",
            "Dostawca002",
            "Dostawca003",
            "Dostawca004",
            "Dostawca005",
            "Dostawca006",
            "Dostawca007",
            "Dostawca008",
            "Dostawca009",
            "Dostawca010",
            "Dostawca011",
            "Dostawca012",
            "Dostawca013",
            "Dostawca014",
            "Dostawca015",
            "Dostawca016",
            "Dostawca017",
            "Dostawca018",
            "Dostawca019",
            "Dostawca020",
            "Dostawca021",
            "Dostawca022",
            "Dostawca023",
            "Dostawca024",
            "Dostawca025",
            "Dostawca026",
            "Dostawca027",
            "Dostawca028",
            "Dostawca029",
            "Dostawca030"


        };
        private string[] ulica =
        {
            "Ulica001",
            "Ulica002",
            "Ulica003",
            "Ulica004",
            "Ulica005",
            "Ulica006",
            "Ulica007",
            "Ulica008",
            "Ulica009",
            "Ulica010",
            "Ulica011",
            "Ulica012",
            "Ulica013",
            "Ulica014",
            "Ulica015",
            "Ulica016",
            "Ulica017",
            "Ulica018",
            "Ulica019",
            "Ulica020",
            "Ulica021",
            "Ulica022",
            "Ulica023",
            "Ulica024",
            "Ulica025",
            "Ulica026",
            "Ulica027",
            "Ulica028",
            "Ulica029",
            "Ulica030"

        };
        private string[] kodPocztowy =
        {
            "85057",
            "1922",
            "31651",
            "71831",
            "Z9C 5G3",
            "C8G 6P2",
            "71809",
            "E7U 4H5",
            "E8Q 5W5",
            "38959",
            "85401",
            "F1E 2I3",
            "16171",
            "P8W 5K5",
            "24412",
            "R7I 8V5",
            "7136",
            "A8B 3D6",
            "A2M 5Y7",
            "38255",
            "93742",
            "24187",
            "P8J 7L4",
            "59246",
            "V6N 4C4",
            "M2V 7Y0",
            "B8Y 2L7",
            "12097",
            "12640",
            "X5J 4V8"

        };
        private string[] miejscowosc =
        {
            "Miejscowość001",
            "Miejscowość002",
            "Miejscowość003",
            "Miejscowość004",
            "Miejscowość005",
            "Miejscowość006",
            "Miejscowość007",
            "Miejscowość008",
            "Miejscowość009",
            "Miejscowość010",
            "Miejscowość011",
            "Miejscowość012",
            "Miejscowość013",
            "Miejscowość014",
            "Miejscowość015",
            "Miejscowość016",
            "Miejscowość017",
            "Miejscowość018",
            "Miejscowość019",
            "Miejscowość020",
            "Miejscowość021",
            "Miejscowość022",
            "Miejscowość023",
            "Miejscowość024",
            "Miejscowość025",
            "Miejscowość026",
            "Miejscowość027",
            "Miejscowość028",
            "Miejscowość029",
            "Miejscowość030"

        };
        private string[] nip =
        {
            "6094799018",
            "5388482763",
            "6950266219",
            "7661884853",
            "5951112025",
            "5512524583",
            "7182005176",
            "7793855223",
            "9555824556",
            "5007446022",
            "4026212085",
            "2209504461",
            "6868866623",
            "4342732304",
            "1478961577",
            "4800540578",
            "4218881772",
            "2990260096",
            "7130870759",
            "1283646930",
            "6665617914",
            "7819067980",
            "3472120061",
            "5844840234",
            "3188704986",
            "6675160585",
            "8888425679",
            "1633546742",
            "5214321274",
            "4657845650"


        };
        private string[] regon =
        {
            "19661894",
            "65851501",
            "63785452",
            "81702892",
            "95713589",
            "98145154",
            "57128105",
            "34327340",
            "58824160",
            "71549177",
            "22065821",
            "59305416",
            "48785205",
            "44395396",
            "61635444",
            "42354703",
            "66319287",
            "29517723",
            "49873748",
            "81875147",
            "46620340",
            "23215054",
            "75985762",
            "52992559",
            "70916982",
            "95723825",
            "93103506",
            "37510264",
            "31546924",
            "91237531"

        };
        private string[] opis =
        {
            "Opis001",
            "Opis002",
            "Opis003",
            "Opis004",
            "Opis005",
            "Opis006",
            "Opis007",
            "Opis008",
            "Opis009",
            "Opis010",
            "Opis011",
            "Opis012",
            "Opis013",
            "Opis014",
            "Opis015",
            "Opis016",
            "Opis017",
            "Opis018",
            "Opis019",
            "Opis020",
            "Opis021",
            "Opis022",
            "Opis023",
            "Opis024",
            "Opis025",
            "Opis026",
            "Opis027",
            "Opis028",
            "Opis029",
            "Opis030"

        };

#pragma warning restore 0649
        #endregion

        public SlownikiDostawcy(IWebDriver browser) : base(browser)
        { }

        public void DostawcyDodowanie()
        {
            slownikiBTN = driver.FindElement(By.Id("k-panelbar-item-slownikiGroup"));
            slownikiBTN.Click();
            Thread.Sleep(1000);
            slownikiDostawcyBTN = driver.FindElement(By.Id("k-panelbar-item-/slowniki/dostawcy"));
            slownikiDostawcyBTN.Click();

            Console.WriteLine(i);
            //dodawanie dostawcy
            while (i<30)
            {
                dostawcyDodajBTN = driver.FindElement(By.XPath("html/body/app-root/div/div/div[2]/app/infover-grid/kendo-grid/kendo-grid-toolbar/button[2]"));
                dostawcyDodajBTN.Click();
                Thread.Sleep(200);
                //uzupełnianie danych
                dostawcaIdentyfikatorObcy = driver.FindElement(By.Name("identyfikatorObcy"));
                dostawcaIdentyfikatorObcy.SendKeys(identyfikatorObcy[i]);
                dostawcaNazwa = driver.FindElement(By.XPath("html/body/app-root/div/div/kendo-dialog/div[2]/div/app/div/div/div/form/div[2]/div/label/input"));
                dostawcaNazwa.SendKeys(nazwa[i]);
                dostawcaUlica = driver.FindElement(By.Name("ulica"));
                dostawcaUlica.SendKeys(ulica[i]);
                dostawcaKodPocztowy = driver.FindElement(By.Name("kodPocztowy"));
                dostawcaKodPocztowy.SendKeys(kodPocztowy[i]);
                dostawcaMiejscowosc = driver.FindElement(By.Name("miejscowosc"));
                dostawcaMiejscowosc.SendKeys(miejscowosc[i]);
                dostawcaNip = driver.FindElement(By.Name("nip"));
                dostawcaNip.SendKeys(nip[i]);
                dostawcaRegon = driver.FindElement(By.Name("regon"));
                dostawcaRegon.SendKeys(regon[i]);
                dostawcaOpis = driver.FindElement(By.Name("uwagi"));
                dostawcaOpis.SendKeys(opis[i]);
                //zapis danych
                dostawcaZapiszBTN = driver.FindElement(By.XPath("html/body/app-root/div/div/kendo-dialog/div[2]/kendo-dialog-actions/button[1]"));
                dostawcaZapiszBTN.Click();
                Thread.Sleep(200);
                Console.WriteLine(i + "," + identyfikatorObcy[i] + "," + nazwa[i] + "," + ulica[i] + "," + kodPocztowy[i] + "," + miejscowosc[i] + "," + nip[i] + "," + regon[i] + "," + opis[i]);

                i = i + 1;

    }

}

        public void DostawcyEdycja()
        {

        }

        public void DostawcyUsuwanie()
        {

        }

        public void DostawcyTestLogow()
        {
            slownikiBTN = driver.FindElement(By.Id("k-panelbar-item-slownikiGroup"));
            slownikiBTN.Click();
            Thread.Sleep(1000);
            slownikiDostawcyBTN = driver.FindElement(By.Id("k-panelbar-item-/slowniki/dostawcy"));
            slownikiDostawcyBTN.Click();
            Thread.Sleep(555);
            //przycisk pokaz filtry
            pokazFiltryBTN = driver.FindElement(By.XPath("html/body/app-root/div/div/div[2]/app/infover-grid/kendo-grid/kendo-grid-toolbar/div/button[1]"));
            pokazFiltryBTN.Click();

            List<LogEntry> logs = driver.Manage().Logs.GetLog(LogType.Browser).ToList();
            foreach (LogEntry log in logs)
            {
                if (log != null)
                {
                    Console.WriteLine(log.Message);
                    Console.WriteLine("Błąd w konsoli w metodzie " + "DostawcyTestLogow");
                    driver.Quit();
                }
            }

        }
        


        public override void NavigateToPage(string parameter = "")
        {
            this.driver.Navigate().GoToUrl(ConstantStrings.GetUrl());
        }


    }
}
