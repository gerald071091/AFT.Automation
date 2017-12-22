namespace AFT.Automation.Domain.Interface.Operations
{
    public interface ITransactionHistoryOperation
    {
        /// <summary>
        /// TransactionHistoryOperation click transaction history link
        /// </summary>
        ITransactionHistoryOperation ClickTransactionHistoryLink();

        /// <summary>
        /// TransactionHistoryOperation select transaction history type
        /// </summary>
        ITransactionHistoryOperation SelectTransactionHistoryType(string type);

        /// <summary>
        /// TransactionHistoryOperation select transaction history limit
        /// </summary>
        ITransactionHistoryOperation SelectTransactionHistoryLimit(string limit);

        /// <summary>
        /// TransactionHistoryOperation provide the start date
        /// </summary>
        ITransactionHistoryOperation ProvideTransactionHistoryStartDate(string startDate);

        /// <summary>
        /// TransactionHistoryOperation provide the end date
        /// </summary>
        ITransactionHistoryOperation ProvideTransationHistoryEndDate(string endDate);

        /// <summary>
        /// TransactionHistoryOperation click submit button
        /// </summary>
        ITransactionHistoryOperation ClickTransactionHistorySubmitButton();

        /// <summary>
        /// TransactionHistoryOperation return the data count in table result
        /// </summary>
        int TransactionHistoryTableDataCount();
    }
}
