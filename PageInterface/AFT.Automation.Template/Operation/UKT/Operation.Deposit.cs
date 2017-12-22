using AFT.Automation.Domain.Helper;
using AFT.Automation.Domain.Interface.Operations;

namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public IDepositOperation ProvideDepositNetellerAmount(string amount)
        {
            _action.TypeInputToElement(_element.DepositNetellerAmount, amount);

            return this;
        }

        public IDepositOperation ProvideDepositNetellerAccountID(string accountID)
        {
            _action.TypeInputToElement(_element.DepositNetellerAccountID, accountID);

            return this;
        }

        public IDepositWithBonusOperation ProvideDepositNetellerSecureID(string secureID)
        {
            _action.TypeInputToElement(_element.DepositNetellerSecureID, secureID);

            return this;
        }

        public IDepositOperation ClickDepositLink()
        {
			if (_element.IsElementTypeOfInstance("Template1"))
			{
				_action.ClickToElement(_element.LoginDetailsDropDown, _element.DepositLink);
			}
			else
			{
				_action.ClickToElement(_element.DepositLink);
			}

            return this;
        }

        public IDepositOperation ClickDepositNetellerCheckBox()
        {
            _action.ClickToElement(_element.DepositNetellerCheckBox);

            return this;
        }

        public IDepositOperation ClickDepositNextButton()
        {
            _action.ClickToElement(_element.DepositNextButton);

            return this;
        }

        public IDepositOperation ClickDepositNetellerHomePageLink()
        {
            _action.ClickToElement(_element.DepositNetellerHomePageLink);

            return this;
        }

        public IDepositOperation ClickDepositNetellerButton()
        {
            _action.ClickToElement(_element.DepositNetellerDepositButton);

            return this;
        }

        public string GetDepositNetellerReferenceNumber()
        {
            return _action.GetTextInElement(_element.DepositNetellerReferenceNumber);
        }
    }
}
