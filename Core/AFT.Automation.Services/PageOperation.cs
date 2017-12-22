using AFT.Automation.Domain.Helper;
using AFT.Automation.Domain.Interface.Miscellaneous;
using AFT.Automation.Domain.Interface.Objects;
using AFT.Automation.Domain.Interface.Operations;
using AFT.Automation.Domain.Provider;
using AFT.Automation.Template.Operation.UKT;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TemplateOneElement = AFT.Automation.Template.Model.Template1.Elements;
using TemplateTwoElement = AFT.Automation.Template.Model.Template2.Elements;


namespace AFT.Automation.Services
{
    public class PageOperation : PageConfiguration
    {
        protected static Process _process;
        protected IBaseOperation _operation;
		protected IDictionary<string, Action> _dictionary;
		protected IList<string> _list;

        /// <summary>
        /// We initialize the class operations based on sites and browser used.
        /// </summary>
        /// <param name="sites"></param>
        /// <param name="browser"></param>
        /// <returns></returns>
        protected IBaseOperation InitializeOperation(string sites, string browser)
        {
            IWebDriver driver = Current(browser, sites);
            IActionProvider action = new ActionProvider(driver);
            IBaseElement element = sites.In("template1".GetValue()) 
                ? new TemplateOneElement() as IBaseElement
                : new TemplateTwoElement() as IBaseElement;

			driver.Manage().Window.Maximize();
            return new Operation(driver, action, element);
        }
    }
}
