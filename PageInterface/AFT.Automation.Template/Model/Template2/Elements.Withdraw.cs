using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFT.Automation.Template.Model.Template2
{
    public partial class Elements
    {
        [FindsBy(How = How.CssSelector, Using = WithdrawAttribtue.WithdrawLinkAttr)]
        public IWebElement WithdrawLink { get; set; }

        [FindsBy(How = How.Id, Using = WithdrawAttribtue.WithdrawAmountAttr)]        
        public IWebElement WithdrawAmount { get; set; }

        [FindsBy(How = How.Name, Using = WithdrawAttribtue.WithdrawNextBtnAttr)]       
        public IWebElement WithdrawNextButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = WithdrawAttribtue.WithdrawExpiryMonthAttr)]      
        public IWebElement WithdrawExpiryMonth { get; set; }

        [FindsBy(How = How.CssSelector, Using = WithdrawAttribtue.WithdrawExpiryYearAttr)]       
        public IWebElement WithdrawExpiryYear { get; set; }

        [FindsBy(How = How.CssSelector, Using = WithdrawAttribtue.WithdrawSecurityCodeAttr)]      
        public IWebElement WithdrawSecurityCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = WithdrawAttribtue.WithdrawBtnAttr)]       
        public IWebElement WithdrawButton { get; set; }
    }
}
