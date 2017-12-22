using OpenQA.Selenium;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IDepositElement
    {
        /// <summary>
        /// Template Deposit link element
        /// </summary>
        IWebElement DepositLink { get; set; }

        /// <summary>
        /// Template Deposit neteller checkbox element
        /// </summary>
        IWebElement DepositNetellerCheckBox { get; set; }

        /// <summary>
        /// Template Deposit next button element
        /// </summary>
        IWebElement DepositNextButton { get; set; }

        /// <summary>
        /// Template Deposit neteller amount field element
        /// </summary>
        IWebElement DepositNetellerAmount { get; set; }

        /// <summary>
        /// Template Deposit neteller account ID field element
        /// </summary>
        IWebElement DepositNetellerAccountID { get; set; }

        /// <summary>
        /// Template Deposit neteller secure ID field element
        /// </summary>
        IWebElement DepositNetellerSecureID { get; set; }

        /// <summary>
        /// Template Deposit neteller home page link element
        /// </summary>
        IWebElement DepositNetellerHomePageLink { get; set; }

        /// <summary>
        /// Template Deposit neteller deposit button element
        /// </summary>
        IWebElement DepositNetellerDepositButton { get; set; }

        /// <summary>
        /// Template Deposit neteller reference number
        /// </summary>
        IWebElement DepositNetellerReferenceNumber { get; set; }
    }
}
