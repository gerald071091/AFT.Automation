using OpenQA.Selenium;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IMyBonusesElement
    {
        /// <summary>
        /// Template MyBonuses link element
        /// </summary>
        IWebElement MyBonusesLink { get; set; }

        /// <summary>
        /// Template MyBonuses players fullname element
        /// </summary>
        IWebElement MyBonusesFullName { get; set; }

        /// <summary>
        /// Template MyBonuses balances element
        /// </summary>
        IWebElement MyBonusesBalances { get; set; }

        /// <summary>
        /// Template MyBonuses betting balances element
        /// </summary>
        IWebElement MyBonusesBettingBalance { get; set; }
    }
}
