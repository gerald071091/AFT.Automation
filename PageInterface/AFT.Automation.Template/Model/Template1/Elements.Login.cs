using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFT.Automation.Template.Model.Template1
{
    public partial class Elements
    {
        [FindsBy(How = How.Name, Using = LoginAttribute.LoginUsernameAttr)]        
        public IWebElement LoginUsername { get; set; }

        [FindsBy(How = How.Name, Using = LoginAttribute.LoginPasswordAttr)]        
        public IWebElement LoginPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = LoginAttribute.LoginBtnAttr)]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = LoginAttribute.LoginHeaderContainerAttr)]        
        public IWebElement LoginHeaderDetails { get; set; }

        [FindsBy(How = How.CssSelector, Using = LoginAttribute.LoginDetailsDrpDwnAttr)]       
        public IWebElement LoginDetailsDropDown { get; set; }

        [FindsBy(How = How.CssSelector, Using = LoginAttribute.LogoutAttr)]        
        public IWebElement LogoutLink { get; set; }
    }
}
