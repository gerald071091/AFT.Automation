using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "FooterLinks")]
    public class FooterLinksSteps : BaseSteps
    {
        [AfterScenario("FooterLinks")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [When(@"I click this footer link (.*)")]
        public void When_I_Click_This_Footer_Link(string footerLink)
        {
			_dictionary = new Dictionary<string, Action>
			{
				{"OpenAccount", () => { _operation.ClickFooterOpenAccountLink(); } },
				{"AboutUs", () => { _operation.ClickFooterAboutUsLink(); } },
				{"ContactUs", () => { _operation.ClickFooterContactUsLink(); } },
				{"Promotions", () => { _operation.ClickFooterPromotionsLink(); } },
				{"TermsAndConditions", () => { _operation.ClickFooterTermsAndConditionsLink(); } },
				{"Rules", () => { _operation.ClickFooterRulesLink(); } },
				{"PrivacyPolicy", () => { _operation.ClickFooterPrivacyPolicyLink(); } },
				{"CashOut", () => { _operation.ClickFooterCashOutLink(); } },
				{"LostPassword", () => { _operation.ClickFooterLostPasswordLink(); } },
				{"TechnicalSupport", () => { _operation.ClickFooterTechnicalSupportLink(); } },
				{"DepositAndWithdrawals", () => { _operation.ClickFooterDepositAndWithdrawalLink(); } },
				{"ResponsibleGaming", () => { _operation.ClickFooterResponsibleGamingLink(); } },
				{"RTP", () => { _operation.ClickFooterRTPLink(); } },
				{"FAQ", () => { _operation.ClickFooterFAQLink(); } },
				{"GameCare", () => { _operation.ClickFooterGameCareIconLink(); } },
				{"AgeRestriction", () => { _operation.ClickFooterAgeRestrictionIconLink(); } },
				{"SafeAndSecure", () => { _operation.ClickFooterSafeAndSecureIconLink(); } },
				{"IsleOfMan", () => { _operation.ClickFooterIsleOfManIconLink(); } },
				{"GamblingCommission", () => { _operation.ClickFooterGamblingCommissionIconLink(); } },
				{"IBAS", () => { _operation.ClickFooterIBASIconLink(); } },
				{"GambleAware", () => { _operation.ClickFooterGamblewareIconLink(); } },
				{"SiteLogo", () => { _operation.ClickFooterSiteIconLink(); } }
			};

			_dictionary[footerLink]();
        }
    }
}
