using AFT.Automation.Domain.Interface.Operations;

namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public IGameHistoryOperation ClickGameHistoryLink()
        {
            _action.ClickToElement(_element.GameHistoryLink);

            return this;
        }

        public IGameHistoryOperation SelectGameHistoryProduct(string product)
        {
            _action.ItemSelectionToElement(_element.GameHistoryProduct, _element.GameHistoryProductList, product);

            return this;
        }

        public IGameHistoryOperation ProvideGameHistoryGameStartDate(string startDate)
        {
            _action.TypeInputToElement(_element.GameHistoryGameStartDate, startDate);

            return this;
        }

        public IGameHistoryOperation ProvideGameHistoryGameEndDate(string endDate)
        {
            _action.TypeInputToElement(_element.GameHistoryGameEndDate, endDate);

            return this;
        }

        public IGameHistoryOperation SelectGameHistoryTransactionLimit(string transactionLimit)
        {
            _action.ItemSelectionToElement(_element.GameHistoryTransactionLimit, _element.GameHistoryTransactionLimitList, transactionLimit);

            return this;
        }

        public IGameHistoryOperation ClickGameHistorySubmitButton()
        {
            _action.ClickToElement(_element.GameHistorySubmitButton);

            return this;
        }

        public int GameHistoryTableDataCount()
        {
            return _action.GetElementCount(_element.GameHistoryTableData);
        }

    }
}
