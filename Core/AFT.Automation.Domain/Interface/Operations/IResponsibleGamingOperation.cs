namespace AFT.Automation.Domain.Interface.Operations
{
    public interface IResponsibleGamingOperation
    {
        /// <summary>
        /// ResponsibleGamingOperation click responsible gaming link
        /// </summary>
        IResponsibleGamingOperation ClickResponsibleGamingLink();

        /// <summary>
        /// ResponsibleGamingOperation click reality check box
        /// </summary>
        IResponsibleGamingOperation ClickRealityCheckBox();

        /// <summary>
        /// ResponsibleGamingOperation select reality check time list
        /// </summary>
        IResponsibleGamingOperation SelectRealityCheckTime(string realityCheckTime);

        /// <summary>
        /// ResponsibleGamingOperation click reality check save button
        /// </summary>
        IResponsibleGamingOperation ClickRealityCheckSaveButton();

		/// <summary>
		/// ResponsibleGamingOperation click reality check accept button
		/// </summary>
		/// <returns></returns>
		IResponsibleGamingOperation ClickRealityCheckAcceptButton();

        /// <summary>
        /// ResponsibleGamingOperation select deposit limit type
        /// </summary>
        IResponsibleGamingOperation SelectDepositLimitType(string depositLimitType);

        /// <summary>
        /// ResponsibleGamingOperation provide deposit limit amount
        /// </summary>
        IResponsibleGamingOperation ProvideDepositLimitAmount(string amount);

        /// <summary>
        /// ResponsibleGamingOperation click deposit limit submit button
        /// </summary>
        IResponsibleGamingOperation ClickDepositLimitSubmitButton();

        /// <summary>
        /// ResponsibleGamingOperation click deposit limit cancel limit button
        /// </summary>
        IResponsibleGamingOperation ClickDepositLimitCancelButton();

        /// <summary>
        /// ResponsibleGamingOperation click timeout checkbox
        /// </summary>
        IResponsibleGamingOperation ClickTimeOutCheckBox();

        /// <summary>
        /// ResponsibleGamingOperation select timeout time duration
        /// </summary>
        IResponsibleGamingOperation SelectTimeOutTime(string timeOutTime);

        /// <summary>
        /// ResponsibleGamingOperation click selfexclude checkbox
        /// </summary>
        IResponsibleGamingOperation ClickSelfExcludeCheckBox();

        /// <summary>
        /// ResponsibleGamingOperation select selfexclude duration period
        /// </summary>
        IResponsibleGamingOperation SelectSelfExcludeDuration(string selfExcludeTime);

        /// <summary>
        /// ResponsibleGamingOperation select compulsive gambler survey
        /// </summary>
        IResponsibleGamingOperation CompulsiveGamblerSurvey(string isCompulsiveGambler);

        /// <summary>
        /// ResponsibleGamingOperation click timeout/selfexclude save button
        /// </summary>
        IResponsibleGamingOperation ClickTimeOutSelfExcludeSaveButton();

        /// <summary>
        /// ResponsibleGamingOperation click timeout/selfexclude modal ok button
        /// </summary>
        /// <returns></returns>
        IResponsibleGamingOperation ClickTimeOutSelfExcludeModalOkButton();

        /// <summary>
        /// ResponsibleGamingOperation get the page title on complete
        /// </summary>
        /// <returns></returns>
        string GetResponsibleGamingCompleteTitle();
    }
}
