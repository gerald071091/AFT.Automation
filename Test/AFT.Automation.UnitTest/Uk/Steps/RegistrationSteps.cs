using AFT.Automation.Domain.Helper;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "Registration")]
    public class RegistrationSteps : BaseSteps
    {

        [AfterScenario("Registration")]
        public void TearDown()
        {
            _operation.Quit();
        }

        #region Registration_Url_Verification

        [When(@"I click the join now button")]
        public void When_I_Click_The_JoinNow_Button()
        {
            _operation.ClickJoinNowButton();
        }
        
        [Then(@"I should see the registration page")]
        public void Then_I_Should_See_The_Registraion_Page()
        {
            DoesEqual(_operation.IsRegistrationTitlePresent());
        }

        #endregion Registration_Url_Verification

        #region Registration_Scenario

        [Given(@"I click the join now button")]
        public void Given_I_Click_The_JoinNow_Button()
        {
            _operation.ClickJoinNowButton();
        }

		[Given(@"I provide the (.*) depending on (.*)")]
		public void Given_I_Provide_The_Depending_On(List<string> details, string scenario)
		{
			_list = details.ToNormalStringList();

			_dictionary = new Dictionary<string, Action>
			{
				{"RegistrationInvalidUsername(Format)", () => { _operation.ProvideRegistrationUsername(_list[0]).ConfirmAgeAndTermsCondition(); } },
				{"RegistrationInvalidPassword(NotMatched)", () => { _operation.ProvideRegistrationPassword(_list[0]).ProvideRegistrationConfirmPassword(_list[1]).ConfirmAgeAndTermsCondition(); } },
				{"RegistrationInvalidPassword(PasswordLength)", () => { _operation.ProvideRegistrationPassword(_list[0]).ConfirmAgeAndTermsCondition(); } },
				{"RegistrationInvalidEmail(NotValid)", () => { _operation.ProvideRegistrationEmail(_list[0]).ConfirmAgeAndTermsCondition(); } },
				{"RegistrationInvalidMobileNumber(NotValid)", () => { _operation.ProvideRegistrationMobileNumber(_list[0]).ConfirmAgeAndTermsCondition(); } },
				{"RegistrationInvalidPostalCode(NotValid)", () => { _operation.ProvideRegistrationPostalCode(_list[0]).ConfirmAgeAndTermsCondition(); } },
				{"RegistrationInvalidCity(NotValid)", () => { _operation.ProvideRegistrationCity(_list[0]).ConfirmAgeAndTermsCondition(); } },
				{"RegistrationInvalidFirstName(NotValid)", () => { _operation.ProvideRegistrationFirstName(_list[0]).ConfirmAgeAndTermsCondition(); } },
				{"RegistrationInvalidMiddleName(NotValid)", () => { _operation.ProvideRegistrationMiddleName(_list[0]).ConfirmAgeAndTermsCondition(); } },
				{"RegistrationInvalidLastName(NotValid)", () => { _operation.ProvideRegistrationLastName(_list[0]).ConfirmAgeAndTermsCondition(); } }
			};

			_dictionary[scenario]();
		}

		#endregion Registration_Scenario
	}
}
