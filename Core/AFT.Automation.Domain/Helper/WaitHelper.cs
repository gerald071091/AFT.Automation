using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;

namespace AFT.Automation.Domain.Helper
{
    public static class WaitHelper
    {
        /// <summary>
        /// Wait Helper for waiting the page to load the dom and api calls.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="capabilities"></param>
        /// <param name="wait"></param>
        /// <returns></returns>
        public static bool PageLoadWait(this IWebDriver driver, ICapabilities capabilities, IWait<IWebDriver> wait)
        {
            Stopwatch timer = new Stopwatch();
            bool state = DomState(driver, capabilities, wait);
            while (!state)
            {
                timer.Start();
                if (state) { timer.Stop(); break; }
                if (Convert.ToInt32(timer.Elapsed.TotalSeconds) == "pageTimeout".GetParsedValueByInt())
                {
                    timer.Stop();
                    throw new TimeoutException("page loading time exceeds default time duration");
                }

                return false;
            }

            return true;
        }

		/// <summary>
		/// Wait Helper for waiting the element to be displayed and enabled
		/// </summary>
		/// <param name="element"></param>
		/// <param name="wait"></param>
		/// <returns></returns>
		public static bool ElementDisplayedAndEnabled(this IWebElement element, IWait<IWebDriver> wait)
		{
			return wait.Until(page => element.Displayed && element.Enabled);
		}

		/// <summary>
		/// Wait Helper for waiting the element to be displayed or enabled
		/// </summary>
		/// <param name="element"></param>
		/// <param name="wait"></param>
		/// <returns></returns>
		public static bool ElementDisplayedOrEnabled(this IWebElement element, IWait<IWebDriver> wait)
		{
			return wait.Until(page => element.Displayed || element.Enabled);
		}

		/// <summary>
		/// Wait Helper for waiting the element to be visible
		/// </summary>
		/// <param name="element"></param>
		/// <param name="wait"></param>
		/// <returns></returns>
		public static bool ElementVisibility(this IWebElement element, IWait<IWebDriver> wait)
		{
			return wait.Until(page => element.Size.Width > 0 && element.Size.Height > 0);
		}

		/// <summary>
		/// This wait will try to find element again and again by refreshing the page until
		/// it finds it or until the final timer runs out
		/// </summary>
		/// <param name="element"></param>
		/// <param name="driver"></param>
		/// <returns></returns>
		public static bool PollingRefreshWait(this IWebElement element, IWebDriver driver)
		{
			Stopwatch timer = new Stopwatch();

			Func<IWebElement, bool> isPresentAndDisplayed = new Func<IWebElement, bool>((a) =>
			{
				try
				{
					return a.Displayed;
				}
				catch (NoSuchElementException)
				{
					return false;
				}
				catch (Exception)
				{
					return false;
				}
			});

			while (timer.Elapsed < TimeSpan.FromSeconds("findTimeout".GetParsedValueByInt()))
			{
				timer.Start();

				if (!isPresentAndDisplayed(element))
				{
					//refresh every 30 seconds
					if (timer.Elapsed.Seconds % "pollingRefreshTime".GetParsedValueByInt() == 0)
					{
						driver.Navigate().Refresh();
					}
				}
				else
				{
					timer.Stop();
					return true;
				}
			}

			return false;
		}

		private static bool DomState(IWebDriver driver, ICapabilities capabilities, IWait<IWebDriver> wait)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            if (capabilities.BrowserName.Equals("Firefox"))
            {
                return (bool)wait.Until(page => js.ExecuteScript("return (document.readyState == 'complete' || (!!window.jQuery && window.jQuery.active == 0))"));
            }
            else
            {
                return (bool)wait.Until(page => js.ExecuteScript("return (document.readyState == 'complete' && window.jQuery.active == 0)"));
            }
        }
    }
}
