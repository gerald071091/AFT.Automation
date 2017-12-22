using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFT.Automation.Template.Model.Template1
{
    public partial class Elements
    {
        [FindsBy(How = How.CssSelector, Using = MyWalletAttribute.MyWalletLinkAttr)]        
        public IWebElement MyWalletLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = MyWalletAttribute.MyWalletMainBalanceAttr)]        
        public IWebElement MyWalletMainBalance { get; set; }

        [FindsBy(How = How.CssSelector, Using = MyWalletAttribute.MyWalletMainAccountBalanceAttr)]        
        public IWebElement MyWalletMainWalletBalance { get; set; }
    }
}
