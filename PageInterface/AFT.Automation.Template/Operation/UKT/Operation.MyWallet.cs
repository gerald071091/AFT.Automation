namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public void ClickMyWalletLink()
        {
            _action.ClickToElement(_element.MyWalletLink);
        }

        public string GetMyWalletMainBalance()
        {
            return _action.GetNumericalTextInElement(_element.MyWalletMainBalance);
        }

        public string GetMyWalletMainWalletBalance()
        {
            return _action.GetNumericalTextInElement(_element.MyWalletMainWalletBalance);
        }
    }
}
