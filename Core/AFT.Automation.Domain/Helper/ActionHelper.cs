using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace AFT.Automation.Domain.Helper
{
    public static class ActionHelper
    {
        private static readonly StringComparer _defaultComparer = StringComparer.InvariantCultureIgnoreCase;
        private static readonly string[] _selected = new[] {"true", "selected"};
        private static readonly string[] _checked = new[] { "true", "checked" };

        /// <summary>
        /// Action Helper that define if the element is selected.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static bool IsSelected(this IWebElement element)
        {
            string attribute = element.GetAttribute("selected");
            return _selected.Contains(attribute, _defaultComparer);
        }

        /// <summary>
        /// Action Helper that define if the element ic checked.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static bool IsChecked(this IWebElement element)
        {
			string attribute = element.GetAttribute("checked");
            return _checked.Contains(attribute, _defaultComparer);
        }

        /// <summary>
        /// Action Helper for setting an elements attributes i.e Masked input fields don't work well with sendkeys.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="driver"></param>
        /// <param name="attributeName"></param>
        /// <param name="value"></param>
        public static void SetAttribute(this IWebElement element, IWebDriver driver, string attributeName, string value)
        {
            IWrapsDriver wrappedElement = element as IWrapsDriver;
            if (wrappedElement == null)
            {
                throw new ArgumentException("element", "Element must wrap a web driver");
            }

            driver = wrappedElement.WrappedDriver;
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            if (js == null)
            {
                throw new ArgumentException("element", "Element must wrap a web driver that supports javascript execution");
            }

            js.ExecuteScript("arguments[0].setAttribute(arguments[1], arguments[2])", element, attributeName, value);
        }

        /// <summary>
        /// Action Helper for parsing the string into other types.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <param name="attributeName"></param>
        /// <returns></returns>
        public static T GetAttributeAsType<T>(this IWebElement element, string attributeName)
        {
            string value = element.GetAttribute(attributeName) ?? string.Empty;
            return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(value);
        }

        /// <summary>
        /// Action Helper for taking a screenshot.
        /// </summary>
        /// <param name="driver"></param>
        public static void TakeScreenShot(this IWebDriver driver)
        {
            try
            {
                Screenshot screenies = ((ITakesScreenshot)driver).GetScreenshot();
				string fileName = string.Format("AFT.Automation.UnitTest_Default_{0}.jpg", DateTime.Now.ToString("s").Replace(":", string.Empty));
				string path = AppDomain.CurrentDomain.BaseDirectory ?? AppDomain.CurrentDomain.RelativeSearchPath;
				screenies.SaveAsFile(Path.Combine(path, fileName), ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
