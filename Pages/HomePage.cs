using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace StarterForSeleniumAutomation.Pages
{
    public class HomePage
    {
        IWebDriver driver;

        #region IWebelements
        #pragma warning disable 0649

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement InputSearchText { get; set; }

        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement GoogleSearchButton { get; set; }

        #pragma warning restore 0649
        #endregion


        public bool TextIsVisible(string SearchText)
        {
            IList<IWebElement> elements = driver.FindElements(By.XPath(""));
            var result = false;
            foreach (var el in elements)
            {
                if (el.GetAttribute("Text").Contains(SearchText))
                {
                    result = true;
                }
                else result = false;
            }
            return result;
        }
    }
}
