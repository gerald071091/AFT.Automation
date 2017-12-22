using AFT.Automation.Domain.Interface.Operations;

namespace AFT.Automation.Template.Operation.UKT
{
    public partial class Operation
    {
        public IRegistrationOperation ClickJoinNowButton()
        {
            _action.ClickToElement(_element.JoinNowBtn);

            return this;
        }

        public IRegistrationOperation ProvideRegistrationUsername(string newUsername)
        {
            _action.TypeInputToElement(_element.RegistrationNewUsername, newUsername);

            return this;
        }

		public string GetRegistrationUsernameWarningMessage()
		{
			return _action.GetTextInElement(_element.RegistrationNewUsernameWarning);
		}

		public IRegistrationOperation ProvideRegistrationPassword(string newPassword)
        {
            _action.TypeInputToElement(_element.RegistrationNewPassword, newPassword);

            return this;
        }

		public string GetRegistrationPasswordWarningMessage()
		{
			return _action.GetTextInElement(_element.RegistrationNewPasswordWarning);
		}

		public IRegistrationOperation ProvideRegistrationConfirmPassword(string confirmPassword)
        {
            _action.TypeInputToElement(_element.RegistrationNewConfirmPassword, confirmPassword);

            return this;
        }

		public string GetRegistrationConfirmPasswordWarningMessage()
		{
			return _action.GetTextInElement(_element.RegistrationNewConfirmPasswordWarning);
		}

		public IRegistrationOperation SelectTitle(string title)
        {
            _action.ItemSelectionToElement(_element.Title, _element.TitleList, title);

            return this;
        }

        public IRegistrationOperation ProvideRegistrationFirstName(string firstName)
        {
            _action.TypeInputToElement(_element.RegistrationFirstName, firstName);

            return this;
        }

		public string GetRegistrationFirstNameWarningMessage()
		{
			return _action.GetTextInElement(_element.RegistrationFirstNameWarning);
		}

		public IRegistrationOperation ProvideRegistrationMiddleName(string middlenName)
        {
            _action.TypeInputToElement(_element.RegistrationMiddleName, middlenName);

            return this;
        }

		public string GetRegistrationMiddleNameWarningMessage()
		{
			return _action.GetTextInElement(_element.RegistrationMiddleNameWarning);
		}

		public IRegistrationOperation ProvideRegistrationLastName(string lastName)
        {
            _action.TypeInputToElement(_element.RegistrationLastName, lastName);

            return this;
        }

		public string GetRegistrationLastNameWarningMessage()
		{
			return _action.GetTextInElement(_element.RegistrationLastNameWarning);
		}

		public IRegistrationOperation ProvideRegistrationEmail(string email)
        {
            _action.TypeInputToElement(_element.RegistrationEmailAddress, email);

            return this;
        
        }

		public string GetRegistrationEmailWarningMessage()
		{
			return _action.GetTextInElement(_element.RegistrationEmailAddressWarning);
		}

		public IRegistrationOperation ProvideRegistrationMobileNumber(string number)
        {
            _action.TypeInputToElement(_element.RegistrationMobileNumber, number);

            return this;
        }

		public string GetRegistrationMobileNumberWarningMessage()
		{
			return _action.GetTextInElement(_element.RegistrationMobileNumberWarning);
		}

		public IRegistrationOperation ProvideRegistrationAddress1(string address1)
        {
            _action.TypeInputToElement(_element.RegistrationAddressLine1, address1);

            return this;
        }

        public IRegistrationOperation ProvideRegistrationCity(string city)
        {
            _action.TypeInputToElement(_element.RegistrationCity, city);

            return this;
        }

		public string GetRegistrationCityWarningMessage()
		{
			return _action.GetTextInElement(_element.RegistrationCityWarning);
		}

		public IRegistrationOperation ConfirmAgeAndTermsCondition()
		{
			_action.ClickToElement(_element.AgeAndTermsConditionBox);

			return this;
		}

		public IRegistrationOperation ClickRegistrationSubmitButton()
        {
            _action.ClickToElement(_element.RegistrationSubmitButton);

            return this;
        }

        public bool IsRegistrationTitlePresent()
        {
			return _action.IsElementPresent(_element.OpenAccountTitle);
        }

        public IRegistrationOperation SelectSecurityQuestion(string question)
        {
            _action.ItemSelectionToElement(_element.SecurityQuestion, _element.SecurityQuestionList, question);

            return this;
        }

        public IRegistrationOperation ProvideRegistrationSecurityAnswer(string securityAnswer)
        {
            _action.TypeInputToElement(_element.SecurityAnswer, securityAnswer);

            return this;
        }

        public IRegistrationOperation SelectDayOfBirth(string day)
        {
            _action.ItemSelectionToElement(_element.DayOfBirth, _element.DayOfBirthList, day);

            return this;
        }

        public IRegistrationOperation SelectMonthOfBirth(string month)
        {
            _action.ItemSelectionToElement(_element.MonthOfBirth, _element.MonthOfBirthList, month);

            return this;
        }

        public IRegistrationOperation SelectYearOfBirth(string year)
        {
            _action.ItemSelectionToElement(_element.YearOfBirth, _element.YearOfBirthList, year);

            return this;
        }

        public IRegistrationOperation SelectNationality(string nationality)
        {
            _action.ItemSelectionToElement(_element.Nationality, _element.NationalityList, nationality);

            return this;
        }

        public IRegistrationOperation SelectCountry(string country)
        {
            _action.ItemSelectionToElement(_element.Country, _element.CountryList, country);

            return this;
        }

        public IRegistrationOperation SelectCurrency(string currency)
        {
            _action.ItemSelectionToElement(_element.Currency, _element.CurrencyList, currency);

            return this;
        }

        public IRegistrationOperation ClickEnterAddressManually()
        {
            _action.ClickToElement(_element.RegistrationEnterAddressManuallyLink);

            return this;
        }

        public IRegistrationOperation ProvideRegistrationPostalCode(string code)
        {
            _action.TypeInputToElement(_element.RegistrationPostalCode, code);

            return this;
        }

		public string GetRegistrationPostalCodeWarningMessage()
		{
			return _action.GetTextInElement(_element.RegistrationPostalCodeWarning);
		}

		public string GetRegistrationCompleteTitle()
        {
            return _action.GetTextInElement(_element.RegistrationCompleteTitle);
        }

	}
}
