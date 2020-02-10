using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using StarterForSeleniumAutomation.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterForSeleniumAutomation.Pages
{
    public class HomePage : Page
    {
        #region IWebelements
        #pragma warning disable 0649
	    private IWebElement inputFieldLogin;
        private IWebElement inpuFIeldPassowrd;
        private IWebElement submmitButton;
        #pragma warning restore 0649
        #endregion

        /// <summary>
        /// Call the base class constructor
        /// </summary>
        /// <param name="browser"></param>
        public HomePage(IWebDriver browser) : base(browser)
        { }


        public void Login(string login, string password)
        {
            inputFieldLogin = driver.FindElement(By.Name("login"));
            inputFieldLogin.SendKeys(login);
            inpuFIeldPassowrd = driver.FindElement(By.Name("password"));
            inpuFIeldPassowrd.SendKeys(password);
            submmitButton = driver.FindElement(By.XPath("//div/form/div[2]/button"));
            submmitButton.Click();

            /*
            //screenshot
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenCapture = screenshotDriver.GetScreenshot();
            screenCapture.SaveAsFile(@"C:\Users\Paweł W\Pictures\Sypress\Screens" + "\\" + "wrongUserNameAndPassword.png", ScreenshotImageFormat.Png);
            */
        }

        public override void NavigateToPage(string parameter = "")
        {
            this.driver.Navigate().GoToUrl(ConstantStrings.GetUrl());
        }



    }
}
