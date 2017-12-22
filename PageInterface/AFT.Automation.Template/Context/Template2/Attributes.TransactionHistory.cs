namespace AFT.Automation.Template.Context.Template2
{
    public partial class Attributes
    {
        /// <summary>
        /// Template 2 Transaction History page attributes
        /// </summary>
        protected static class TransactionHistoryAttribute
        {
            public const string TransactionHistoryLinkAttr = "#sidebarlayout-body > div > div.sidebar.col-xs-3.account-sidebar > div > ul > li:nth-child(3) > ul > li:nth-child(3) > a";

            public const string TransactionHistoryTypeArrowAttr = "#history > div > div.form__body > form > div:nth-child(1) > div:nth-child(1) > span.select2.select2-container.select2-container--classic > span.selection > span > span.select2-selection__arrow";

            public const string TransactionHistoryTypeListResultAttr = "body > span.select2-container.select2-container--classic.select2-container--open > span > span.select2-results > ul > li";

            public const string TransactionHistoryLimitArrowAttr = "#history > div > div.form__body > form > div:nth-child(1) > div:nth-child(2) > span.select2.select2-container.select2-container--classic > span.selection > span > span.select2-selection__arrow";

            public const string TransactionHistoryLimitListResultAttr = "body > span.select2-container.select2-container--classic.select2-container--open > span > span.select2-results > ul > li";

            public const string TransactionHistoryStartDateAttr = "gameStartDate";

            public const string TransactionHistoryEndDateAttr = "gameEndDate";

            public const string TransactionHistorySubmitBtnAttr = "getTransaction";

            public const string TransactionHistoryTableDataAttr = "#history > div > table > tbody > tr.load > td";


        }
    }
}
