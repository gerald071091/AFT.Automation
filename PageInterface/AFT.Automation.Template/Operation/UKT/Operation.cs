using System;
using AFT.Automation.Domain.Factory;
using AFT.Automation.Domain.Helper;
using AFT.Automation.Domain.Interface.Miscellaneous;
using AFT.Automation.Domain.Interface.Objects;
using AFT.Automation.Domain.Interface.Operations;
using OpenQA.Selenium;

namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation : PageBaseFactory, IBaseOperation
    {
        public Operation(IWebDriver driver, IActionProvider action, IBaseElement element)
            : base(driver, action, element)
        {
        }

        public IBaseOperation Redirect(string url)
        {
            _action.RedirectTo(url);

            return this;
        }

		public IBaseOperation GoToNextTab()
		{
			_action.SwitchToNextWindow();

			return this;
		}

		public IBaseOperation GoToTab(string title)
        {
            _action.SwitchToWindow(page => page.Title == title);

            return this;
        }

        public IBaseOperation GoToDefaultTab()
        {
            _action.SwitchToDefault();

            return this;
        }

        public IBaseOperation ClickMyAccountLink()
        {
            if (_element.IsElementTypeOfInstance("Template1"))
            {
                _action.ClickToElement(_element.LoginDetailsDropDown, _element.MyAccountLink);
            }
            else
            {
                _action.ClickToElement(_element.MyAccountLink);
            }
            
            return this;
        }

		public string GetHeaderMainWalletBalance()
		{
			return _action.GetFluentNumericalTextInElement(_element.HeaderMainWallet);
		}

		public string GetCurrentPageTitle()
        {
            return _action.GetCurrentPageTitle();
        }

        public string GetTheCurrentUrl()
        {
            return _action.GetCurrentPageUrl();
        }

        public IBaseOperation ClickMyDetailsLink()
        {
            _action.ClickToElement(_element.MyDetailsLink);

            return this;
        }

        public IBaseOperation Quit()
        {
            _action.Quit();

            return this;
        }

        #region Modal

        public string ModalMessage()
        {
            return _action.GetTextInElement(_element.ModalMessage);
        }

        public IBaseOperation ClickAcceptModalButton()
        {
            _action.ClickToElement(_element.ModalOKBtn);

            return this;

        }

		#endregion Modal
	}
}
