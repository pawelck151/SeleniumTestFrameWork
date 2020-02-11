using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarterForSeleniumAutomation.Constants;

namespace StarterForSeleniumAutomation.Tests
{
	[TestClass]
	public class GoogleSearchTest : BaseTest
	{
		private string SText = "Test";

		[ClassInitialize]
		public static void ClassInitialize(TestContext context)
		{
			testContextInstance = context;
		}

		[TestInitialize]
		public void TestInitialization()
		{
			LaunchBrowser();
		}


		[TestMethod]
		public void GoogleSearch()
		{
			homePage.InputSearchText.SendKeys(SText);
			homePage.GoogleSearchButton.Click();
			Assert.IsTrue(homePage.TextIsVisible(SText), "Search do not work correctly");
		}

		[TestCleanup]
		public void TestCleanup()
		{
			CloseBrowser();
		}
	}
}
