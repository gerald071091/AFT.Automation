namespace AFT.Automation.Template.Context.Template1
{
    public partial class Attributes
    {
        /// <summary>
        /// Template 1 Login page attributes
        /// </summary>
        protected static class LoginAttribute
        {
            public const string LoginUsernameAttr = "username";

            public const string LoginPasswordAttr = "password";

            public const string LoginBtnAttr = "#login > input";

            public const string LoginHeaderContainerAttr = "body > div.site-header > div > div";

            public const string LoginDetailsDrpDwnAttr = "body > div.site-header > div > div > div > div > div > div.login-details.col-xs-3.text-center > span:nth-child(3) > span.caret";

            public const string LogoutAttr = "#nav-dropdown > ul > li:nth-child(3) > a";
        }
    }
}
