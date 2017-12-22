using OpenQA.Selenium;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IChangePasswordElement
    {
        /// <summary>
        /// Template Changepassword change button element
        /// </summary>
        IWebElement ChangePasswordButton { get; set; }

        /// <summary>
        /// Template Changepassword current password field element
        /// </summary>
        IWebElement ChangePasswordCurrentField { get; set; }

        /// <summary>
        /// Template Changepassword new password field element
        /// </summary>
        IWebElement ChangePasswordNewField { get; set; }

        /// <summary>
        /// Template Changepassword confirm new password field element
        /// </summary>
        IWebElement ChangePasswordConfirmField { get; set; }

        /// <summary>
        /// Template Changepassword update button element
        /// </summary>
        IWebElement ChangePasswordUpdateButton { get; set; }
    }
}
