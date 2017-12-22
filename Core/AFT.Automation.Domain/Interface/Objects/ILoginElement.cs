using OpenQA.Selenium;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface ILoginElement
    {
        /// <summary>
        /// Template Login Username element
        /// </summary>
        IWebElement LoginUsername { get; set; }

        /// <summary>
        /// Template Login Password element
        /// </summary>
        IWebElement LoginPassword { get; set; }

        /// <summary>
        /// Template Login button element
        /// </summary>
        IWebElement LoginButton { get; set; }

        /// <summary>
        /// Template Login Header details display element
        /// </summary>
        IWebElement LoginHeaderDetails { get; set; }

        /// <summary>
        /// Template Login Dropdown selection element
        /// </summary>
        IWebElement LoginDetailsDropDown { get; set; }

        /// <summary>
        /// Template Logout element
        /// </summary>
        IWebElement LogoutLink { get; set; }
    }
}
