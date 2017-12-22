using AFT.Automation.Domain.Helper;
using AFT.Automation.Domain.Interface.Operations;

namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public IBaseOperation ProvideLoginPassword(string password)
        {
            _action.TypeInputToElement(_element.LoginPassword, password);

            return this;
        }

        public IBaseOperation ProvideLoginUserName(string username)
        {
            _action.TypeInputToElement(_element.LoginUsername, username);

            return this;
        }

        public IBaseOperation ClickLoginButton()
        {
            _action.ClickToElement(_element.LoginButton);

            return this;
        }

        public bool IsLoginHeaderPresent()
        {
			return _action.IsElementPresent(_element.LoginHeaderDetails);
        }

        public IBaseOperation ClickLogoutButton()
        {
            if (_element.IsElementTypeOfInstance("Template1"))
            {
                _action.ClickToElement(_element.LoginDetailsDropDown, _element.LogoutLink);

            }
            else
            {
                _action.ClickToElement(_element.LogoutLink);
            }

            return this;
        }
    }
}
