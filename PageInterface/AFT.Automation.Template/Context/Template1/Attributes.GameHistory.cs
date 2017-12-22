namespace AFT.Automation.Template.Context.Template1
{
    public partial class Attributes
    {
        /// <summary>
        /// Template 1 Game History page attributes
        /// </summary>
        protected static class GameHistoryAttribute
        {
            public const string GameHistoryLinkAttr = "#sidebarlayout-body > div > div.sidebar.col-xs-3.account-sidebar > div > ul > li:nth-child(2) > ul > li:nth-child(1) > a";

            public const string GameHistoryProductArrowAttr = "#history > div > div.form__body > form > div:nth-child(1) > div.col-xs-6.select-container > span > span.selection > span > span.select2-selection__arrow";

            public const string GameHistoryProductListResultAttr = "body > span.select2-container.select2-container--classic.select2-container--open > span > span.select2-results > ul > li";

            public const string GameHistoryGameStartDateAttr = "gameStartDate";

            public const string GameHistoryGameEndDateAttr = "gameEndDate";

            public const string GameHistoryTransactionLimitArrowAttr = "#history > div > div.form__body > form > div:nth-child(4) > div.col-xs-6.select-container > span > span.selection > span > span.select2-selection__arrow";

            public const string GameHistoryTransactionLimitListResultAttr = "body > span.select2-container.select2-container--classic.select2-container--open > span > span.select2-results > ul > li";

            public const string GameHistorySubmitBtnAttr = "#history > div > div.form__body > form > div.corner > input";

            public const string GameHistoryTableDataAttr = "#history > div > table > tbody > tr.load > td";
        }
    }
}
