namespace AFT.Automation.Template.Context.Template2
{
    public partial class Attributes
    {
        /// <summary>
        /// Template 2 Attributes that is not certain to specific operation
        /// </summary>
        protected static class CommonAttributes
        {
            public const string CommonModalMessageAttr = "div.fancybox-wrap.fancybox-desktop.fancybox-type-html.fancybox-opened > div > div > div > div > p";

            public const string CommonModalSubmitBtnAttr = "div.fancybox-wrap.fancybox-desktop.fancybox-type-html.fancybox-opened > div > div > div > div > button";

            public const string CommonMyAccountLinkAttr = "#header > div.col-xs-8.site-helper > ul > li:nth-child(2) > ul > li:nth-child(2) > a";

            public const string CommonMyDetailsLinkAttr = "#sidebarlayout-body > div > div.sidebar.col-xs-3.account-sidebar > div > ul > li:nth-child(4) > ul > li:nth-child(1) > a";

			public const string CommonHeaderMainWalletAttr = "#form_contact > ul > li:nth-child(2) > p > span";
		}
    }
}
