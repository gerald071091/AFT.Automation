using AFT.Automation.Domain.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;

namespace AFT.Automation.Services
{
    public class PageConfiguration
    {
        /// <summary>
        /// Initialize browser driver i.e chrome, firefox, IE, etc.
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="sites"></param>
        /// <returns></returns>
        protected IWebDriver Current(string browser, string sites)
        {
			try
			{
				DesiredCapabilities capabilities = null;
				TimeSpan defaultTime = TimeSpan.FromSeconds("commandTimeout".GetParsedValueByInt());

				IDictionary<string, Func<string, IWebDriver>> setDriver = new Dictionary<string, Func<string, IWebDriver>>
				{
					{"ie", (string code) =>
						{
							InternetExplorerOptions ieOptions = new InternetExplorerOptions();
							ieOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
							ieOptions.EnablePersistentHover = false;
							ieOptions.PageLoadStrategy = InternetExplorerPageLoadStrategy.Eager;
							ieOptions.RequireWindowFocus = false;
							ieOptions.IgnoreZoomLevel = true;
							ieOptions.EnsureCleanSession = true;
							capabilities = DesiredCapabilities.HtmlUnit();
							capabilities.SetCapability("browserName", "internet explorer");
							capabilities.IsJavaScriptEnabled = true;
							capabilities = ieOptions.ToCapabilities() as DesiredCapabilities;
							return SiteServerHub(code, capabilities, defaultTime);
						}
					},
					{"chrome", (string code) =>
						{
							ChromeOptions chromeOptions = new ChromeOptions();
							chromeOptions.AddArgument("test-type");
							capabilities = DesiredCapabilities.HtmlUnit();
							capabilities.SetCapability("browserName", "chrome");
							capabilities.IsJavaScriptEnabled = true;
							capabilities = chromeOptions.ToCapabilities() as DesiredCapabilities;
							return SiteServerHub(code, capabilities, defaultTime);
						}
					},
					{"firefox", (string code) =>
						{
							capabilities = DesiredCapabilities.HtmlUnit();		
							capabilities.SetCapability("browserName", "firefox");
							capabilities.IsJavaScriptEnabled = true;
							return SiteServerHub(code, capabilities, defaultTime);
						}
					}
				};

				return setDriver[browser](sites);
			}
			catch (WebDriverException ex)
			{
				throw new Exception(string.Format("{0}", ex));
			}
            
		}

        /// <summary>
        /// Allocation of sites session in running selenium servers
        /// </summary>
        /// <param name="sites"></param>
        /// <param name="capabilities"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        private static IWebDriver SiteServerHub(string sites, DesiredCapabilities capabilities, TimeSpan time)
        {
			try
			{
				if (sites.In("template1".GetValue()))
				{
					return new RemoteWebDriver(new Uri("template1Hub".GetValue()), capabilities, time);
				}

				return new RemoteWebDriver(new Uri("template2Hub".GetValue()), capabilities, time);
			}
			catch (WebDriverException ex)
			{
				throw new Exception(string.Format("{0}", ex));
			}
			
        }
    }
}
