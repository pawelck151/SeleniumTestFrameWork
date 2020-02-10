using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StarterForSeleniumAutomation.Tests
{
	[TestClass]
	public class GoogleSearchTest : BaseTest
	{
		private string SText = "Test";

		[TestMethod]
		public void GoogleSearch(string searchText)
		{
			homePage.InputSearchText.SendKeys(SText);
			homePage.GoogleSearchButton.Click();
			Assert.IsTrue(homePage.TextIsVisible(SText), "Search do not work correctly");
		}
	}
}
