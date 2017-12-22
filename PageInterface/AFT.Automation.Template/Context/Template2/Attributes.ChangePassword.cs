namespace AFT.Automation.Template.Context.Template2
{
    public partial class Attributes
    {
        /// <summary>
        /// Template 2 Change password page attributes
        /// </summary>
        protected static class ChangePasswordAttribute
        {
            public const string ChangePasswordBtnAttr = "#formChangePassword > div:nth-child(2) > div > a";

            public const string ChangePasswordCurrentAttr = "oldPassword";

            public const string ChangePasswordNewAttr = "password";

            public const string ChangePasswordConfirmAttr = "confirmPassword";

            public const string ChangePasswordUpdateBtnAttr = "#formChangePassword > div.row.mt-25 > div > input";
        }
    }
}
