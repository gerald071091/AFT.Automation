namespace AFT.Automation.Domain.Interface.Operations
{
    public interface IMyBonusesOperation
    {
        /// <summary>
        /// MyBonusesOperation click my bonuses link
        /// </summary>
        void ClickMyBonusesLink();

        /// <summary>
        /// MyBonusesOperation get the players full name
        /// </summary>
        string GetMyBonusesPlayerFullName();

        /// <summary>
        /// MyBonusesOperation get the balances
        /// </summary>
        string GetMyBonusesBalances();

        /// <summary>
        /// MyBonusesOperation get the betting balance
        /// </summary>
        string GetMyBonusesBettingBalance();
    }
}
