using AFT.Automation.Domain.Helper;
using AFT.Automation.Domain.Interface.Miscellaneous;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Reflection;
using OpenQA.Selenium.Interactions;

namespace AFT.Automation.Domain.Provider
{
    public class ActionProvider : IActionProvider
    {
        private readonly IWebDriver _driver;
        private readonly ICapabilities _capabilities;
		private readonly IWaitProvider _wait;
		private readonly Actions _action;

        public ActionProvider(IWebDriver driver)
        {
            Contract.Requires(driver != null);

            _driver = driver;
			_action = new Actions(_driver);
			_wait = new WaitProvider(_driver);
			_capabilities = ((RemoteWebDriver)_driver).Capabilities;
        }

        public void RedirectTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void ClickToElement(IWebElement element)
        {
			try
			{
				///This is just a workaround since this prevent from
				///executing this specific step immediately
				_wait.RawWait(element);

				if (element.IsProcessingMethod("ClickLoginButton")
					|| element.IsProcessingMethod("ClickAcceptModalButton"))
				{
					_wait.ExplicitWait(element);
				}
				else
				{
					_wait.FluentExplicitWait(element);
				}
				
				if (!_capabilities.BrowserName.Equals("Firefox"))
				{
					_action.MoveToElement(element).Click().Build().Perform();
				}
				else
				{
					if (element.IsProcessingMethod("ClickMyAccountLink")
						|| element.IsProcessingMethod("ClickDepositLink")
						|| element.IsProcessingMethod("ClickDepositNetellerHomePageLink")
						|| element.IsProcessingMethod("ClickChangePasswordButton"))
					{
						((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", element);
					}
					else
					{
						element.Click();
					}

				}

			}
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public void ClickToElement(IWebElement firstElement, IWebElement secondElement)
        {
			try
			{
				_wait.RawWait(firstElement);

				_wait.FluentExplicitWait(firstElement);
				if (!_capabilities.BrowserName.Equals("Firefox"))
				{
					_action.MoveToElement(firstElement).Click().Build().Perform();
				}
				else
				{
					firstElement.Click();
				}

				_wait.ExplicitWait(secondElement);
				if (!_capabilities.BrowserName.Equals("Firefox"))
				{
					_action.MoveToElement(secondElement).Click().Build().Perform();
				}
				else
				{
					secondElement.Click();
				}
			}
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}

		}

        public void TypeInputToElement(IWebElement element, string value)
        {
			try
			{
				if (_capabilities.BrowserName.Equals("Firefox"))
				{
					_wait.RawWait(element);
				}

				_wait.FluentExplicitWait(element);
				element.Clear();
				element.SendKeys(value);
			}
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public void ItemSelectionToElement(IList<IWebElement> groupElement, string comparer)
        {
			try
			{
				_wait.ExplicitWait(groupElement);
				foreach (IWebElement e in groupElement)
				{
					if (e.Text.Equals(comparer))
					{
						e.Click();
						return;
					}
				}
			}
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public void ItemSelectionToElement(IWebElement element, IList<IWebElement> groupElement, string comparer)
        {
			try
			{
				ClickToElement(element);

				_wait.ExplicitWait(groupElement);
				foreach (IWebElement e in groupElement)
				{
					if (e.Text.Equals(comparer))
					{
						e.Click();
						return;
					}
				}
			}
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

		public void SwitchToNextWindow()
		{
			string currentHandle = _driver.CurrentWindowHandle;

			///This is just a workaround since this prevent from
			///executing this specific step immediately
			_wait.RawWait();

			foreach (string handle in _driver.WindowHandles)
			{
				if (!handle.Equals(currentHandle))
				{
					_driver.SwitchTo().Window(handle);
				}
			}
		}

		public void SwitchToWindow(Expression<Func<IWebDriver, bool>> predicateExp)
        {
			///This is just a workaround since this prevent from
			///executing this specific step immediately
			_wait.RawWait();

			Func<IWebDriver, bool> predicate = predicateExp.Compile();
            foreach (string handle in _driver.WindowHandles)
            {
                _driver.SwitchTo().Window(handle);
                if (predicate(_driver))
                {
                    return;
                }
            }

            throw new ArgumentException(string.Format("Unable to find window with condition: {0}", predicateExp.Body));
        }

        public void SwitchToDefault()
        {
            string currentHandle = _driver.CurrentWindowHandle;
			string mainPage = null;

            foreach (string handle in _driver.WindowHandles)
            {
                if (handle.Equals(currentHandle))
                {
                    _driver.SwitchTo().Window(handle);
                    _driver.Close();
                }
                else
                {
                    mainPage = handle;
                }
            }

            _driver.SwitchTo().Window(mainPage);
        }

        public void Quit()
        {
            _driver.Quit();
        }

        public string GetCurrentPageTitle()
        {
            _wait.RawWait();
            return _driver.Title;
        }

        public string GetCurrentPageUrl()
        {
            _wait.RawWait();
            return _driver.Url;
        }

		public string GetBrowserUsed()
		{
			return _capabilities.BrowserName;
		}

		public string GetFluentNumericalTextInElement(IWebElement element)
        {
			try
			{
				_wait.ExplicitWait(element);
				string result = Regex.Replace(element.Text, @"[^\d]", string.Empty);

				return result.Trim();
			}
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public string GetNumericalTextInElement(IWebElement element)
        {
            try
            {
                _wait.ExplicitWait(element);
                string result = Regex.Replace(element.Text, @"[^\d]", string.Empty);

                return result.Trim();
            }
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public string GetTextInElement(IWebElement element)
        {
            try
            {
                _wait.ExplicitWait(element);
                return element.Text.Trim();
            }
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public string GetAlphaNumericTextInElement(IWebElement element)
        {            
            try
            {
                _wait.ExplicitWait(element);
				string result = Regex.Replace(element.Text, @"^[\sa - zA - Z0 - 9'\.,-]+$", string.Empty);

                return result.Trim();
            }
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public string GetElementAttribute(IWebElement element, string attribute)
        {
            try
            {
                _wait.ExplicitWait(element);
                return element.GetAttribute(attribute);
            }
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public T GetElementAttributeAsType<T>(IWebElement element, string attribute)
        {
            try
            {
                _wait.ExplicitWait(element);
                return element.GetAttributeAsType<T>(attribute);
            }
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public void SetElementAttribute(IWebElement element, string attribute, string value)
        {

            try
            {
                _wait.ExplicitWait(element);
                element.SetAttribute(_driver, attribute, value);
            }
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public int GetElementCount(IList<IWebElement> groupElement)
        {
            try
            {
                _wait.ExplicitWait(groupElement);
                return groupElement.Count;
            }
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public bool IsElementPresent(IWebElement element)
        {
            try
            {
                return _wait.ExplicitWait(element);
			}
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public bool IsElementPresent(IList<IWebElement> groupElement)
        {
            try
            {
                return !_wait.ExplicitWait(groupElement).Contains(false);
            }
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public bool IsElementChecked(IWebElement element)
        {
            try
            {
                _wait.ExplicitWait(element);
                return element.IsChecked();
            }
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public bool IsElementChecked(IList<IWebElement> groupElement)
        {     
            try
            {
                IList<bool> isElementChecked = new List<bool>();

                _wait.ExplicitWait(groupElement);
                foreach (IWebElement e in groupElement)
                {
                    isElementChecked.Add(e.IsChecked());
                }

                return isElementChecked.Contains(true);

            }
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public bool IsElementSelected(IWebElement element)
        {
            try
            {
                _wait.ExplicitWait(element);
                return element.IsSelected();
            }
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

        public bool IsElementSelected(IList<IWebElement> groupElement)
        {
            try
            {
                IList<bool> isElementSelected = new List<bool>();

                _wait.ExplicitWait(groupElement);
                foreach (IWebElement e in groupElement)
                {
                    isElementSelected.Add(e.IsSelected());
                }

                return isElementSelected.Contains(true);

            }
			catch (Exception ex)
			{
				throw ErrorHandler(ex);
			}
		}

		private Exception ErrorHandler(Exception ex)
		{
			_driver.Quit();

			if (ex is WebDriverException)
			{
				throw new Exception("Element is not visible/displayed or the request to the remote webdriver server has timed out", ex);
			}
			else if (ex is InvalidOperationException)
			{
				throw new Exception("The operation encounter an invalid process", ex);
			}
			else if (ex is TargetInvocationException)
			{
				throw new Exception("The object is not yet bounded and it is invoked by other process", ex);
			}
			else if (ex is TimeoutException)
			{
				throw new Exception("The operation has exceeded the given time for checking the object at runtime", ex);
			}
			else
			{
				throw new Exception(ex.Message);
			}
		}
    }
}
