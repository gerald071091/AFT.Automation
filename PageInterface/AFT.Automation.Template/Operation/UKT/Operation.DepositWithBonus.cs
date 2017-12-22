using AFT.Automation.Domain.Interface.Operations;

namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public IDepositWithBonusOperation ProvideDepositWithBonusCode(string code)
        {
            _action.TypeInputToElement(_element.DepositWithBonusCode, code);

            return this;
        }

        public IDepositWithBonusOperation SelectDepositWithBonusProduct(string product)
        {
            _action.ItemSelectionToElement(_element.DepositWithBonusProduct, _element.DepositWithBonusProductList, product);

            return this;
        }

        public IDepositWithBonusOperation ClickDepositWithBonusTermsAndCondition()
        {
            _action.ClickToElement(_element.DepositWithBonusTnCCheckBox);

            return this;
        }

        public IDepositWithBonusOperation ClickDepositWithBonusSubscribe()
        {
            _action.ClickToElement(_element.DepositWithBonusSubscribeCheckBox);

            return this;
        }
    }
}
