using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFT.Automation.Template.Model.Template2
{
    public partial class Elements
    {
        [FindsBy(How = How.CssSelector, Using = ChangePasswordAttribute.ChangePasswordBtnAttr)]       
        public IWebElement ChangePasswordButton { get; set; }

        [FindsBy(How = How.Id, Using = ChangePasswordAttribute.ChangePasswordCurrentAttr)]        
        public IWebElement ChangePasswordCurrentField { get; set; }

        [FindsBy(How = How.Id, Using = ChangePasswordAttribute.ChangePasswordNewAttr)]        
        public IWebElement ChangePasswordNewField { get; set; }

        [FindsBy(How = How.Id, Using = ChangePasswordAttribute.ChangePasswordConfirmAttr)]        
        public IWebElement ChangePasswordConfirmField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ChangePasswordAttribute.ChangePasswordUpdateBtnAttr)]        
        public IWebElement ChangePasswordUpdateButton { get; set; }
    }
}
