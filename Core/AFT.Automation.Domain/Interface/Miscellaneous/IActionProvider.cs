using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AFT.Automation.Domain.Interface.Miscellaneous
{
    public interface IActionProvider
    {
        /// <summary>
        /// Action that redirect to a certain site
        /// </summary>
        /// <param name="url"></param>
        void RedirectTo(string url);

        /// <summary>
        /// Action that click the target element
        /// </summary>
        /// <param name="element"></param>
        void ClickToElement(IWebElement element);

        /// <summary>
        /// Action that clicks the first element to provide clicking action to the consecutive element
        /// </summary>
        /// <param name="firstElement"></param>
        /// <param name="secondElement"></param>
        /// <param name="wait"></param>
        void ClickToElement(IWebElement firstElement, IWebElement secondElement);

        /// <summary>
        /// Action that type the provided value to element
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        void TypeInputToElement(IWebElement element, string value);

        /// <summary>
        /// Action that select the item in element selection/option
        /// </summary>
        /// <param name="groupElement"></param>
        /// <param name="comparer"></param>
        void ItemSelectionToElement(IList<IWebElement> groupElement, string comparer);

        /// <summary>
        /// Action that click and select the item in element selection/option
        /// </summary>
        /// <param name="element"></param>
        /// <param name="groupElement"></param>
        /// <param name="comparer"></param>
        void ItemSelectionToElement(IWebElement element, IList<IWebElement> groupElement, string comparer);

		/// <summary>
		/// Action SwitchToNextWindow that provide the new tab action
		/// </summary>
		void SwitchToNextWindow();

        /// <summary>
        /// Action SwitchToWindow that provide the new tab action with new link using the title of the page
        /// </summary>
        /// <param name="predicateExp"></param>
        void SwitchToWindow(Expression<Func<IWebDriver, bool>> predicateExp);

        /// <summary>
        /// Action SwitchToDefault that redirect the current session to main page.
        /// </summary>
        void SwitchToDefault();

        /// <summary>
        /// Action Quit that ends the driver browser and it's session
        /// </summary>
        void Quit();

        /// <summary>
        /// Get the current tab page title
        /// </summary>
        /// <returns></returns>
        string GetCurrentPageTitle();

        /// <summary>
        /// Get the current page url
        /// </summary>
        /// <returns></returns>
        string GetCurrentPageUrl();

		/// <summary>
		/// Get the current browser used
		/// </summary>
		/// <returns></returns>
		string GetBrowserUsed();

        /// <summary>
        /// Action GetFluentNumericalText that returns only the numerical text
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        string GetFluentNumericalTextInElement(IWebElement element);

        /// <summary>
        /// Action GetNumericalText that returns only the numerical text
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        string GetNumericalTextInElement(IWebElement element);

        /// <summary>
        /// Action GetText that returns the text
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        string GetTextInElement(IWebElement element);

        /// <summary>
        /// Action GetAlphaNumericText that returns only the alpha text
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        string GetAlphaNumericTextInElement(IWebElement element);

        /// <summary>
        /// Action GetElementAttribute that returns the specified attribute value
        /// </summary>
        /// <param name="element"></param>
        /// <param name="wait"></param>
        /// <returns></returns>
        string GetElementAttribute(IWebElement element, string attribute);

        /// <summary>
        /// Action GetElementAttributeAsType that returns the attribute value into parse type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="attribute"></param>
        /// <param name="wait"></param>
        /// <returns></returns>
        T GetElementAttributeAsType<T>(IWebElement element, string attribute);

        /// <summary>
        /// Action SetElementAttribute that sets the value of an element attribute if not provided
        /// </summary>
        /// <param name="element"></param>
        /// <param name="attribute"></param>
        /// <param name="value"></param>
        /// <param name="wait"></param>
        void SetElementAttribute(IWebElement element, string attribute, string value);

        /// <summary>
        /// Action GetElementCount that returns the count of list element
        /// </summary>
        /// <param name="groupElement"></param>
        /// <param name="wait"></param>
        /// <returns></returns>
        int GetElementCount(IList<IWebElement> groupElement);

        /// <summary>
        /// Action IsElementPresent check if the element is available in DOM page
        /// </summary>
        /// <param name="element"></param>
        /// <param name="wait"></param>
        /// <returns></returns>
        bool IsElementPresent(IWebElement element);

        /// <summary>
        /// Action IsElementPresent check if the elements are present/loaded in DOM page
        /// </summary>
        /// <param name="groupElement"></param>
        /// <param name="wait"></param>
        /// <returns></returns>
        bool IsElementPresent(IList<IWebElement> groupElement);

        /// <summary>
        /// Action IsElementChecked that returns true if element is checked in actions
        /// </summary>
        /// <param name="element"></param>
        /// <param name="wait"></param>
        /// <returns></returns>
        bool IsElementChecked(IWebElement element);

        /// <summary>
        /// Action IsElementChecked that returns true if some elements is checked in actions
        /// </summary>
        /// <param name="element"></param>
        /// <param name="wait"></param>
        /// <returns></returns>
        bool IsElementChecked(IList<IWebElement> groupElement);

        /// <summary>
        /// Action IsElementSelected that returns true if element is selected in action
        /// </summary>
        /// <param name="element"></param>
        /// <param name="wait"></param>
        /// <returns></returns>
        bool IsElementSelected(IWebElement element);

        /// <summary>
        /// Action IsElementSelected that returns true if some elements is selected in action
        /// </summary>
        /// <param name="element"></param>
        /// <param name="wait"></param>
        /// <returns></returns>
        bool IsElementSelected(IList<IWebElement> groupElement);
    }
}
