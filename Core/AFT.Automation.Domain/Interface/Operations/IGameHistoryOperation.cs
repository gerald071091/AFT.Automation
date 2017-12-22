namespace AFT.Automation.Domain.Interface.Operations
{
    public interface IGameHistoryOperation
    {
        /// <summary>
        /// GameHistoryOperation click game history link
        /// </summary>
        IGameHistoryOperation ClickGameHistoryLink();

        /// <summary>
        /// GameHistoryOperation select game history product
        /// </summary>
        IGameHistoryOperation SelectGameHistoryProduct(string product);

        /// <summary>
        /// GameHistoryOperation provide the start date
        /// </summary>
        IGameHistoryOperation ProvideGameHistoryGameStartDate(string startDate);

        /// <summary>
        /// GameHistoryOperation provide the end date
        /// </summary>
        IGameHistoryOperation ProvideGameHistoryGameEndDate(string endDate);

        /// <summary>
        /// GameHistoryOperation select game history transaction limit
        /// </summary>
        IGameHistoryOperation SelectGameHistoryTransactionLimit(string transactionLimit);

        /// <summary>
        /// GameHistoryOperation click submit button
        /// </summary>
        IGameHistoryOperation ClickGameHistorySubmitButton();

        /// <summary>
        /// GameHistoryOperation return the data count in table result
        /// </summary>
        int GameHistoryTableDataCount();
    }
}
