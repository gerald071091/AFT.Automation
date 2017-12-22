using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace AFT.Automation.Template.Model.Template2
{
    public partial class Elements
    {
        [FindsBy(How = How.Id, Using = DepositWithBonusAttribute.DepositWithBonusCodeAttr)]        
        public IWebElement DepositWithBonusCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = DepositWithBonusAttribute.DepositWithBonusProductArrowAttr)]        
        public IWebElement DepositWithBonusProduct { get; set; }

        [FindsBy(How = How.CssSelector, Using = DepositWithBonusAttribute.DepositWithBonusProductListResultAttr)]     
        public IList<IWebElement> DepositWithBonusProductList { get; set; }
        
        [FindsBy(How = How.Id, Using = DepositWithBonusAttribute.DepositWithBonusTnCCheckBoxAttr)]        
        public IWebElement DepositWithBonusTnCCheckBox { get; set; }
        
        [FindsBy(How = How.Id, Using = DepositWithBonusAttribute.DepositWithBonusSubscribeCheckBoxAttr)]       
        public IWebElement DepositWithBonusSubscribeCheckBox { get; set; }
    }
}
