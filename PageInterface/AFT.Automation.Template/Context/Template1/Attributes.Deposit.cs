namespace AFT.Automation.Template.Context.Template1
{
    public partial class Attributes
    {
        /// <summary>
        /// Template 1 Deposit page attributes
        /// </summary>
        protected static class DepositAttribute
        {
            public const string DepositLinkAttr = "#nav-dropdown > ul > li:nth-child(1) > a";

            public const string DepositNetellerCheckBoxAttr = "#open-account > div > form > div:nth-child(3) > div:nth-child(1) > div > div.col-xs-1.radio > input";

            public const string DepositNextBtnAttr = "#open-account > div > form > div:nth-child(5) > div.pull-right.col-xs-2.text-center > input";

            public const string DepositNetellerAmountAttr = "depositAmount";

            public const string DepositNetellerAccountIDAttr = "accountid";

            public const string DepositNetellerSecureIDAttr = "secureId";

            public const string DepositNetellerHomePageLinkAttr = "#open-account > div > div.form > form > div:nth-child(3) > div:nth-child(2) > p:nth-child(2) > a";

            public const string DepositNetellerDepositBtnAttr = "#open-account > div > div.form > form > div:nth-child(5) > div:nth-child(7) > div.pull-right.col-xs-2.text-center > input";

            public const string DepositNetellerReferenceNumberAttr = "#open-account > div > div > div:nth-child(3) > p.col-xs-9";
        }
    }
}
