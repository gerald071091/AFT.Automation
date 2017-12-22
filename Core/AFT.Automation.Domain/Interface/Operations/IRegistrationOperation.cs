namespace AFT.Automation.Domain.Interface.Operations
{
    public interface IRegistrationOperation
    {
        /// <summary>
        /// RegistrationOperation click joinNow button
        /// </summary>
        IRegistrationOperation ClickJoinNowButton();

        /// <summary>
        /// RegistrationOperation check if registration page "open title" header is display/present
        /// </summary>
        /// <returns></returns>
        bool IsRegistrationTitlePresent();

        /// <summary>
        /// RegistrationOperation provide new username
        /// </summary>
        /// <param name="newUsername"></param>
        IRegistrationOperation ProvideRegistrationUsername(string newUsername);

		/// <summary>
		/// RegistrationOperation get username warning message
		/// </summary>
		/// <returns></returns>
		string GetRegistrationUsernameWarningMessage();

        /// <summary>
        /// RegistrationOperation provide new password
        /// </summary>
        /// <param name="newPassword"></param>
        IRegistrationOperation ProvideRegistrationPassword(string newPassword);

		/// <summary>
		/// RegistrationOperation get password warning message
		/// </summary>
		/// <returns></returns>
		string GetRegistrationPasswordWarningMessage();

        /// <summary>
        /// RegistrationOperation provide new confirm password
        /// </summary>
        /// <param name="confirmPassword"></param>
        IRegistrationOperation ProvideRegistrationConfirmPassword(string confirmPassword);

		/// <summary>
		/// RegistrationOperation get confirm password warning message
		/// </summary>
		/// <returns></returns>
		string GetRegistrationConfirmPasswordWarningMessage();

        /// <summary>
        /// RegistrationOperation select security question
        /// </summary>
        /// <param name="question"></param>
        IRegistrationOperation SelectSecurityQuestion(string question);

        /// <summary>
        /// RegistrationOperation provide security question answer
        /// </summary>
        /// <param name="securityAnswer"></param>
        IRegistrationOperation ProvideRegistrationSecurityAnswer(string securityAnswer);

        /// <summary>
        /// RegistrationOperation select  new user title
        /// </summary>
        /// <param name="title"></param>
        IRegistrationOperation SelectTitle(string title);

        /// <summary>
        /// RegistrationOperation provide new user first name
        /// </summary>
        /// <param name="firstName"></param>
        IRegistrationOperation ProvideRegistrationFirstName(string firstName);

		/// <summary>
		/// RegistrationOperation get first name warning message
		/// </summary>
		/// <returns></returns>
		string GetRegistrationFirstNameWarningMessage();

        /// <summary>
        /// RegistrationOperation provide new user middle name
        /// </summary>
        /// <param name="middlenName"></param>
        IRegistrationOperation ProvideRegistrationMiddleName(string middlenName);

		/// <summary>
		/// RegistrationOperation get middle name warning message
		/// </summary>
		/// <returns></returns>
		string GetRegistrationMiddleNameWarningMessage();

        /// <summary>
        /// RegistrationOperation provide new user last name
        /// </summary>
        /// <param name="lastName"></param>
        IRegistrationOperation ProvideRegistrationLastName(string lastName);

		/// <summary>
		/// RegistrationOperation get last name warning message
		/// </summary>
		/// <returns></returns>
		string GetRegistrationLastNameWarningMessage();

        /// <summary>
        /// RegistrationOperation select day of birth
        /// </summary>
        /// <param name="day"></param>
        IRegistrationOperation SelectDayOfBirth(string day);

        /// <summary>
        /// RegistrationOperation select month of birth
        /// </summary>
        /// <param name="month"></param>
        IRegistrationOperation SelectMonthOfBirth(string month);

        /// <summary>
        /// RegistrationOperation select year of birth
        /// </summary>
        /// <param name="year"></param>
        IRegistrationOperation SelectYearOfBirth(string year);

        /// <summary>
        /// RegistrationOperation select new user nationality
        /// </summary>
        /// <param name="nationality"></param>
        IRegistrationOperation SelectNationality(string nationality);

        /// <summary>
        /// RegistrationOperation provide new user email
        /// </summary>
        /// <param name="email"></param>
        IRegistrationOperation ProvideRegistrationEmail(string email);

		/// <summary>
		/// RegistrationOperation get email warning message
		/// </summary>
		/// <returns></returns>
		string GetRegistrationEmailWarningMessage();

        /// <summary>
        /// RegistrationOperation select country
        /// </summary>
        /// <param name="country"></param>
        IRegistrationOperation SelectCountry(string country);

        /// <summary>
        /// RegistrationOperation select currency
        /// </summary>
        /// <param name="currency"></param>
        IRegistrationOperation SelectCurrency(string currency);

        /// <summary>
        /// RegistrationOperation provide new user mobile number
        /// </summary>
        /// <param name="number"></param>
        IRegistrationOperation ProvideRegistrationMobileNumber(string number);

		/// <summary>
		/// RegistrationOperation get mobile number warning message
		/// </summary>
		/// <returns></returns>
		string GetRegistrationMobileNumberWarningMessage();

        /// <summary>
        /// RegistrationOperation click enter address manually
        /// </summary>
        /// <returns></returns>
        IRegistrationOperation ClickEnterAddressManually();

        /// <summary>
        /// RegistrationOperation provide new user postal code
        /// </summary>
        /// <param name="code"></param>
        IRegistrationOperation ProvideRegistrationPostalCode(string code);

		/// <summary>
		/// RegistrationOperation get postal code warning message
		/// </summary>
		/// <returns></returns>
		string GetRegistrationPostalCodeWarningMessage();

        /// <summary>
        /// RegistrationOperation provide new user address line 1
        /// </summary>
        /// <param name="address1"></param>
        IRegistrationOperation ProvideRegistrationAddress1(string address1);

        /// <summary>
        /// RegistrationOperation provide new user city
        /// </summary>
        /// <param name="city"></param>
        IRegistrationOperation ProvideRegistrationCity(string city);

		/// <summary>
		/// RegistrationOperation get city warning message
		/// </summary>
		/// <returns></returns>
		string GetRegistrationCityWarningMessage();
		
		/// <summary>
		/// RegistrationOperation confirm the age and terms condition checkbox
		/// </summary>
		/// <returns></returns>
		IRegistrationOperation ConfirmAgeAndTermsCondition();

        /// <summary>
        /// RegistrationOperation click submit button
        /// </summary>
        IRegistrationOperation ClickRegistrationSubmitButton();

        /// <summary>
        /// RegistrationOperation get title page on complete
        /// </summary>
        /// <returns></returns>
        string GetRegistrationCompleteTitle();
    }
}
