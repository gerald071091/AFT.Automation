using OpenQA.Selenium;
using System.Collections.Generic;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IDepositWithBonusElement
    {
        /// <summary>
        /// Template DepositWithBonus code field element
        /// </summary>
        IWebElement DepositWithBonusCode { get; set; }

        /// <summary>
        /// Template DepositWithBonus product selection element
        /// </summary>
        IWebElement DepositWithBonusProduct { get; set; }

        /// <summary>
        /// Template DepositWithBonus product list element
        /// </summary>
        IList<IWebElement> DepositWithBonusProductList { get; set; }

        /// <summary>
        /// Template DepositWithBonus terms and condition checkbox element
        /// </summary>
        IWebElement DepositWithBonusTnCCheckBox { get; set; }

        /// <summary>
        /// Template DepositWithBonus bonus subscription checkbox element
        /// </summary>
        IWebElement DepositWithBonusSubscribeCheckBox { get; set; }
    }
}
