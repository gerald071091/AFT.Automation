using OpenQA.Selenium;
using System.Collections.Generic;

namespace AFT.Automation.Domain.Interface.Objects
{
    public interface IRegistrationElement
    {
        /// <summary>
        /// Template Registration Join now button element
        /// </summary>
        IWebElement JoinNowBtn { get; set; }

        /// <summary>
        /// Template Registration page Open Account title element
        /// </summary>
        IWebElement OpenAccountTitle { get; set; }

        /// <summary>
        /// Template Registration page login details username element
        /// </summary>
        IWebElement RegistrationNewUsername { get; set; }

		/// <summary>
		/// Template Registration page login details username warning element
		/// </summary>
		IWebElement RegistrationNewUsernameWarning { get; set; }

        /// <summary>
        /// Template Registration page login details password element
        /// </summary>
        IWebElement RegistrationNewPassword { get; set; }

		/// <summary>
		/// Template Registration page login details password warning element
		/// </summary>
		IWebElement RegistrationNewPasswordWarning { get; set; }

        /// <summary>
        /// Template Registration page login details confirm password element
        /// </summary>
        IWebElement RegistrationNewConfirmPassword { get; set; }

		/// <summary>
		/// Template Registration page login details confirm password warning element
		/// </summary>
		IWebElement RegistrationNewConfirmPasswordWarning { get; set; }

        /// <summary>
        /// Template Registration page login details security question element
        /// </summary>
        IWebElement SecurityQuestion { get; set; }

        /// <summary>
        /// Template Registration page login details security question list element
        /// </summary>
        IList<IWebElement> SecurityQuestionList { get; set; }

        /// <summary>
        /// Template Registration page login details security answer element
        /// </summary>
        IWebElement SecurityAnswer { get; set; }

        /// <summary>
        /// Template Registration page personal details title element
        /// </summary>
        IWebElement Title { get; set; }

        /// <summary>
        /// Template Registration page personal details title list element
        /// </summary>
        IList<IWebElement> TitleList { get; set; }

        /// <summary>
        /// Template Registration page personal details first name element
        /// </summary>
        IWebElement RegistrationFirstName { get; set; }

		/// <summary>
		/// Template Registration page personal details first name warning element
		/// </summary>
		IWebElement RegistrationFirstNameWarning { get; set; }

        /// <summary>
        /// Template Registration page personal details middle name element
        /// </summary>
        IWebElement RegistrationMiddleName { get; set; }

		/// <summary>
		/// Template Registration page personal details middle name warning element
		/// </summary>
		IWebElement RegistrationMiddleNameWarning { get; set; }

        /// <summary>
        /// Template Registration page personal details last name element
        /// </summary>
        IWebElement RegistrationLastName { get; set; }

		/// <summary>
		/// Template Registration page personal details last name warning element
		/// </summary>
		IWebElement RegistrationLastNameWarning { get; set; }

        /// <summary>
        /// Template Registraion page personal details day of birth element
        /// </summary>
        IWebElement DayOfBirth { get; set; }

        /// <summary>
        /// Template Registration page personal details day of birth list element
        /// </summary>
        IList<IWebElement> DayOfBirthList { get; set; }

        /// <summary>
        /// Template Registration page personal details month of birth element
        /// </summary>
        IWebElement MonthOfBirth { get; set; }

        /// <summary>
        /// Template Registration page personal details month of birth list element
        /// </summary>
        IList<IWebElement> MonthOfBirthList { get; set; }

        /// <summary>
        /// Template Registration page personal details year of birth element
        /// </summary>
        IWebElement YearOfBirth { get; set; }

        /// <summary>
        /// Template Registration page personal details year of birth list element
        /// </summary>
        IList<IWebElement> YearOfBirthList { get; set; }

        /// <summary>
        /// Template Registration page personal details nationality element
        /// </summary>
        IWebElement Nationality { get; set; }

        /// <summary>
        /// Template Registration page personal details nationality list element
        /// </summary>
        IList<IWebElement> NationalityList { get; set; }

        /// <summary>
        /// Template Registration page personal details email address element
        /// </summary>
        IWebElement RegistrationEmailAddress { get; set; }

		/// <summary>
		/// Template Registration page personal details email address warning element
		/// </summary>
		IWebElement RegistrationEmailAddressWarning { get; set; }

        /// <summary>
        /// Template Registration page personal details country element
        /// </summary>
        IWebElement Country { get; set; }

        /// <summary>
        /// Template Registration page personal details country list element
        /// </summary>
        IList<IWebElement> CountryList { get; set; }

        /// <summary>
        /// Template Registration page personal details currency element
        /// </summary>
        IWebElement Currency { get; set; }

        /// <summary>
        /// Template Registration page personal details currency list element
        /// </summary>
        IList<IWebElement> CurrencyList { get; set; }

        /// <summary>
        /// Template Registration page personal details mobile number element
        /// </summary>
        IWebElement RegistrationMobileNumber { get; set; }

		/// <summary>
		/// Template Registration page personal details mobile number warning element
		/// </summary>
		IWebElement RegistrationMobileNumberWarning { get; set; }

        /// <summary>
        /// Template Registration page enter address manually link element
        /// </summary>
        IWebElement RegistrationEnterAddressManuallyLink { get; set; }

        /// <summary>
        /// Temaplate Registration page personal details postal code element
        /// </summary>
        IWebElement RegistrationPostalCode { get; set; }

		/// <summary>
		/// Template Registration page personal details postal code warning element
		/// </summary>
		IWebElement RegistrationPostalCodeWarning { get; set; }

        /// <summary>
        /// Template Registration page personal details address line 1 element
        /// </summary>
        IWebElement RegistrationAddressLine1 { get; set; }

        /// <summary>
        /// Template Registration page personal details city element
        /// </summary>
        IWebElement RegistrationCity { get; set; }

		/// <summary>
		/// Template Registration page personal details city warning element
		/// </summary>
		IWebElement RegistrationCityWarning { get; set; }

		/// <summary>
		/// Template Registration page declaration age and terms condition element
		/// </summary>
		IWebElement AgeAndTermsConditionBox { get; set; }

        /// <summary>
        /// Template Registration page submit button element
        /// </summary>
        IWebElement RegistrationSubmitButton { get; set; }

        /// <summary>
        /// Template Registration complete page title
        /// </summary>
        IWebElement RegistrationCompleteTitle { get; set; }
    }
}
