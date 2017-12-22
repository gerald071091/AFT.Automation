namespace AFT.Automation.Domain.Interface.Operations
{
    public interface IMyWalletOperation
    {
        /// <summary>
        /// MyWalletOperation click mywallet link
        /// </summary>
        void ClickMyWalletLink();

        /// <summary>
        /// MyWalletOperation get main balance
        /// </summary>
        /// <returns></returns>
        string GetMyWalletMainBalance();

        /// <summary>
        /// MyWalletOperation get main wallet balance
        /// </summary>
        /// <returns></returns>
        string GetMyWalletMainWalletBalance(); 
    }
}
