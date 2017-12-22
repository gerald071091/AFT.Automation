using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace AFT.Automation.Template.Model.Template1
{
    public partial class Elements
    {
        [FindsBy(How = How.CssSelector, Using = CasinoAttribute.CasinoGameCategoryListAttr)]
        public IList<IWebElement> CasinoGameCategoryList { get; set; }
    }
}
