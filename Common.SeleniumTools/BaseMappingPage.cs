using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Remote;

namespace Common.SeleniumTools
{
	/// <summary>
	/// A possible internal NuGet package for base functionality layered on Selenium.
	/// </summary>
	public class BaseMappingPage
	{
		protected readonly RemoteWebDriver driver;

		public BaseMappingPage(RemoteWebDriver driver)
		{
			this.driver = driver;
		}
	}
}