using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFT.Automation.Template.Model.Template1
{
    public partial class Elements
    {
        [FindsBy(How = How.CssSelector, Using = ForgotPasswordAttribute.ForgotPasswordLinkAttr)]        
        public IWebElement ForgotPasswordLink { get; set; }

        [FindsBy(How = How.Id, Using = ForgotPasswordAttribute.ForgotPasswordLoginNameAttr)]       
        public IWebElement ForgotpasswordLoginName { get; set; }

        [FindsBy(How = How.Id, Using = ForgotPasswordAttribute.ForgotPasswordEmailAddressAttr)]        
        public IWebElement ForgotPasswordEmailAddress { get; set; }

        [FindsBy(How = How.Name, Using = ForgotPasswordAttribute.ForgotPasswordSubmitBtnAttr)]        
        public IWebElement ForgotPasswordSubmitButton { get; set; }
    }
}
