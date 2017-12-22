using AFT.Automation.Domain.Interface.Operations;

namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public IChangePasswordOperation ProvideChangePasswordCurrent(string currentPassword)
        {
            _action.TypeInputToElement(_element.ChangePasswordCurrentField, currentPassword);

            return this;
        }

        public IChangePasswordOperation ProvideChangePasswordNew(string newPassword)
        {
            _action.TypeInputToElement(_element.ChangePasswordNewField, newPassword);

            return this;
        }

        public IChangePasswordOperation ProvideChangePasswordConfirm(string confirmPassword)
        {
            _action.TypeInputToElement(_element.ChangePasswordConfirmField, confirmPassword);

            return this;
        }

        public IChangePasswordOperation ClickChangePasswordButton()
        {
            _action.ClickToElement(_element.ChangePasswordButton);

            return this;
        }

        public IChangePasswordOperation ClickChangePasswordUpdateButton()
        {
            _action.ClickToElement(_element.ChangePasswordUpdateButton);

            return this;
        }
    }
}
