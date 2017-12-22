using OpenQA.Selenium;
using System.Collections.Generic;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IBonusHistoryElement
    {
        /// <summary>
        /// Template BonusHistory link element
        /// </summary>
        IWebElement BonusHistoryLink { get; set; }

        /// <summary>
        /// Template BonusHistory product selection element
        /// </summary>
        IWebElement BonusHistoryProduct { get; set; }

        /// <summary>
        /// Template BonusHistory product list element
        /// </summary>
        IList<IWebElement> BonusHistoryProductList { get; set; }

        /// <summary>
        /// Template BonusHistory status selection element
        /// </summary>
        IWebElement BonusHistoryStatus { get; set; }

        /// <summary>
        /// Template BonusHistory status list element
        /// </summary>
        IList<IWebElement> BonusHistoryStatusList { get; set; }

        /// <summary>
        /// Template BonusHistory start date field element
        /// </summary>
        IWebElement BonusHistoryStartDate { get; set; }

        /// <summary>
        /// Template BonusHistory end date field element
        /// </summary>
        IWebElement BonusHistoryEndDate { get; set; }

        /// <summary>
        /// Template BonusHistory limit selection element
        /// </summary>
        IWebElement BonusHistoryLimit { get; set; }

        /// <summary>
        /// Template BonusHistory limit list element
        /// </summary>
        IList<IWebElement> BonusHistoryLimitList { get; set; }

        /// <summary>
        /// Template BonusHistory submit button element
        /// </summary>
        IWebElement BonusHistorySubmitButton { get; set; }

        /// <summary>
        /// Template BonusHistory table data element
        /// </summary>
        IList<IWebElement> BonusHistoryTableData { get; set; }
    }
}
