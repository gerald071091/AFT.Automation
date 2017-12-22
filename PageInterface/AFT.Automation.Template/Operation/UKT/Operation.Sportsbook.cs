namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public bool IsSportsbookIframePresent()
        {
            return _action.IsElementPresent(_element.SportsbookIframe);
        }
    }
}
