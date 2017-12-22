namespace AFT.Automation.Template.Context.Template2
{
    public partial class Attributes
    {
        /// <summary>
        /// Template 2 MyBonuses page attributes
        /// </summary>
        protected static class MyBonusesAttribute
        {
            public const string MyBonusesLinkAttr = "#sidebarlayout-body > div > div.sidebar.col-xs-3.account-sidebar > div > ul > li:nth-child(1) > ul > li:nth-child(2) > a";

            public const string MyBonusesFullNameAttr = "#mybonuses > div > p:nth-child(1) > span";

            public const string MyBonusesBalancesAttr = "#mybonuses > div > div:nth-child(4) > form > div > div > div > div.col-xs-10 > p.col-xs-5.bonusBalance";

            public const string MyBonusesBettingBalanceAttr = "#mybonuses > div > div:nth-child(6) > form > div > div > div > div.col-xs-10 > p.col-xs-5.bonusBalance";
        }
    }
}
