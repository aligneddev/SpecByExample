using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace SpecByExample.Specs
{
	public static class HtmlScraper
	{
		public static string GetHtml(string url)
		{
			var request = WebRequest.Create(url);

			// allow check to https even though the cert isn't trusted (message in Chrome that needs to be clicked through as well)
			// http://stackoverflow.com/questions/4492735/webexception-could-not-establish-trust-relationship-for-the-ssl-tls-secure-chann
			ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => true;
			request.Timeout = (int)TimeSpan.FromSeconds(10).TotalMilliseconds;
			using (var reader = new StreamReader(request.GetResponse().GetResponseStream()))
			{
				return reader.ReadToEnd();
			}
		}
	}
}