using AFT.Automation.Domain.Interface.Operations;

namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public IForgotPasswordOperation ClickForgotPasswordLink()
        {
            _action.ClickToElement(_element.ForgotPasswordLink);

            return this;
        }

        public IForgotPasswordOperation ProvideForgotPasswordLoginName(string loginName)
        {
            _action.TypeInputToElement(_element.ForgotpasswordLoginName, loginName);

            return this;
        }

        public IForgotPasswordOperation ProvideForgotPasswordEmailAddress(string email)
        {
            _action.TypeInputToElement(_element.ForgotPasswordEmailAddress, email);

            return this;
        }

        public IForgotPasswordOperation ClickForgotPasswordSubmitButton()
        {
            _action.ClickToElement(_element.ForgotPasswordSubmitButton);

            return this;
        }
        
    }
}
