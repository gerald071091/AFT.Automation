using AFT.Automation.Domain.Interface.Operations;

namespace AFT.Automation.Template.Operation.UKT
{
	public partial class Operation
	{
		public IBaseOperation ClickQuickDepositCloseButton()
		{
			_action.ClickToElement(_element.QuickDepositCloseButton);

			return this;
		}

		public IQuickDepositOperation ClickQuickDepositNetellerTab()
		{
			_action.ClickToElement(_element.QuickDepositNetellerTab);

			return this;
		}

		public IQuickDepositOperation ProvideQuickDepositNetellerAmount(string amount)
		{
			_action.TypeInputToElement(_element.QuickDepositNetellerAmount, amount);

			return this;
		}

		public IQuickDepositOperation ProvideQuickDepositNetellerAccountID(string accountID)
		{
			_action.TypeInputToElement(_element.QuickDepositNetellerAccountID, accountID);

			return this;
		}

		public IQuickDepositOperation ProvideQuickDepositNetellerAuthCode(string authCode)
		{
			_action.TypeInputToElement(_element.QuickDepositNetellerAuthCode, authCode);

			return this;
		}

		public IQuickDepositOperation ClickQuickDepositSkrillTab()
		{
			_action.ClickToElement(_element.QuickDepositSkrillTab);

			return this;
		}

		public IQuickDepositOperation ProvideQuickDepositSkrillAmount(string amount)
		{
			_action.TypeInputToElement(_element.QuickDepositSkrillAmount, amount);

			return this;
		}

		public IQuickDepositOperation ClickQuickDepositCCTab()
		{
			_action.ClickToElement(_element.QuickDepositCCTab);

			return this;
		}

		public IQuickDepositOperation ProvideQuickDepositCCAmount(string amount)
		{
			_action.TypeInputToElement(_element.QuickDepositCCAmount, amount);

			return this;
		}

		public IQuickDepositOperation SelectQuickDepositCardType(string type)
		{
			_action.ItemSelectionToElement(_element.QuickDepositCardType, _element.QuickDepositCardTypeList, type);

			return this;
		}

		public IQuickDepositOperation ProvideQuickDepositCCNumber(string number)
		{
			_action.TypeInputToElement(_element.QuickDepositCCNumber, number);

			return this;
		}

		public IQuickDepositOperation ProvideQuickDepositCCFullName(string name)
		{
			_action.TypeInputToElement(_element.QuickDepositCCFullName, name);

			return this;
		}

		public IQuickDepositOperation ProvideQuickDepositCCMonthExpiry(string month)
		{
			_action.TypeInputToElement(_element.QuickDepositCCMonthExpiry, month);

			return this;
		}

		public IQuickDepositOperation ProvideQuickDepositCCYearExpiry(string year)
		{
			_action.TypeInputToElement(_element.QuickDepositCCYearExpiry, year);

			return this;
		}

		public IQuickDepositOperation ProvideQuickDepositCCSecurityCode(string code)
		{
			_action.TypeInputToElement(_element.QuickDepositCCSecurityCode, code);

			return this;
		}

		public IQuickDepositOperation ClickQuickDepositCCResetButton()
		{
			_action.ClickToElement(_element.QuickDepositCCResetButton);

			return this;
		}

		public IQuickDepositOperation ClickQuickDepositTermsAndConditionBox()
		{
			_action.ClickToElement(_element.QuickDepositTermsAndConditionBox);

			return this;
		}

		public IQuickDepositOperation ClickQuickDepositSubmitButton()
		{
			_action.ClickToElement(_element.QuickDepositSubmitButton);

			return this;
		}
	}
}
