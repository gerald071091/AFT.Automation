using OpenQA.Selenium;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IMyWalletElement
    {
        /// <summary>
        /// Template MyWallet link
        /// </summary>
        IWebElement MyWalletLink { get; set; }

        /// <summary>
        /// Template MyWallet main balance
        /// </summary>
        IWebElement MyWalletMainBalance { get; set; }

        /// <summary>
        /// Template MyWallet main wallet balance
        /// </summary>
        IWebElement MyWalletMainWalletBalance { get; set; }
    }
}
