namespace AFT.Automation.Domain.Interface.Operations
{
	public interface IQuickDepositOperation
	{
		/// <summary>
		/// QuickDepositOperation close the modal
		/// </summary>
		/// <returns></returns>
		IBaseOperation ClickQuickDepositCloseButton();

		/// <summary>
		/// QuickDepositOperation click the neteller tab
		/// </summary>
		/// <returns></returns>
		IQuickDepositOperation ClickQuickDepositNetellerTab();

		/// <summary>
		/// QuickDepositOperation provide the neteller amount
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		IQuickDepositOperation ProvideQuickDepositNetellerAmount(string amount);

		/// <summary>
		/// QuickDepositOperation provide the neteller account ID
		/// </summary>
		/// <param name="accountID"></param>
		/// <returns></returns>
		IQuickDepositOperation ProvideQuickDepositNetellerAccountID(string accountID);

		/// <summary>
		/// QuickDepositOperation provide the neteller auth code
		/// </summary>
		/// <param name="authCode"></param>
		/// <returns></returns>
		IQuickDepositOperation ProvideQuickDepositNetellerAuthCode(string authCode);

		/// <summary>
		/// QuickDepositOperation click the skrill tab
		/// </summary>
		/// <returns></returns>
		IQuickDepositOperation ClickQuickDepositSkrillTab();

		/// <summary>
		/// QuickDepositOperation provide the skrill amount
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		IQuickDepositOperation ProvideQuickDepositSkrillAmount(string amount);

		/// <summary>
		/// QuickDepositOperation click the credit card tab
		/// </summary>
		/// <returns></returns>
		IQuickDepositOperation ClickQuickDepositCCTab();

		/// <summary>
		/// QuickDepositOperation provide the credit card amount
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		IQuickDepositOperation ProvideQuickDepositCCAmount(string amount);

		/// <summary>
		/// QuickDepositOperation select card type
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		IQuickDepositOperation SelectQuickDepositCardType(string type);

		/// <summary>
		/// QuickDepositOperation provide the credit card number
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		IQuickDepositOperation ProvideQuickDepositCCNumber(string number);

		/// <summary>
		/// QuickDepositOperation provide the credit card holder fullname
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		IQuickDepositOperation ProvideQuickDepositCCFullName(string name);

		/// <summary>
		/// QuickDepositOperation provide the credit card month expiration
		/// </summary>
		/// <param name="month"></param>
		/// <returns></returns>
		IQuickDepositOperation ProvideQuickDepositCCMonthExpiry(string month);

		/// <summary>
		/// QuickDepositOperation provide the credit card year expiration
		/// </summary>
		/// <param name="year"></param>
		/// <returns></returns>
		IQuickDepositOperation ProvideQuickDepositCCYearExpiry(string year);

		/// <summary>
		/// QuickDepositOperation provide the credit card security code
		/// </summary>
		/// <param name="code"></param>
		/// <returns></returns>
		IQuickDepositOperation ProvideQuickDepositCCSecurityCode(string code);

		/// <summary>
		/// QuickDepositOperation click the credit card reset
		/// </summary>
		/// <returns></returns>
		IQuickDepositOperation ClickQuickDepositCCResetButton();

		/// <summary>
		/// QuickDepositOperation click terms and condition checkbox
		/// </summary>
		/// <returns></returns>
		IQuickDepositOperation ClickQuickDepositTermsAndConditionBox();

		/// <summary>
		/// QuickDepositOperation click the submit button
		/// </summary>
		/// <returns></returns>
		IQuickDepositOperation ClickQuickDepositSubmitButton();

	}
}
