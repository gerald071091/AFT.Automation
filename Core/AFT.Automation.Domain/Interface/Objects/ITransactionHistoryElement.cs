using OpenQA.Selenium;
using System.Collections.Generic;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface ITransactionHistoryElement
    {
        /// <summary>
        /// Template TransactionHistory link element
        /// </summary>
        IWebElement TransactionHistoryLink { get; set; }

        /// <summary>
        /// Template TransactionHistory type selection element
        /// </summary>
        IWebElement TransactionHistoryType { get; set; }

        /// <summary>
        /// Template TransactionHistory type list element
        /// </summary>
        IList<IWebElement> TransactionHistoryTypeList { get; set; }

        /// <summary>
        /// Template TransactionHistory limit selection element
        /// </summary>
        IWebElement TransactionHistoryLimit { get; set; }

        /// <summary>
        /// Template TransactionHistory limit list element
        /// </summary>
        IList<IWebElement> TransactionHistoryLimitList { get; set; }

        /// <summary>
        /// Template TransactionHistory start date field element
        /// </summary>
        IWebElement TransactionHistoryStartDate { get; set; }

        /// <summary>
        /// Template TransactionHistory end date field element
        /// </summary>
        IWebElement TransactionHistoryEndDate { get; set; }

        /// <summary>
        /// Template TransactionHistory submit button element
        /// </summary>
        IWebElement TransactionHistorySubmitButton { get; set; }

        /// <summary>
        /// Template TransactionHistory table data element
        /// </summary>
        IList<IWebElement> TransactionHistoryTableData { get; set; }
    }
}
