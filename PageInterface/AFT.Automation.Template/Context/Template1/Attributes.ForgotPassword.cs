namespace AFT.Automation.Template.Context.Template1
{
    public partial class Attributes
    {
        /// <summary>
        /// Template 1 Forgot password page attributes
        /// </summary>
        protected static class ForgotPasswordAttribute
        {
            public const string ForgotPasswordLinkAttr = "body > div.site-header > div > div > ul > li:nth-child(4) > a";

            public const string ForgotPasswordLoginNameAttr = "please_name";

            public const string ForgotPasswordEmailAddressAttr = "Please_email";

            public const string ForgotPasswordSubmitBtnAttr = "SUBMIT";
        }
    }
}
