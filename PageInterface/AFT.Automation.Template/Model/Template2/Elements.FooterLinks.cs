using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFT.Automation.Template.Model.Template2
{
    public partial class Elements
    {
        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterOpenAccountLinkAttr)]      
        public IWebElement FooterOpenAccountLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterAboutUsLinkAttr)]     
        public IWebElement FooterAboutUsLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterContactUsLinkAttr)]      
        public IWebElement FooterContactUsLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterTermsAndConditionsLinkAttr)]       
        public IWebElement FooterTermsAndConditionsLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterRulesLinkAttr)]      
        public IWebElement FooterRulesLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterPrivacyPolicyLinkAttr)]       
        public IWebElement FooterPrivacyPolicyLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterCashOutLinkAttr)]      
        public IWebElement FooterCashOutLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterLostPasswordLinkAttr)]       
        public IWebElement FooterLostPasswordLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterTechnicalSupportLinkAttr)]      
        public IWebElement FooterTechnicalSupportLink { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterDepositAndWithdrawalLinkAttr)]        
        public IWebElement FooterDepositAndWithdrawalLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterResponsibleGamingLinkAttr)]       
        public IWebElement FooterResponsibleGamingLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterRTPLinkAttr)]        
        public IWebElement FooterRTPLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterFAQLinkAttr)]       
        public IWebElement FooterFAQLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterGameCareIconLinkAttr)]     
        public IWebElement FooterGameCareIconLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterIsleOfManIconLinkAttr)]       
        public IWebElement FooterIsleOfManIconLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterGamblingCommissionIconLinkAttr)]        
        public IWebElement FooterGamblingCommissionIconLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterIBASIconLinkAttr)]       
        public IWebElement FooterIBASIconLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = FooterLinksAttribute.FooterGamblewareIconLinkAttr)]       
        public IWebElement FooterGamblewareIconLink { get; set; }
    }
}
