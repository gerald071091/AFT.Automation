using OpenQA.Selenium;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IMyDetailsElement
    {
        /// <summary>
        /// Template MyDetails Full name text element
        /// </summary>
        IWebElement MyDetailsFullName { get; set; }

        /// <summary>
        /// Template MyDetails Login name text element
        /// </summary>
        IWebElement MyDetailsLoginName { get; set; }

        /// <summary>
        /// Template MyDetails Address text element
        /// </summary>
        IWebElement MyDetailsAddress { get; set; }

        /// <summary>
        /// Template MyDetails Postal code text element
        /// </summary>
        IWebElement MyDetailsPostalCode { get; set; }

        /// <summary>
        /// Template MyDetails City text element
        /// </summary>
        IWebElement MyDetailsCity { get; set; }

        /// <summary>
        /// Template MyDetails Country text element
        /// </summary>
        IWebElement MyDetailsCountry { get; set; }

        /// <summary>
        /// Template MyDetails Mobile number text element
        /// </summary>
        IWebElement MyDetailsMobileNumber { get; set; }

        /// <summary>
        /// Template MyDetails Email address text element
        /// </summary>
        IWebElement MyDetailsEmailAddress { get; set; }
    }
}
