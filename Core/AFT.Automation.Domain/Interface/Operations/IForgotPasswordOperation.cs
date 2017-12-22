namespace AFT.Automation.Domain.Interface.Operations
{
    public interface IForgotPasswordOperation
    {
        /// <summary>
        /// ForgotPasswordOperation click forgot password link
        /// </summary>
        IForgotPasswordOperation ClickForgotPasswordLink();

        /// <summary>
        /// ForgotPasswordOperation provide the login name used
        /// </summary>
        /// <param name="loginName"></param>
        IForgotPasswordOperation ProvideForgotPasswordLoginName(string loginName);

        /// <summary>
        /// ForgotPasswordOperation provide the email address used
        /// </summary>
        /// <param name="email"></param>
        IForgotPasswordOperation ProvideForgotPasswordEmailAddress(string email);

        /// <summary>
        /// ForgotPasswordOperation click submit button
        /// </summary>
        IForgotPasswordOperation ClickForgotPasswordSubmitButton();
    }
}
