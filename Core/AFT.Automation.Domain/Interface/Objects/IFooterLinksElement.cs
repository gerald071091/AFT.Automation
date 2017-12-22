using OpenQA.Selenium;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IFooterLinksElement
    {
        /// <summary>
        /// Template FooterLink OpenAccount link element
        /// </summary>
        IWebElement FooterOpenAccountLink { get; set; }

        /// <summary>
        /// Template FooterLink AboutUs link element
        /// </summary>
        IWebElement FooterAboutUsLink { get; set; }

        /// <summary>
        /// Template FooterLink ContactUs link element
        /// </summary>
        IWebElement FooterContactUsLink { get; set; }

        /// <summary>
        /// Template FooterLink Promotions link element
        /// </summary>
        IWebElement FooterPromotionsLink { get; set; }

        /// <summary>
        /// Template FooterLink Terms and Conditions link element
        /// </summary>
        IWebElement FooterTermsAndConditionsLink { get; set; }

        /// <summary>
        /// Template FooterLink Rules link element
        /// </summary>
        IWebElement FooterRulesLink { get; set; }

        /// <summary>
        /// Template FooterLink Privacy policy link element
        /// </summary>
        IWebElement FooterPrivacyPolicyLink { get; set; }

        /// <summary>
        /// Template FooterLink Cashout link element
        /// </summary>
        IWebElement FooterCashOutLink { get; set; }

        /// <summary>
        /// Template FooterLink Lost password link element
        /// </summary>
        IWebElement FooterLostPasswordLink { get; set; }

        /// <summary>
        /// Template FooterLink Technical support link element
        /// </summary>
        IWebElement FooterTechnicalSupportLink { get; set; }

        /// <summary>
        /// Template FooterLink Deposit and withdrawal link element
        /// </summary>
        IWebElement FooterDepositAndWithdrawalLink { get; set; }

        /// <summary>
        /// Template FooterLink Responsible gaming link element
        /// </summary>
        IWebElement FooterResponsibleGamingLink { get; set; }

        /// <summary>
        /// Template FooterLink RTP link element
        /// </summary>
        IWebElement FooterRTPLink { get; set; }

        /// <summary>
        /// Template FooterLink FAQ link element
        /// </summary>
        IWebElement FooterFAQLink { get; set; }

        /// <summary>
        /// Template FooterLink GameCare link element
        /// </summary>
        IWebElement FooterGameCareIconLink { get; set; }

        /// <summary>
        /// Template FooterLink Age Restriction link element
        /// </summary>
        IWebElement FooterAgeRestrictionIconLink { get; set; }

        /// <summary>
        /// Template FooterLink Safe and Secure link element
        /// </summary>
        IWebElement FooterSafeAndSecureIconLink { get; set; }

        /// <summary>
        /// Template FooterLink Isle of man link element
        /// </summary>
        IWebElement FooterIsleOfManIconLink { get; set; }

        /// <summary>
        /// Template FooterLink Gambling commission link element
        /// </summary>
        IWebElement FooterGamblingCommissionIconLink { get; set; }

        /// <summary>
        /// Template FooterLink IBAS link element
        /// </summary>
        IWebElement FooterIBASIconLink { get; set; }

        /// <summary>
        /// Template FooterLink Gamble ware link element
        /// </summary>
        IWebElement FooterGamblewareIconLink { get; set; }

        /// <summary>
        /// Template FooterLink Site link element
        /// </summary>
        IWebElement FooterSiteIconLink { get; set; }
    }
}
