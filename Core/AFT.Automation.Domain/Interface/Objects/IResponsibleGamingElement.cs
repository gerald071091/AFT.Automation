using OpenQA.Selenium;
using System.Collections.Generic;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IResponsibleGamingElement
    {
        /// <summary>
        /// Template Responsible Gaming link element
        /// </summary>
        IWebElement ResponsibleGamingLink { get; set; }

        /// <summary>
        /// Template Responsible Gaming reality checkbox element
        /// </summary>
        IWebElement RealityCheckBox { get; set; }

        /// <summary>
        /// Template Responsible Gaming reality check selection element
        /// </summary>
        IWebElement RealityCheck { get; set; }

        /// <summary>
        /// Template Responsible Gaming reality check time list element
        /// </summary>
        IList<IWebElement> RealityCheckList { get; set; }

        /// <summary>
        /// Template Responsible Gaming reality check save button element
        /// </summary>
        IWebElement RealityCheckSaveButton { get; set; }

		/// <summary>
		/// Template Responsible Gaming reality check accept button element
		/// </summary>
		IWebElement RealityCheckAcceptButton { get; set; }

        /// <summary>
        /// Template Responsible Gaming deposit limit selection element
        /// </summary>
        IWebElement DepositLimit { get; set; }

        /// <summary>
        /// Template Responsible Gaming deposit limit type list element
        /// </summary>
        IList<IWebElement> DepositLimitList { get; set; }

        /// <summary>
        /// Template Responsible Gaming deposit limit amount field element
        /// </summary>
        IWebElement DepositLimitAmount { get; set; }

        /// <summary>
        /// Template Responsible Gaming deposit limit submit button element
        /// </summary>
        IWebElement DepositLimitSubmitButton { get; set; }

        /// <summary>
        /// Template Responsible Gaming deposit limit cancel pending limit request element
        /// </summary>
        IWebElement DepositLimitCancelButton { get; set; }

        /// <summary>
        /// Template Responsible Gaming timeout checkbox element
        /// </summary>
        IWebElement TimeOutCheckBox { get; set; }

        /// <summary>
        /// Template Responsible Gaming timeout time selection element
        /// </summary>
        IWebElement TimeOut { get; set; }

        /// <summary>
        /// Template Responsible Gaming timeout time list element
        /// </summary>
        IList<IWebElement> TimeOutList { get; set; }

        /// <summary>
        /// Template Responsible Gaming selfexclude checkbox element
        /// </summary>
        IWebElement SelfExcludeCheckBox { get; set; }

        /// <summary>
        /// Template Responsible Gaming selfexclude time selection element
        /// </summary>
        IWebElement SelfExclude { get; set; }

        /// <summary>
        /// Template Responsible Gaming selfexclude time list element
        /// </summary>
        IList<IWebElement> SelfExcludeList { get; set; }

        /// <summary>
        /// Template Responsible Gaming compulsive gambler survey selection element
        /// </summary>
        IList<IWebElement> CompulsiveGambleSelection { get; set; }

        /// <summary>
        /// Template Responsible Gaming Timeout/selfexclude save button element
        /// </summary>
        IWebElement TimeOutSelfExcludeSaveButton { get; set; }

        /// <summary>
        /// Template Responsible Gaming Timeout/selfexclude modal ok button
        /// </summary>
        IWebElement TimeOutSelfExcludeModalOkButton { get; set; }

        /// <summary>
        /// Template Responsible Gaming Complete page title
        /// </summary>
        IWebElement ResponsibleGamingCompleteTitle { get; set; }
    }
}
