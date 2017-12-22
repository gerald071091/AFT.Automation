using OpenQA.Selenium;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IForgotPasswordElement
    {
        /// <summary>
        /// Template Forgotpassword redirection link element
        /// </summary>
        IWebElement ForgotPasswordLink { get; set; }

        /// <summary>
        /// Template Forgotpassword used login name field element
        /// </summary>
        IWebElement ForgotpasswordLoginName { get; set; }

        /// <summary>
        /// Template Forgotpassword used email address field element
        /// </summary>
        IWebElement ForgotPasswordEmailAddress { get; set; }

        /// <summary>
        /// Template Forgotpassword submit button element
        /// </summary>
        IWebElement ForgotPasswordSubmitButton { get; set; }
    }
}
