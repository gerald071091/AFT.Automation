namespace AFT.Automation.Domain.Interface.Operations
{
    public interface IBaseOperation: 
        ILoginOperation, 
        IRegistrationOperation,
        IForgotPasswordOperation,
        IChangePasswordOperation,
        IHeaderLinksOperation,
        IMyWalletOperation,
        IDepositOperation,
        IDepositWithBonusOperation,
		IQuickDepositOperation,
        IMyBonusesOperation,
        IBonusHistoryOperation,
        IWithdrawOperation,
        ITransactionHistoryOperation,
        ICasinoOperation,
        ISportsbookOperation,
        IGameHistoryOperation,
        IMyDetailsOperation,
        IResponsibleGamingOperation,
        IFooterLinksOperation
    {
        /// <summary>
        /// Get the message in Modal
        /// </summary>
        /// <returns></returns>
        string ModalMessage();

        /// <summary>
        /// Get the current tab page title
        /// </summary>
        /// <returns></returns>
        string GetCurrentPageTitle();

        /// <summary>
        /// Get the current page url
        /// </summary>
        /// <returns></returns>
        string GetTheCurrentUrl();

        /// <summary>
        /// Click the Submit button in Modal
        /// </summary>
        IBaseOperation ClickAcceptModalButton();

        /// <summary>
        /// Redirect to a certain url
        /// </summary>
        /// <param name="url"></param>
        IBaseOperation Redirect(string url);

		/// <summary>
		/// Switch to next tab
		/// </summary>
		/// <returns></returns>
		IBaseOperation GoToNextTab();

        /// <summary>
        /// Switch to tab containing the new page url using the title page
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        IBaseOperation GoToTab(string title);

        /// <summary>
        /// Switch back to main tab
        /// </summary>
        /// <returns></returns>
        IBaseOperation GoToDefaultTab();

        /// <summary>
        /// Click the My Account link
        /// </summary>
        /// <returns></returns>
        IBaseOperation ClickMyAccountLink();

        /// <summary>
        /// Click the My Details link
        /// </summary>
        /// <returns></returns>
        IBaseOperation ClickMyDetailsLink();

		/// <summary>
		/// Get the Main Wallet balance in header
		/// </summary>
		/// <returns></returns>
		string GetHeaderMainWalletBalance();

        /// <summary>
        /// End the driver session
        /// </summary>
        IBaseOperation Quit();
    }
}
