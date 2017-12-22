using OpenQA.Selenium;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IHeaderLinksElement
    {
        /// <summary>
        /// Template HeaderLink site icon
        /// </summary>
        IWebElement HeaderSiteIconLink { get; set; }

        /// <summary>
        /// Template HeaderLink affiliates
        /// </summary>
        IWebElement HeaderAffiliatesLink { get; set; }

        /// <summary>
        /// Template HeaderLink Promotions
        /// </summary>
        IWebElement HeaderPromotionsLink { get; set; }

        /// <summary>
        /// Temaplate HeaderLink Help
        /// </summary>
        IWebElement HeaderHelpLink { get; set; }

        /// <summary>
        /// Template HeaderLink Sportsbook
        /// </summary>
        IWebElement HeaderSportsbookLink { get; set; }

        /// <summary>
        /// Template HeaderLink Casino
        /// </summary>
        IWebElement HeaderCasinoLink { get; set; }
    }
}
