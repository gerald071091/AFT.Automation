using OpenQA.Selenium;
using System.Collections.Generic;

namespace AFT.Automation.Domain.Interface.Objects
{
	public interface IQuickDepositElement
	{
		/// <summary>
		/// Template QuickDeposit close element
		/// </summary>
		IWebElement QuickDepositCloseButton { get; set; }

		/// <summary>
		/// Template QuickDeposit Neteller tab element
		/// </summary>
		IWebElement QuickDepositNetellerTab { get; set; }

		/// <summary>
		/// Template QuickDeposit neteller amount field element
		/// </summary>
		IWebElement QuickDepositNetellerAmount { get; set; }

		/// <summary>
		/// Template QuickDeposit neteller account ID field element
		/// </summary>
		IWebElement QuickDepositNetellerAccountID { get; set; }

		/// <summary>
		/// Template QuickDeposit neteller authentication code field element
		/// </summary>
		IWebElement QuickDepositNetellerAuthCode { get; set; }

		/// <summary>
		/// Template QuickDeposit Skrill tab element
		/// </summary>
		IWebElement QuickDepositSkrillTab { get; set; }

		/// <summary>
		/// Template QuickDeposit skrill amount field element
		/// </summary>
		IWebElement QuickDepositSkrillAmount { get; set; }

		/// <summary>
		/// Template QuickDeposit credit card tab element
		/// </summary>
		IWebElement QuickDepositCCTab { get; set; }

		/// <summary>
		/// Template QuickDeposit credit card amount field element
		/// </summary>
		IWebElement QuickDepositCCAmount { get; set; }

		/// <summary>
		/// Template QuickDeposit card type selection element
		/// </summary>
		IWebElement QuickDepositCardType { get; set; }

		/// <summary>
		/// Template QuickDeposit card type list element
		/// </summary>
		IList<IWebElement> QuickDepositCardTypeList { get; set; }

		/// <summary>
		/// Template QuickDeposit credit card number field element
		/// </summary>
		IWebElement QuickDepositCCNumber { get; set; }

		/// <summary>
		/// Template QuickDeposit credit card holder fullname field element
		/// </summary>
		IWebElement QuickDepositCCFullName { get; set; }

		/// <summary>
		/// Template QuickDeposit credit card month expiry field element
		/// </summary>
		IWebElement QuickDepositCCMonthExpiry { get; set; }

		/// <summary>
		/// Template QuickDeposit credit card year expiry field element
		/// </summary>
		IWebElement QuickDepositCCYearExpiry { get; set; }

		/// <summary>
		/// Template QuickDeposit credit card security code field element
		/// </summary>
		IWebElement QuickDepositCCSecurityCode { get; set; }

		/// <summary>
		/// Template QuickDeposit creadit card reset element
		/// </summary>
		IWebElement QuickDepositCCResetButton { get; set; }

		/// <summary>
		/// Template QuickDeposit terms and condition checkbox element
		/// </summary>
		IWebElement QuickDepositTermsAndConditionBox { get; set; }

		/// <summary>
		/// Template QuickDeposit submit button element
		/// </summary>
		IWebElement QuickDepositSubmitButton { get; set; }
	}
}
