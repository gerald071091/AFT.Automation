using AFT.Automation.Domain.Interface.Operations;

namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public IResponsibleGamingOperation ClickResponsibleGamingLink()
        {
            _action.ClickToElement(_element.ResponsibleGamingLink);

            return this;
        }

        public IResponsibleGamingOperation ClickRealityCheckBox()
        {
			if (!_action.IsElementChecked(_element.RealityCheckBox))
			{
				_action.ClickToElement(_element.RealityCheckBox);
			}
            
            return this;
        }

        public IResponsibleGamingOperation SelectDepositLimitType(string depositLimitType)
        {
            _action.ItemSelectionToElement(_element.DepositLimit, _element.DepositLimitList, depositLimitType);

            return this;
        }

        public IResponsibleGamingOperation ProvideDepositLimitAmount(string amount)
        {
            _action.TypeInputToElement(_element.DepositLimitAmount, amount);

            return this;
        }

        public IResponsibleGamingOperation ClickDepositLimitSubmitButton()
        {
            _action.ClickToElement(_element.DepositLimitSubmitButton);

            return this;
        }

        public IResponsibleGamingOperation ClickDepositLimitCancelButton()
        {
            _action.ClickToElement(_element.DepositLimitCancelButton);

            return this;
        }

        public IResponsibleGamingOperation ClickTimeOutCheckBox()
        {
			if (!_action.IsElementChecked(_element.TimeOutCheckBox))
			{
				_action.ClickToElement(_element.TimeOutCheckBox);
			}
            
            return this;
        }

        public IResponsibleGamingOperation ClickSelfExcludeCheckBox()
        {
			if (!_action.IsElementChecked(_element.SelfExcludeCheckBox))
			{
				_action.ClickToElement(_element.SelfExcludeCheckBox);
			}

            return this;
        }

        public IResponsibleGamingOperation CompulsiveGamblerSurvey(string isCompulsiveGambler)
        {
            _action.ItemSelectionToElement(_element.CompulsiveGambleSelection, isCompulsiveGambler);

            return this;
        }

        public IResponsibleGamingOperation SelectRealityCheckTime(string realityCheckTime)
        {
            _action.ItemSelectionToElement(_element.RealityCheck, _element.RealityCheckList, realityCheckTime);

            return this;
        }

        public IResponsibleGamingOperation ClickRealityCheckSaveButton()
        {
            _action.ClickToElement(_element.RealityCheckSaveButton);

            return this;
        }

		public IResponsibleGamingOperation ClickRealityCheckAcceptButton()
		{
			_action.ClickToElement(_element.RealityCheckAcceptButton);

			return this;
		}


		public IResponsibleGamingOperation SelectTimeOutTime(string timeOutTime)
        {
            _action.ItemSelectionToElement(_element.TimeOut, _element.TimeOutList, timeOutTime);

            return this;
        }

        public IResponsibleGamingOperation SelectSelfExcludeDuration(string selfExcludeTime)
        {
            _action.ItemSelectionToElement(_element.SelfExclude, _element.SelfExcludeList, selfExcludeTime);

            return this;
        }

        public IResponsibleGamingOperation ClickTimeOutSelfExcludeSaveButton()
        {
            _action.ClickToElement(_element.TimeOutSelfExcludeSaveButton);

            return this;
        }

        public IResponsibleGamingOperation ClickTimeOutSelfExcludeModalOkButton()
        {
            _action.ClickToElement(_element.TimeOutSelfExcludeModalOkButton);

            return this;
        }

        public string GetResponsibleGamingCompleteTitle()
        {
            return _action.GetTextInElement(_element.ResponsibleGamingCompleteTitle);
        }
    }
}
