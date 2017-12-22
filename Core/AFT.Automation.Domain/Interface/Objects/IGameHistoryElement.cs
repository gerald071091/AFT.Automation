using OpenQA.Selenium;
using System.Collections.Generic;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IGameHistoryElement
    {
        /// <summary>
        /// Template GameHistory link element
        /// </summary>
        IWebElement GameHistoryLink { get; set; }

        /// <summary>
        /// Template GameHistory product selection element
        /// </summary>
        IWebElement GameHistoryProduct { get; set; }

        /// <summary>
        /// Template GameHistory product list element
        /// </summary>
        IList<IWebElement> GameHistoryProductList { get; set; }

        /// <summary>
        /// Template GameHistory game start date field element
        /// </summary>
        IWebElement GameHistoryGameStartDate { get; set; }

        /// <summary>
        /// Template GameHistory game end data field element
        /// </summary>
        IWebElement GameHistoryGameEndDate { get; set; }

        /// <summary>
        /// Template GameHistory transaction limit selection element
        /// </summary>
        IWebElement GameHistoryTransactionLimit { get; set; }

        /// <summary>
        /// Template GameHistory transaction limit list element
        /// </summary>
        IList<IWebElement> GameHistoryTransactionLimitList { get; set; }

        /// <summary>
        /// Template GameHistory submit button element
        /// </summary>
        IWebElement GameHistorySubmitButton { get; set; }

        /// <summary>
        /// Template GameHistory table data element
        /// </summary>
        IList<IWebElement> GameHistoryTableData { get; set; }
    }
}
