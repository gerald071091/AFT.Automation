namespace AFT.Automation.Template.Context.Template1
{
    public partial class Attributes
    {
        /// <summary>
        /// Template 1 Withdraw page attributes
        /// </summary>
        protected static class WithdrawAttribtue
        {
            public const string WithdrawLinkAttr = "#sidebarlayout-body > div > div.sidebar.col-xs-3.account-sidebar > div > ul > li:nth-child(3) > ul > li:nth-child(2) > a";

            public const string WithdrawAmountAttr = "withdrawAmount";

            public const string WithdrawNextBtnAttr = "submit";

            public const string WithdrawExpiryMonthAttr = "#Withdrawal > div > div:nth-child(4) > div > form > div:nth-child(6) > div:nth-child(2) > div:nth-child(2) > input";

            public const string WithdrawExpiryYearAttr = "#Withdrawal > div > div:nth-child(4) > div > form > div:nth-child(6) > div:nth-child(2) > div:nth-child(4) > input";

            public const string WithdrawSecurityCodeAttr = "#Withdrawal > div > div:nth-child(4) > div > form > div:nth-child(6) > div:nth-child(3) > div.col-xs-3 > input";

            public const string WithdrawBtnAttr = "#Withdrawal > div > div:nth-child(4) > div > form > div:nth-child(6) > div.form-group.margined-right > div:nth-child(1) > input";
        }
    }
}
