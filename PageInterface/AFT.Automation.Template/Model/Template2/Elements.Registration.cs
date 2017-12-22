using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace AFT.Automation.Template.Model.Template2
{
    public partial class Elements
    {
		[FindsBy(How = How.Id, Using = RegistrationAttribute.JoinNowBtnAttr)]
		public IWebElement JoinNowBtn { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.OpenAccountTitleAttr)]
		public IWebElement OpenAccountTitle { get; set; }

		[FindsBy(How = How.Id, Using = RegistrationAttribute.RegistrationNewUsernameAttr)]
		public IWebElement RegistrationNewUsername { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.RegistrationNewUsernameWarningAttr)]
		public IWebElement RegistrationNewUsernameWarning { get; set; }

		[FindsBy(How = How.Id, Using = RegistrationAttribute.RegistrationNewPasswordAttr)]
		public IWebElement RegistrationNewPassword { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.RegistrationNewPasswordWarningAttr)]
		public IWebElement RegistrationNewPasswordWarning { get; set; }

		[FindsBy(How = How.Id, Using = RegistrationAttribute.RegistrationNewConfirmPasswordAttr)]
		public IWebElement RegistrationNewConfirmPassword { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.RegistrationNewConfirmPasswordWarningAttr)]
		public IWebElement RegistrationNewConfirmPasswordWarning { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.SecurityQuestionArrowAttr)]
		public IWebElement SecurityQuestion { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.SecurityQuestionListResultAttr)]
		public IList<IWebElement> SecurityQuestionList { get; set; }

		[FindsBy(How = How.Id, Using = RegistrationAttribute.SecurityQuestionAnswerAttr)]
		public IWebElement SecurityAnswer { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.TitleArrowAttr)]
		public IWebElement Title { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.TitleListResultAttr)]
		public IList<IWebElement> TitleList { get; set; }

		[FindsBy(How = How.Id, Using = RegistrationAttribute.RegistrationNewFirstNameAttr)]
		public IWebElement RegistrationFirstName { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.RegistrationNewFirstNameWarningAttr)]
		public IWebElement RegistrationFirstNameWarning { get; set; }

		[FindsBy(How = How.Id, Using = RegistrationAttribute.RegistrationNewMiddleNameAttr)]
		public IWebElement RegistrationMiddleName { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.RegistrationNewMiddleNameWarningAttr)]
		public IWebElement RegistrationMiddleNameWarning { get; set; }

		[FindsBy(How = How.Id, Using = RegistrationAttribute.RegistrationNewLastNameAttr)]
		public IWebElement RegistrationLastName { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.RegistrationNewLastNameWarningAttr)]
		public IWebElement RegistrationLastNameWarning { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.DayOfBirthArrowAttr)]
		public IWebElement DayOfBirth { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.DayOfBirthListResultAttr)]
		public IList<IWebElement> DayOfBirthList { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.MonthOfBirthArrowAttr)]
		public IWebElement MonthOfBirth { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.MonthOfBirthListResultAttr)]
		public IList<IWebElement> MonthOfBirthList { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.YearOfBirthArrowAttr)]
		public IWebElement YearOfBirth { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.YearOfBirthListResultAttr)]
		public IList<IWebElement> YearOfBirthList { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.NationalityArrowAttr)]
		public IWebElement Nationality { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.NationalityListResultAttr)]
		public IList<IWebElement> NationalityList { get; set; }

		[FindsBy(How = How.Id, Using = RegistrationAttribute.RegistrationNewEmailAttr)]
		public IWebElement RegistrationEmailAddress { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.RegistrationNewEmailWarningAttr)]
		public IWebElement RegistrationEmailAddressWarning { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.CountryArrowAttr)]
		public IWebElement Country { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.CountryListResultAttr)]
		public IList<IWebElement> CountryList { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.CurrencyArrowAttr)]
		public IWebElement Currency { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.CurrencyListResultAttr)]
		public IList<IWebElement> CurrencyList { get; set; }

		[FindsBy(How = How.Id, Using = RegistrationAttribute.RegistrationNewMobileNumberAttr)]
		public IWebElement RegistrationMobileNumber { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.RegistrationNewMobileNumberWarningAttr)]
		public IWebElement RegistrationMobileNumberWarning { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.RegistrationEnterAddressManuallyLinkAttr)]
		public IWebElement RegistrationEnterAddressManuallyLink { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.RegistrationNewPostalCodeAttr)]
		public IWebElement RegistrationPostalCode { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.RegistrationNewPostalCodeWarningAttr)]
		public IWebElement RegistrationPostalCodeWarning { get; set; }

		[FindsBy(How = How.Id, Using = RegistrationAttribute.RegistrationNewAddress1Attr)]
		public IWebElement RegistrationAddressLine1 { get; set; }

		[FindsBy(How = How.Id, Using = RegistrationAttribute.RegistrationNewCityAttr)]
		public IWebElement RegistrationCity { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.RegistrationNewCityWarningAttr)]
		public IWebElement RegistrationCityWarning { get; set; }

		[FindsBy(How = How.Id, Using = RegistrationAttribute.BoxAgeAndTermsConditionAttr)]
		public IWebElement AgeAndTermsConditionBox { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.RegistrationSubmitBtnAttr)]
		public IWebElement RegistrationSubmitButton { get; set; }

		[FindsBy(How = How.CssSelector, Using = RegistrationAttribute.RegistrationCompleteTitleAttr)]
		public IWebElement RegistrationCompleteTitle { get; set; }
	}
}
