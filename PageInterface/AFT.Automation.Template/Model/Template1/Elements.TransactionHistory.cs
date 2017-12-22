using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace AFT.Automation.Template.Model.Template1
{
    public partial class Elements
    {
        [FindsBy(How = How.CssSelector, Using = TransactionHistoryAttribute.TransactionHistoryLinkAttr)]        
        public IWebElement TransactionHistoryLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = TransactionHistoryAttribute.TransactionHistoryTypeArrowAttr)]        
        public IWebElement TransactionHistoryType { get; set; }

        [FindsBy(How = How.CssSelector, Using = TransactionHistoryAttribute.TransactionHistoryTypeListResultAttr)]       
        public IList<IWebElement> TransactionHistoryTypeList { get; set; }

        [FindsBy(How = How.CssSelector, Using = TransactionHistoryAttribute.TransactionHistoryLimitArrowAttr)]       
        public IWebElement TransactionHistoryLimit { get; set; }

        [FindsBy(How = How.CssSelector, Using = TransactionHistoryAttribute.TransactionHistoryLimitListResultAttr)]       
        public IList<IWebElement> TransactionHistoryLimitList { get; set; }

        [FindsBy(How = How.Id, Using = TransactionHistoryAttribute.TransactionHistoryStartDateAttr)]        
        public IWebElement TransactionHistoryStartDate { get; set; }

        [FindsBy(How = How.Id, Using = TransactionHistoryAttribute.TransactionHistoryEndDateAttr)]        
        public IWebElement TransactionHistoryEndDate { get; set; }

        [FindsBy(How = How.Id, Using = TransactionHistoryAttribute.TransactionHistorySubmitBtnAttr)]        
        public IWebElement TransactionHistorySubmitButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = TransactionHistoryAttribute.TransactionHistoryTableDataAttr)]        
        public IList<IWebElement> TransactionHistoryTableData { get; set; }
    }
}
