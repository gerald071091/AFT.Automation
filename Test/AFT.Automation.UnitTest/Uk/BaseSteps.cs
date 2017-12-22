using AFT.Automation.Domain.Helper;
using AFT.Automation.UnitTest.Utilities;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk
{
    public class BaseSteps : TestUtility
    {
        [AfterTestRun]
        public static void CleanUp()
        {
            _process.EndSession("drivers".GetValue());
			_process.RemoveDayOldFile("reportPath".GetValue());
        }

        #region Shared steps

        [Given(@"I am on the home page of (.*) and using (.*)")]
        public void Given_I_Am_On_The_Home_Page_Of(string sites, string browser)
        {
            _operation = InitializeOperation(sites, browser);
            _operation.Redirect(sites.GetValue());
        }

        [Given(@"I login using the following (.*)")]
        public void Given_I_Login_Using_The_Following(List<string> loginDetails)
        {
			_operation.ProvideLoginUserName(loginDetails[0])
				.ProvideLoginPassword(loginDetails[1])
				.ClickLoginButton().ClickQuickDepositCloseButton();

			//if (double.Parse(_operation.GetHeaderMainWalletBalance()) <= 5)
			//{
			//	_operation.ClickQuickDepositCloseButton();
			//}
            
        }

        [Given(@"I click the my account link")]
        public void Given_I_Click_The_MyAccount_Link()
        {
            _operation.ClickMyAccountLink();
        }

        [Given(@"I provide the following (.*)")]
        public void Given_I_Provide_The_Following(List<string> details)
        {
            GetSharedStepAction(FeatureContext.Current.FeatureInfo.Title, details);
        }

        [When(@"I click the submit button")]
        public void When_I_Click_The_Submit_Button()
        {
			_dictionary = new Dictionary<string, Action>
			{
				//{"Registration", () => { _operation.ClickRegistrationSubmitButton(); } },
				{"BonusHistory", () => { _operation.ClickBonusHistorySubmitButton(); } },
				{"TransactionHistory", () => { _operation.ClickTransactionHistorySubmitButton(); } },
				{"GameHistory", () => { _operation.ClickGameHistorySubmitButton(); } }
			};

			_dictionary[FeatureContext.Current.FeatureInfo.Title]();    
        }

        [Then(@"I should see a message, redirect to another page, or see a details depending on (.*)")]
        public void Then_I_Should_See_A_Message_Redirect_To_Another_Page_Or_See_A_Details_Depending_On(string scenario)
        {
            GetSharedStepAction(scenario);
        }

        #region Deposit and DepositWithBonus

        [Given(@"I click the deposit link")]
        public void Given_I_Click_The_Deposit_Link()
        {
            _operation.ClickDepositLink();
        }

        [Given(@"I click the neteller check box")]
        public void Given_I_Click_The_Neteller_CheckBox()
        {
            _operation.ClickDepositNetellerCheckBox();
        }

        [Given(@"I click the next button")]
        public void Given_I_Click_The_Next_Button()
        {
            _operation.ClickDepositNextButton();
        }

        [When(@"I click the deposit button")]
        public void When_I_Click_The_Deposit_Button()
        {
            _operation.ClickDepositNetellerButton();
        }

        #endregion Deposit and DepositWithBonus

        #endregion Shared steps
    }
}
