namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public bool IsCasinoGameCategoryLoaded()
        {
			return _action.IsElementPresent(_element.CasinoGameCategoryList);
		}
    }
}
