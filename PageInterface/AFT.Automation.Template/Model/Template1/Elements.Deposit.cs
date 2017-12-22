using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFT.Automation.Template.Model.Template1
{
    public partial class Elements
    {
        [FindsBy(How = How.CssSelector, Using = DepositAttribute.DepositLinkAttr)]        
        public IWebElement DepositLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = DepositAttribute.DepositNetellerCheckBoxAttr)]        
        public IWebElement DepositNetellerCheckBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = DepositAttribute.DepositNextBtnAttr)]       
        public IWebElement DepositNextButton { get; set; }

        [FindsBy(How = How.Id, Using = DepositAttribute.DepositNetellerAmountAttr)]     
        public IWebElement DepositNetellerAmount { get; set; }

        [FindsBy(How = How.Id, Using = DepositAttribute.DepositNetellerAccountIDAttr)]      
        public IWebElement DepositNetellerAccountID { get; set; }

        [FindsBy(How = How.Id, Using = DepositAttribute.DepositNetellerSecureIDAttr)]      
        public IWebElement DepositNetellerSecureID { get; set; }

        [FindsBy(How = How.CssSelector, Using = DepositAttribute.DepositNetellerHomePageLinkAttr)]
        public IWebElement DepositNetellerHomePageLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = DepositAttribute.DepositNetellerDepositBtnAttr)]      
        public IWebElement DepositNetellerDepositButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = DepositAttribute.DepositNetellerReferenceNumberAttr)]
        public IWebElement DepositNetellerReferenceNumber { get; set; }
    }
}
