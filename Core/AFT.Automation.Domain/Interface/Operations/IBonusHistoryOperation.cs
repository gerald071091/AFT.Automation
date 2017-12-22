namespace AFT.Automation.Domain.Interface.Operations
{
    public interface IBonusHistoryOperation
    {
        /// <summary>
        /// BonusHistoryOperation click Bonus history link
        /// </summary>
        IBonusHistoryOperation ClickBonusHistoryLink();

        /// <summary>
        /// BonusHistoryOperation select bonus history product
        /// </summary>
        IBonusHistoryOperation SelectBonusHistoryProduct(string product);

        /// <summary>
        /// BonusHistoryOperation select bonus history status
        /// </summary>
        IBonusHistoryOperation SelectBonusHistoryStatus(string status);

        /// <summary>
        /// BonusHistoryOperation provide the start date
        /// </summary>
        IBonusHistoryOperation ProvideBonusHistoryStartDate(string startDate);

        /// <summary>
        /// BonusHistoryOperation provide the end date
        /// </summary>
        IBonusHistoryOperation ProvideBonusHistoryEndDate(string endDate);

        /// <summary>
        /// BonusHistoryOperation select bonus history limit
        /// </summary>
        IBonusHistoryOperation SelectBonusHistoryLimit(string limit);

        /// <summary>
        /// BonusHistoryOperation click submit button
        /// </summary>
        IBonusHistoryOperation ClickBonusHistorySubmitButton();

        /// <summary>
        /// BonusHistoryOperation return the data count in table result
        /// </summary>
        int BonusHistoryTableDataCount();
    }
}
