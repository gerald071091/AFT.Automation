using AFT.Automation.Domain.Interface.Miscellaneous;
using AFT.Automation.Domain.Interface.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Diagnostics.Contracts;

namespace AFT.Automation.Domain.Factory
{
    public class PageBaseFactory
    {
        private readonly IWebDriver _driver;
        protected readonly IActionProvider _action;
        protected readonly IBaseElement _element;

        public PageBaseFactory(IWebDriver driver, IActionProvider action, IBaseElement element)
        {
            Contract.Requires(driver != null);
            Contract.Requires(action != null);
			Contract.Requires(element != null);

            _driver = driver;
            _element = PageOperation(_driver, element);
            _action = action;
        }

        private static IBaseElement PageOperation(ISearchContext driver, IBaseElement element)
        {
            var page = element;
            PageFactory.InitElements(driver, page);
            return page;
        }
    }
}
