using AFT.Automation.Domain.Interface.Operations;

namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public IWithdrawOperation ClickWithdrawLink()
        {
            _action.ClickToElement(_element.WithdrawLink);

            return this;
        }

        public IWithdrawOperation ProvideWithdrawAmount(string amount)
        {
            _action.TypeInputToElement(_element.WithdrawAmount, amount);

            return this;
        }

        public IWithdrawOperation ClickWithdrawNextButton()
        {
            _action.ClickToElement(_element.WithdrawNextButton);

            return this;
        }

        public IWithdrawOperation ProvideWithdrawExpiryMonth(string month)
        {
            _action.TypeInputToElement(_element.WithdrawExpiryMonth, month);

            return this;
        }

        public IWithdrawOperation ProvideWithdrawExpiryYear(string year)
        {
            _action.TypeInputToElement(_element.WithdrawExpiryYear, year);

            return this;
        }

        public IWithdrawOperation ProvideWithdrawSecurityCode(string code)
        {
            _action.TypeInputToElement(_element.WithdrawSecurityCode, code);

            return this;
        }

        public IWithdrawOperation ClickWithdrawButton()
        {
            _action.ClickToElement(_element.WithdrawButton);

            return this;
        }
    }
}
