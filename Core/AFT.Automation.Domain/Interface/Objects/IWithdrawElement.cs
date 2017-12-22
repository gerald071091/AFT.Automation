using OpenQA.Selenium;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IWithdrawElement
    {
        /// <summary>
        /// Template Withdraw link element
        /// </summary>
        IWebElement WithdrawLink { get; set; }

        /// <summary>
        /// Template Withdraw amount field element
        /// </summary>
        IWebElement WithdrawAmount { get; set; }

        /// <summary>
        /// Template Withdraw next button element
        /// </summary>
        IWebElement WithdrawNextButton { get; set; }

        /// <summary>
        /// Template Withdraw expiry month field element
        /// </summary>
        IWebElement WithdrawExpiryMonth { get; set; }

        /// <summary>
        /// Template Withdraw expiry year field element
        /// </summary>
        IWebElement WithdrawExpiryYear { get; set; }

        /// <summary>
        /// Template Withdraw security code field element
        /// </summary>
        IWebElement WithdrawSecurityCode { get; set; }

        /// <summary>
        /// Template Withdraw button element
        /// </summary>
        IWebElement WithdrawButton { get; set; }
    }
}
