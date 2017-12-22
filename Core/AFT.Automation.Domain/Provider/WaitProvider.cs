using AFT.Automation.Domain.Helper;
using AFT.Automation.Domain.Interface.Miscellaneous;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace AFT.Automation.Domain.Provider
{
    public class WaitProvider : IWaitProvider
    {
        private readonly IWebDriver _driver;
        private readonly IWait<IWebDriver> _wait;
        private readonly ICapabilities _capabilities;
		private DefaultWait<IWebElement> _pollingWait;

        public WaitProvider(IWebDriver driver)
        {
            Contract.Requires(driver != null);

            _driver = driver;
            _capabilities = ((RemoteWebDriver)_driver).Capabilities;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds("findTimeout".GetParsedValueByInt()));
        }

        public bool FluentWait(IWebElement element)
        {
			_pollingWait = new DefaultWait<IWebElement>(element);
			_pollingWait.Timeout = TimeSpan.FromSeconds("findTimeout".GetParsedValueByInt());
			_pollingWait.PollingInterval = TimeSpan.FromMilliseconds("pollingTime".GetParsedValueByInt());

            Func<IWebElement, bool> waiter = new Func<IWebElement, bool>((IWebElement e) =>
            {
                if (_driver.PageLoadWait(_capabilities, _wait) && element.ElementVisibility(_wait) 
				&& element.ElementDisplayedOrEnabled(_wait))
                {
                    return true;
                }

                return false;
            });

            return _pollingWait.Until(waiter);
        }

		public bool ExplicitWait(IWebElement element)
        {
			return _wait.Until(page => page.PageLoadWait(_capabilities, _wait) 
                && element.ElementVisibility(_wait) && element.ElementDisplayedOrEnabled(_wait));
        }

		public bool FluentExplicitWait(IWebElement element)
		{
			return _wait.Until(page => page.PageLoadWait(_capabilities, _wait)
				&& element.PollingRefreshWait(page) && element.ElementDisplayedOrEnabled(_wait)
				&& element.ElementVisibility(_wait));
		}

		public IList<bool> ExplicitWait(IList<IWebElement> elements)
        {
            IList<bool> elemState = new List<bool>();

			_wait.Until(page => page.PageLoadWait(_capabilities, _wait));
            foreach (IWebElement e in elements)
            {
				elemState.Add(e.ElementVisibility(_wait) && e.ElementDisplayedOrEnabled(_wait));
			}

			return elemState;  
        }

		public void RawWait()
		{
			Task.Factory.StartNew(() =>
			{
				Task.Delay(TimeSpan.FromSeconds("processBufferTime".GetParsedValueByInt())).Wait();
			}).Wait();
		}

        public void RawWait(IWebElement element)
        {
			//Nuisance process of firefox, still a workaround for now :'(
			string[] opsProcess = {
				"ClickMyAccountLink",
				"ClickDepositLink",
				"ClickQuickDepositCloseButton",
				"ClickDepositNetellerHomePageLink",
				"ProvideRegistrationUsername",
				"ProvideRegistrationPassword",
				"ProvideRegistrationConfirmPassword",
				"ProvideRegistrationFirstName",
				"ProvideRegistrationMiddleName",
				"ProvideRegistrationLastName",
				"ProvideRegistrationEmail",
				"ProvideRegistrationMobileNumber",
				"ProvideRegistrationAddress1",
				"ProvideRegistrationCity",
				"ProvideRegistrationPostalCode",
				"ProvideLoginPassword"
			};

			foreach (var ops in opsProcess)
			{
				if (element.IsProcessingMethod(ops))
				{
					Task.Factory.StartNew(() =>
					{
						Task.Delay(TimeSpan.FromSeconds("processBufferTime".GetParsedValueByInt())).Wait();
					}).Wait();

					return;
				}
			}
        }

        public void LoadWait()
        {
            Task.Factory.StartNew(() =>
            {
                _driver.PageLoadWait(_capabilities, _wait);
            }).Wait();
        }

        public void PageReload()
        {
            Task.Factory.StartNew(() => 
            {
                _driver.Navigate().Refresh();
            })
            .ContinueWith((t) => 
            {
                _driver.PageLoadWait(_capabilities, _wait);
            })
            .ContinueWith((t) => 
            {
                _driver.SwitchTo().Window(_driver.CurrentWindowHandle);
            }).Wait();
        }       
    }
}
