namespace AFT.Automation.Domain.Interface.Operations
{
    public interface IMyDetailsOperation
    {
        /// <summary>
        /// MyDetailsOperation Get full name value
        /// </summary>
        string GetMyDetailsFullName();

        /// <summary>
        /// MyDetailsOperation Get login name value
        /// </summary>
        string GetMyDetailsLoginName();

        /// <summary>
        /// MyDetailsOperation Get address value
        /// </summary>
        string GetMyDetailsAddress();

        /// <summary>
        /// MyDetailsOperation Get postal code value
        /// </summary>
        string GetMyDetailsPostalCode();

        /// <summary>
        /// MyDetailsOperation Get city value
        /// </summary>
        string GetMyDetailsCity();

        /// <summary>
        /// MyDetailsOperation Get country value
        /// </summary>
        string GetMyDetailsCountry();

        /// <summary>
        /// MyDetailsOperation Get mobile number value
        /// </summary>
        string GetMyDetailsMobileNumber();

        /// <summary>
        /// MyDetailsOperation Get email address value
        /// </summary>
        string GetMyDetailsEmailAddress();
    }
}
