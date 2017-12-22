namespace AFT.Automation.Domain.Interface.Operations
{
    public interface IDepositOperation
    {
        /// <summary>
        /// DepositOperation click deposit link
        /// </summary>
        IDepositOperation ClickDepositLink();

        /// <summary>
        /// DepositOperation click neteller checkbox
        /// </summary>
        IDepositOperation ClickDepositNetellerCheckBox();

        /// <summary>
        /// DepositOperation click next button
        /// </summary>
        IDepositOperation ClickDepositNextButton();

        /// <summary>
        /// DepositOperation provide amount in neteller amount field
        /// </summary>
        IDepositOperation ProvideDepositNetellerAmount(string amount);

        /// <summary>
        /// DepositOperation provide account ID in neteller accound ID field
        /// </summary>
        IDepositOperation ProvideDepositNetellerAccountID(string accountID);

        /// <summary>
        /// DepositOperation provide secure ID in neteller secure ID field 
        /// </summary>
        IDepositWithBonusOperation ProvideDepositNetellerSecureID(string secureID);

        /// <summary>
        /// DepositOperation click the neteller home page link
        /// </summary>
        /// <returns></returns>
        IDepositOperation ClickDepositNetellerHomePageLink();

        /// <summary>
        /// DepositOperation click neteller deposit button
        /// </summary>
        IDepositOperation ClickDepositNetellerButton();

        /// <summary>
        /// DepositOperation get neteller reference number
        /// </summary>
        /// <returns></returns>
        string GetDepositNetellerReferenceNumber();
    }
}
