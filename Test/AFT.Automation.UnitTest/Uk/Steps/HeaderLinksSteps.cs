using AFT.Automation.Domain.Helper;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "HeaderLinks")]
    public class HeaderLinksSteps : BaseSteps
    {
        [AfterScenario("HeaderLinks")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [When(@"I click this header link (.*)")]
        public void When_I_Click_This_Header_Link(List<string> details)
        {
			_list = details.ToNormalStringList();

			_dictionary = new Dictionary<string, Action>
			{
				{"SiteLogo", () => { _operation.ClickHeaderSiteIconLink(); } },
				{"ForgotPassword", () => { _operation.ClickForgotPasswordLink(); } },
				{"Affiliates", () => { _operation.ClickHeaderAffiliatesLink(); } },
				{"Promotions", () => { _operation.ClickHeaderPromotionsLink(); } },
				{"Sportsbook", () => { _operation.ClickHeaderSportsbookLink(); } },
				{"Casino", () => { _operation.ClickHeaderCasinoLink(); } },
				{"Deposit", () => { _operation.ProvideLoginUserName(_list[1])
										.ProvideLoginPassword(_list[2])
										.ClickLoginButton()
										.ClickQuickDepositCloseButton()
										.ClickDepositLink(); } },
				{"MyAccount", () => { _operation.ProvideLoginUserName(_list[1])
										.ProvideLoginPassword(_list[2])
										.ClickLoginButton()
										.ClickQuickDepositCloseButton()
										.ClickMyAccountLink(); } }
			};

			_dictionary[_list[0]]();
        }
    }
}
