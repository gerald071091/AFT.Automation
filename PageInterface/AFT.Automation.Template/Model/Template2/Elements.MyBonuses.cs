using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFT.Automation.Template.Model.Template2
{
    public partial class Elements
    {
        [FindsBy(How = How.CssSelector, Using = MyBonusesAttribute.MyBonusesLinkAttr)]        
        public IWebElement MyBonusesLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = MyBonusesAttribute.MyBonusesFullNameAttr)]      
        public IWebElement MyBonusesFullName { get; set; }

        [FindsBy(How = How.CssSelector, Using = MyBonusesAttribute.MyBonusesBalancesAttr)]       
        public IWebElement MyBonusesBalances { get; set; }

        [FindsBy(How = How.CssSelector, Using = MyBonusesAttribute.MyBonusesBettingBalanceAttr)]        
        public IWebElement MyBonusesBettingBalance { get; set; }
    }
}
