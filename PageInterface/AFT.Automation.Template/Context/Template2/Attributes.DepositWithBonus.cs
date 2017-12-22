namespace AFT.Automation.Template.Context.Template2
{
    public partial class Attributes
    {
        /// <summary>
        /// Template 2 Deposit with bonus page attributes
        /// </summary>
        protected static class DepositWithBonusAttribute
        {
            public const string DepositWithBonusCodeAttr = "bonusCode";

            public const string DepositWithBonusProductArrowAttr = "#open-account > div.form > form > div:nth-child(5) > div:nth-child(2) > div > div > span > span.selection > span > span.select2-selection__arrow";

            public const string DepositWithBonusProductListResultAttr = "body > span.select2-container.select2-container--classic.select2-container--open > span > span.select2-results > ul > li";

            public const string DepositWithBonusTnCCheckBoxAttr = "tnc";

            public const string DepositWithBonusSubscribeCheckBoxAttr = "subscribe";
        }
    }
}
