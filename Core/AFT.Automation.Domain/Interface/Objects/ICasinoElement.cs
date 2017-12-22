using OpenQA.Selenium;
using System.Collections.Generic;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface ICasinoElement
    {
        /// <summary>
        /// Template Casino game category list element
        /// </summary>
        IList<IWebElement> CasinoGameCategoryList { get; set; }
    }
}
