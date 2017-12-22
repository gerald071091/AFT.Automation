using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFT.Automation.Template.Model.Template1
{
    public partial class Elements
    {
        [FindsBy(How = How.CssSelector, Using = MyDetailsAttribute.MyDetailsFullNameAttr)]        
        public IWebElement MyDetailsFullName { get; set; }

        [FindsBy(How = How.CssSelector, Using = MyDetailsAttribute.MyDetailsLoginNameAttr)]        
        public IWebElement MyDetailsLoginName { get; set; }

        [FindsBy(How = How.CssSelector, Using = MyDetailsAttribute.MyDetailsAddressAttr)]        
        public IWebElement MyDetailsAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = MyDetailsAttribute.MyDetailsPostalCodeAttr)]        
        public IWebElement MyDetailsPostalCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = MyDetailsAttribute.MyDetailsCityAttr)]        
        public IWebElement MyDetailsCity { get; set; }

        [FindsBy(How = How.CssSelector, Using = MyDetailsAttribute.MyDetailsCountryAttr)]        
        public IWebElement MyDetailsCountry { get; set; }

        [FindsBy(How = How.CssSelector, Using = MyDetailsAttribute.MyDetailsMobileNumberAttr)]        
        public IWebElement MyDetailsMobileNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = MyDetailsAttribute.MyDetailsEmailAddressAttr)]        
        public IWebElement MyDetailsEmailAddress { get; set; }
    }
}
