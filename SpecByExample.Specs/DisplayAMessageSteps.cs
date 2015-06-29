using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecResults;
using SpecResults.WebApp;
using TechTalk.SpecFlow;

namespace SpecByExample.Specs
{
	[Binding]
	public class DisplayAMessageSteps : ReportingStepDefinitions
	{
		[BeforeTestRun]
		public static void BeforeTestRun()
		{
			Reporters.Add(new WebAppReporter());

			Reporters.FinishedReport += (sender, args) =>
			{
				var reporter = args.Reporter as WebAppReporter;
				if (reporter != null)
				{
					reporter.WriteToFolder(@"C:\temp", true);
				}
			};
		}
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
			Assert.IsTrue(htmlSource.Contains(theMessage), "The message should have been visible");
		}
	}
}
