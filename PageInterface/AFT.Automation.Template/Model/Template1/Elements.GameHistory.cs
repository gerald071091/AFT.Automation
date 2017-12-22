using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace AFT.Automation.Template.Model.Template1
{
    public partial class Elements
    {
        [FindsBy(How = How.CssSelector, Using = GameHistoryAttribute.GameHistoryLinkAttr)]        
        public IWebElement GameHistoryLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = GameHistoryAttribute.GameHistoryProductArrowAttr)]       
        public IWebElement GameHistoryProduct { get; set; }

        [FindsBy(How = How.CssSelector, Using = GameHistoryAttribute.GameHistoryProductListResultAttr)]        
        public IList<IWebElement> GameHistoryProductList { get; set; }

        [FindsBy(How = How.Id, Using = GameHistoryAttribute.GameHistoryGameStartDateAttr)]        
        public IWebElement GameHistoryGameStartDate { get; set; }

        [FindsBy(How = How.Id, Using = GameHistoryAttribute.GameHistoryGameEndDateAttr)]        
        public IWebElement GameHistoryGameEndDate { get; set; }

        [FindsBy(How = How.CssSelector, Using = GameHistoryAttribute.GameHistoryTransactionLimitArrowAttr)]        
        public IWebElement GameHistoryTransactionLimit { get; set; }

        [FindsBy(How = How.CssSelector, Using = GameHistoryAttribute.GameHistoryTransactionLimitListResultAttr)]        
        public IList<IWebElement> GameHistoryTransactionLimitList { get; set; }

        [FindsBy(How = How.CssSelector, Using = GameHistoryAttribute.GameHistorySubmitBtnAttr)]        
        public IWebElement GameHistorySubmitButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = GameHistoryAttribute.GameHistoryTableDataAttr)]        
        public IList<IWebElement> GameHistoryTableData { get; set; }
    }
}
