using OpenQA.Selenium;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IBaseElement :
        IBonusHistoryElement,
        ICasinoElement,
        IChangePasswordElement,
        IDepositElement,
        IDepositWithBonusElement,
        IFooterLinksElement,
        IForgotPasswordElement,
        IGameHistoryElement,
        IHeaderLinksElement,
        ILoginElement,
        IMyBonusesElement,
        IMyDetailsElement,
        IMyWalletElement,
		IQuickDepositElement,
        IRegistrationElement,
        IResponsibleGamingElement,
        ISportsbookElement,
        ITransactionHistoryElement,
        IWithdrawElement
    {
        /// <summary>
        /// Template Common Modal message element that is not certain in any page
        /// </summary>
        IWebElement ModalMessage { get; set; }

        /// <summary>
        /// Template Common Modal submit button element that is not certain in any page
        /// </summary>
        IWebElement ModalOKBtn { get; set; }

        /// <summary>
        /// Template Common MyAccount link element that is certain to other process
        /// </summary>
        IWebElement MyAccountLink { get; set; }

        /// <summary>
        /// Template Common MyDetails link element that is certain to other process.
        /// </summary>
        IWebElement MyDetailsLink { get; set; }

		/// <summary>
		/// Template Common Header Main Wallet element that is diplayed upon login.
		/// </summary>
		IWebElement HeaderMainWallet { get; set; }
    }
}
