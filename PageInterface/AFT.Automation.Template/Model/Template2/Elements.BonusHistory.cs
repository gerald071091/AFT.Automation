using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace AFT.Automation.Template.Model.Template2
{
    public partial class Elements
    {
        [FindsBy(How = How.CssSelector, Using = BonusHistoryAttribute.BonusHistoryLinkAttr)]        
        public IWebElement BonusHistoryLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = BonusHistoryAttribute.BonusHistoryProductArrowAttr)]        
        public IWebElement BonusHistoryProduct { get; set; }

        [FindsBy(How = How.CssSelector, Using = BonusHistoryAttribute.BonusHistoryProductListResultAttr)]        
        public IList<IWebElement> BonusHistoryProductList { get; set; }

        [FindsBy(How = How.CssSelector, Using = BonusHistoryAttribute.BonusHistoryStatusArrowAttr)]        
        public IWebElement BonusHistoryStatus { get; set; }

        [FindsBy(How = How.CssSelector, Using = BonusHistoryAttribute.BonusHistoryStatusListResultAttr)]
        public IList<IWebElement> BonusHistoryStatusList { get; set; }

        [FindsBy(How = How.Id, Using = BonusHistoryAttribute.BonusHistoryStartDateAttr)]        
        public IWebElement BonusHistoryStartDate { get; set; }

        [FindsBy(How = How.Id, Using = BonusHistoryAttribute.BonusHistoryEndDateAttr)]        
        public IWebElement BonusHistoryEndDate { get; set; }

        [FindsBy(How = How.CssSelector, Using = BonusHistoryAttribute.BonusHistoryLimitArrowAttr)]        
        public IWebElement BonusHistoryLimit { get; set; }

        [FindsBy(How = How.CssSelector, Using = BonusHistoryAttribute.BonusHistoryLimitListResultAttr)]        
        public IList<IWebElement> BonusHistoryLimitList { get; set; }

        [FindsBy(How = How.CssSelector, Using = BonusHistoryAttribute.BonusHistorySubmitBtnAttr)]        
        public IWebElement BonusHistorySubmitButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = BonusHistoryAttribute.BonusHistoryTableDataAttr)]        
        public IList<IWebElement> BonusHistoryTableData { get; set; }
    }
}
