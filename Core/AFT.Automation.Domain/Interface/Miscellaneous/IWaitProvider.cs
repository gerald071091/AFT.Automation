using OpenQA.Selenium;
using System.Collections.Generic;

namespace AFT.Automation.Domain.Interface.Miscellaneous
{
    public interface IWaitProvider
    {
        /// <summary>
        /// This wait will try to find element again and again until it finds it or until
        /// the final timer runs out
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        bool FluentWait(IWebElement element);

        /// <summary>
        /// This wait will try to find the element until the final timer runs out
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        bool ExplicitWait(IWebElement element);

		/// <summary>
		/// This wait will try to find the element again and again with polling for 
		/// a certain amount of time instead it will refresh the page for the specified
		/// time when the element is not present in DOM. Though this concept is a combination
		/// of Explicit and Implicit wait.
		/// </summary>
		/// <param name="element"></param>
		/// <returns></returns>
		bool FluentExplicitWait(IWebElement element);

		/// <summary>
		/// This wait will try to wait for the group set of elements
		/// </summary>
		/// <param name="elements"></param>
		/// <returns></returns>
		IList<bool> ExplicitWait(IList<IWebElement> elements);

		/// <summary>
		/// This wait will Provide a raw delay time before proceeding to another process
		/// </summary>
		void RawWait();

		/// <summary>
		/// This wait will Provide a raw delay time to specific process before proceeding to another process
		/// </summary>
		/// <param name="element"></param>
		void RawWait(IWebElement element);

		/// <summary>
		/// This wait will Provide a delay time based on page load and any other api calls
		/// </summary>
		void LoadWait();

        /// <summary>
        /// This will refresh the page and wait until the page load the DOM
        /// </summary>
        void PageReload();

    }
}
