namespace AFT.Automation.Domain.Interface.Operations
{
    public interface IWithdrawOperation
    {
        /// <summary>
        /// WithdrawOperation click withdraw link
        /// </summary>
        IWithdrawOperation ClickWithdrawLink();

        /// <summary>
        /// WithdrawOperation provide amount to be withdraw
        /// </summary>
        IWithdrawOperation ProvideWithdrawAmount(string amount);

        /// <summary>
        /// WithdrawOperation click next button
        /// </summary>
        IWithdrawOperation ClickWithdrawNextButton();

        /// <summary>
        /// WithdrawOperation provide the expiry month
        /// </summary>
        IWithdrawOperation ProvideWithdrawExpiryMonth(string month);

        /// <summary>
        /// WithdrawOperation provide the expiry year
        /// </summary>
        IWithdrawOperation ProvideWithdrawExpiryYear(string year);

        /// <summary>
        /// WithdrawOperation provide the security code
        /// </summary>
        IWithdrawOperation ProvideWithdrawSecurityCode(string code);

        /// <summary>
        /// WithdrawOperation click withdraw button
        /// </summary>
        IWithdrawOperation ClickWithdrawButton();
    }
}
