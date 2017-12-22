using AFT.Automation.Domain.Interface.Operations;

namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public IBonusHistoryOperation ClickBonusHistoryLink()
        {
            _action.ClickToElement(_element.BonusHistoryLink);

            return this;
        }

        public IBonusHistoryOperation SelectBonusHistoryProduct(string product)
        {
            _action.ItemSelectionToElement(_element.BonusHistoryProduct, _element.BonusHistoryProductList, product);

            return this;
        }

        public IBonusHistoryOperation SelectBonusHistoryStatus(string status)
        {
            _action.ItemSelectionToElement(_element.BonusHistoryStatus, _element.BonusHistoryStatusList, status);

            return this;
        }

        public IBonusHistoryOperation ProvideBonusHistoryStartDate(string startDate)
        {
            _action.TypeInputToElement(_element.BonusHistoryStartDate, startDate);

            return this;
        }

        public IBonusHistoryOperation ProvideBonusHistoryEndDate(string endDate)
        {
            _action.TypeInputToElement(_element.BonusHistoryEndDate, endDate);

            return this;
        }

        public IBonusHistoryOperation SelectBonusHistoryLimit(string limit)
        {
            _action.ItemSelectionToElement(_element.BonusHistoryLimit, _element.BonusHistoryLimitList, limit);

            return this;
        }

        public IBonusHistoryOperation ClickBonusHistorySubmitButton()
        {
            _action.ClickToElement(_element.BonusHistorySubmitButton);

            return this;
        }

        public int BonusHistoryTableDataCount()
        {
            return _action.GetElementCount(_element.BonusHistoryTableData);
        }
    }
}
