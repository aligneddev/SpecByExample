using System;
using System.Collections.Generic;
using System.Linq;
using Common.SeleniumTools;
using OpenQA.Selenium.Remote;

namespace SpecByExample.UiAutomation
{
	/// <summary>
	/// UI Mapping for the home Page.
	/// </summary>
    public class HomePage : BaseMappingPage
    {
		public HomePage(RemoteWebDriver driver) : base(driver)
		{
		}
    }
}
