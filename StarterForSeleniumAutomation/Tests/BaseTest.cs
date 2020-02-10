using StarterForSeleniumAutomation.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using StarterForSeleniumAutomation.Pages;
using StarterForSeleniumAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarterForSeleniumAutomation.Enums;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;


namespace StarterForSeleniumAutomation.Tests
{
    public class BaseTest
    {
        #region Fields
        protected HomePage homePage;
        protected SlownikiDostawcy slownikiDostawcy;
        public static TestContext testContextInstance;
        protected IWebDriver driver;
        protected BrowserType browserType;
        #endregion

        #region Properties
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
		#endregion

		#region Methods

		[TestInitialize]
        protected void LaunchBrowser(string URL)
        {
            this.browserType = ConstantTestProperties.BROWSER_TYPE;
            string driversPath = @"C:\Users\pawel.wojtak\Documents\Projects\Selenium\StarterForSeleniumAutomation\Drivers\chromedriver.exe";
           if (this.browserType == BrowserType.FireFox)
            {
                FirefoxOptions options = new FirefoxOptions();
                options.SetLoggingPreference(LogType.Browser, LogLevel.Severe);
                this.driver = new FirefoxDriver();
            }
            else if (this.browserType == BrowserType.Chrome)
            {
                ChromeOptions options = new ChromeOptions();
                options.SetLoggingPreference(LogType.Browser, LogLevel.Severe);
                this.driver = new ChromeDriver(driversPath, options);

            }
            else if (this.browserType == BrowserType.IE)
            {
                InternetExplorerOptions options = new InternetExplorerOptions()
                {
                    IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                };
                this.driver = new InternetExplorerDriver(driversPath, options);
            }

            this.driver.Manage().Cookies.DeleteAllCookies();
            this.driver.Manage().Window.Maximize();
            this.driver.Navigate().GoToUrl(URL);
            this.driver.Manage().Logs.GetLog(LogType.Browser);

            //Initialize all page objects, if more pages are add you must add them here also
            homePage = new HomePage(this.driver);
            slownikiDostawcy = new SlownikiDostawcy(this.driver);
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            if (testContextInstance.CurrentTestOutcome != UnitTestOutcome.Passed)

            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile(@"<C:\");
            }

            driver.Quit();
        }
		#endregion
	}
}
