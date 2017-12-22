using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFT.Automation.Template.Model.Template2
{
    public partial class Elements
    {
        [FindsBy(How = How.Id, Using = HeaderLinksAttribute.HeaderSiteIconLinkAttr)]        
        public IWebElement HeaderSiteIconLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = HeaderLinksAttribute.HeaderAffiliatesLinkAttr)]        
        public IWebElement HeaderAffiliatesLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = HeaderLinksAttribute.HeaderPromotionsLinkAttr)]       
        public IWebElement HeaderPromotionsLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = HeaderLinksAttribute.HeaderHelpLinkAttr)]        
        public IWebElement HeaderHelpLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = HeaderLinksAttribute.HeaderSportsbookLinkAttr)]       
        public IWebElement HeaderSportsbookLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = HeaderLinksAttribute.HeaderCasinoLinkAttr)]      
        public IWebElement HeaderCasinoLink { get; set; }
    }
}
