namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public void ClickMyBonusesLink()
        {
            _action.ClickToElement(_element.MyBonusesLink);
        }

        public string GetMyBonusesPlayerFullName()
        {
            return _action.GetTextInElement(_element.MyBonusesFullName);
        }

        public string GetMyBonusesBalances()
        {
            return _action.GetNumericalTextInElement(_element.MyBonusesBalances);
        }

        public string GetMyBonusesBettingBalance()
        {
            return _action.GetNumericalTextInElement(_element.MyBonusesBettingBalance);
        }
    }
}
