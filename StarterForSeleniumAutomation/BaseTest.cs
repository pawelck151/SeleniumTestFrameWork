using StarterForSeleniumAutomation.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using StarterForSeleniumAutomation.Pages;
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

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            testContextInstance = context;
        }

        [TestInitialize]
        protected void LaunchBrowser()
        {
            browserType = ConstantTestProperties.BROWSER_TYPE;
            string driversPath = @"C:\Users\pawel.wojtak\Documents\Projects\SeleniumTestFrameWork\Common\Drivers\chromedriver.exe";

           if (browserType == BrowserType.FireFox)
            {
                FirefoxOptions options = new FirefoxOptions();
                options.SetLoggingPreference(LogType.Browser, LogLevel.Severe);
                this.driver = new FirefoxDriver();
            }
            else if (browserType == BrowserType.Chrome)
            {
                ChromeOptions options = new ChromeOptions();
                options.SetLoggingPreference(LogType.Browser, LogLevel.Severe);
                driver = new ChromeDriver(driversPath, options);

            }
            else if (browserType == BrowserType.IE)
            {
                InternetExplorerOptions options = new InternetExplorerOptions()
                {
                    IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                };
                this.driver = new InternetExplorerDriver(driversPath, options);
            }

            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(ConstantStrings.GetUrl());
            driver.Manage().Logs.GetLog(LogType.Browser);
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
