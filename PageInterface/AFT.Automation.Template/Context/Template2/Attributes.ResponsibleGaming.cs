namespace AFT.Automation.Template.Context.Template2
{
    public partial class Attributes
    {
        /// <summary>
        /// Template 2 Responsible Gaming page attributes
        /// </summary>
        protected static class ResponsibleGamingAttribute
        {
            public const string ResponsibleGamingLinkAttr = "#sidebarlayout-body > div > div.sidebar.col-xs-3.account-sidebar > div > ul > li:nth-child(4) > ul > li:nth-child(2) > a";

            public const string RealityCheckBoxAttr = "cb-reality-check";

            public const string RealityCheckArrowAttr = "#reality-check > form > div > div.col-md-4.self-exclude.reality-sb > span > span.selection > span > span.select2-selection__arrow";

            public const string RealityCheckListResultAttr = "body > span.select2-container.select2-container--classic.select2-container--open > span > span.select2-results > ul > li";

            public const string RealityCheckSaveBtnAttr = "#reality-check > form > div > div.col-md-5 > input";

			public const string RealityCheckAcceptBtnAttr = "accept-btn";

			public const string DepositLimitArrowAttr = "#formDepositLimit > div > div:nth-child(2) > div.col-xs-4.deposit-limit > span > span.selection > span > span.select2-selection__arrow";

            public const string DepositLimitListResultAttr = "body > span.select2-container.select2-container--classic.select2-container--open > span > span.select2-results > ul > li";

            public const string DepositLimitAmountAttr = "depositLimitAmount";

            public const string DepositLimitSubmitBtnAttr = "#submit-dep-limit > button";

            public const string DepositLimitCancelBtnAttr = "#formDepositLimit > div > div.col-xs-12 > div > div.form-inline > div > div > button:nth-child(2)";

            public const string TimeOutCheckBoxAttr = "timeOut";

            public const string TimeOutArrowAttr = "#responsible-gambling > form > div:nth-child(1) > div.col-md-4.self-exclude.timeout-sb > span > span.selection > span > span.select2-selection__arrow";

            public const string TimeOutListResultAttr = "body > span.select2-container.select2-container--classic.select2-container--open > span > span.select2-results > ul > li";

            public const string SelfExcludeCheckBoxAttr = "selfExclude";

            public const string SelfExcludeArrowAttr = "#responsible-gambling > form > div:nth-child(2) > div.col-md-4.self-exclude.selfexclude-sb > span > span.selection > span > span.select2-selection__arrow";

            public const string SelfExcludeListResultAttr = "body > span.select2-container.select2-container--classic.select2-container--open > span > span.select2-results > ul > li";

            public const string CompulsiveGamblerRadioBtnAttr = "#compulsivegambler-container > div.col-lg-2.left__border.cg-error > label.right__space > input[type='radio']";

            public const string TimeOutSelfExcludeSaveBtnAttr = "#responsible-gambling > form > div:nth-child(3) > div.col-lg-12.top__space > input";

            public const string TimeOutSelfExcludeModalOkBtnAttr = "#exclude-ok";

            public const string ResponsibleGamingCompleteTitleAttr = "#responsible-gambling-div > h1";
        }
    }
}
