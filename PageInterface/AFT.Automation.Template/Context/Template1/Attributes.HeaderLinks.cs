namespace AFT.Automation.Template.Context.Template1
{
    public partial class Attributes
    {
        /// <summary>
        /// Template 1 Header link attributes
        /// </summary>
        protected static class HeaderLinksAttribute
        {
            public const string HeaderSiteIconLinkAttr = "#header > h1 > a > img";

            public const string HeaderAffiliatesLinkAttr = "body > div.site-header > div > div > ul > li.last > a";

            public const string HeaderPromotionsLinkAttr = "body > div.site-header > div > div > ul > li:nth-child(1) > a";

            public const string HeaderHelpLinkAttr = "body > div.site-header > div > div > ul > li:nth-child(2) > a";

            public const string HeaderSportsbookLinkAttr = "#main-menu > li:nth-child(1) > a";

            public const string HeaderCasinoLinkAttr = "#main-menu > li:nth-child(2) > a";
        }
    }
}
