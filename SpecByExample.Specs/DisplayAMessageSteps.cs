using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecByExample.Specs
{
	[Binding]
	public class DisplayAMessageSteps
	{
		private string htmlSource;

		[Given(@"the website loads")]
		public void GivenTheWebsiteLoads()
		{
			// assume the website is loaded
		}

		[When(@"A user visits the website")]
		public void WhenAUserVisitsTheWebsite()
		{
			// hit the server and grab html
			this.htmlSource = HtmlScraper.GetHtml("http://localhost:13181/");
		}

		[Then(@"(.*) will be visible")]
		public void ThenWillBeVisible(string theMessage)
		{
			//
			ScenarioContext.Current.Pending();
			Assert.IsTrue(htmlSource.Contains(theMessage), "The message should have been visible");
		}
	}

	public static class HtmlScraper
	{
		public static string GetHtml(string httpLocalhost)
		{
			return ""; //"Hello World";
		}
	}
}
