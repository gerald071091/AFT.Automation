using AFT.Automation.Domain.Interface.Operations;

namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public ITransactionHistoryOperation ProvideTransactionHistoryStartDate(string startDate)
        {
            _action.TypeInputToElement(_element.TransactionHistoryStartDate, startDate);

            return this;
        }

        public ITransactionHistoryOperation ProvideTransationHistoryEndDate(string endDate)
        {
            _action.TypeInputToElement(_element.TransactionHistoryEndDate, endDate);

            return this;
        }

        public ITransactionHistoryOperation ClickTransactionHistorySubmitButton()
        {
            _action.ClickToElement(_element.TransactionHistorySubmitButton);

            return this;
        }

        public ITransactionHistoryOperation ClickTransactionHistoryLink()
        {
            _action.ClickToElement(_element.TransactionHistoryLink);

            return this;
        }

        public ITransactionHistoryOperation SelectTransactionHistoryType(string type)
        {
            _action.ItemSelectionToElement(_element.TransactionHistoryType, _element.TransactionHistoryTypeList, type);

            return this;
        }

        public ITransactionHistoryOperation SelectTransactionHistoryLimit(string limit)
        {
            _action.ItemSelectionToElement(_element.TransactionHistoryLimit, _element.TransactionHistoryLimitList, limit);

            return this;
        }

        public int TransactionHistoryTableDataCount()
        {
            return _action.GetElementCount(_element.TransactionHistoryTableData);
        }
    }
}
