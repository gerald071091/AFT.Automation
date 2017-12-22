namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public string GetMyDetailsFullName()
        {
            return _action.GetTextInElement(_element.MyDetailsFullName);
        }

        public string GetMyDetailsLoginName()
        {
            return _action.GetTextInElement(_element.MyDetailsLoginName);
        }

        public string GetMyDetailsAddress()
        {
            return _action.GetTextInElement(_element.MyDetailsAddress);
        }

        public string GetMyDetailsPostalCode()
        {
            return _action.GetTextInElement(_element.MyDetailsPostalCode);
        }

        public string GetMyDetailsCity()
        {
            return _action.GetTextInElement(_element.MyDetailsCity);
        }

        public string GetMyDetailsCountry()
        {
            return _action.GetTextInElement(_element.MyDetailsCountry);
        }

        public string GetMyDetailsMobileNumber()
        {
            return _action.GetTextInElement(_element.MyDetailsMobileNumber);
        }

        public string GetMyDetailsEmailAddress()
        {
            return _action.GetTextInElement(_element.MyDetailsEmailAddress);
        }
    }
}
