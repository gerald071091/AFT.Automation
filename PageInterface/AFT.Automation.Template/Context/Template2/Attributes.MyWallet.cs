namespace AFT.Automation.Template.Context.Template2
{
    public partial class Attributes
    {
        /// <summary>
        /// Template 2 My Wallet page attributes
        /// </summary>
        protected static class MyWalletAttribute
        {
            public const string MyWalletLinkAttr = "#sidebarlayout-body > div > div.sidebar.col-xs-3.account-sidebar > div > ul > li:nth-child(1) > ul > li:nth-child(1) > a";

            public const string MyWalletMainBalanceAttr = "#mywallet > div > div:nth-child(4) > form > div.row.noleft.noright > div.col-xs-6 > p.col-xs-5 > span";

            public const string MyWalletMainAccountBalanceAttr = "#form_contact > ul > li:nth-child(2) > p > span";
        }
    }
}
