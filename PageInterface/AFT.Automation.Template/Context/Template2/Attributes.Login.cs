namespace AFT.Automation.Template.Context.Template2
{
    public partial class Attributes
    {
        /// <summary>
        /// Template 2 Login page attributes
        /// </summary>
        protected static class LoginAttribute
        {
            public const string LoginUsernameAttr = "username";

            public const string LoginPasswordAttr = "password";

            public const string LoginBtnAttr = "#form_contact > ul > li:nth-child(3) > input";

            public const string LoginHeaderContainerAttr = "#form_contact > ul > li.helper-join";

            public const string LogoutAttr = "#form_contact > ul > li:nth-child(3) > a";
        }
    }
}
