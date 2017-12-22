using AFT.Automation.Domain.Helper;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "DepositWithBonus")]
    public class DepositWithBonusSteps : BaseSteps
    {
        [AfterScenario("DepositWithBonus")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [Given(@"I provide the followings (.*) depending on (.*)")]
        public void Given_I_Provide_The_Following_Depending_On(List<string> details, string scenario)
        {
			_list = details.ToNormalStringList();

			_dictionary = new Dictionary<string, Action>
			{
				{"DepositWithBonusSuccess", () => 
					{
						_operation.ProvideDepositNetellerAmount(_list[0]).ProvideDepositNetellerAccountID(_list[1])
						.ProvideDepositNetellerSecureID(_list[2]).ProvideDepositWithBonusCode(_list[3])
						.SelectDepositWithBonusProduct(_list[4]).ClickDepositWithBonusTermsAndCondition()
						.ClickDepositWithBonusSubscribe();
					}
				},
				{"DepositWithBonusInvalidBonusCode", () => 
					{
						_operation.ProvideDepositNetellerAmount(_list[0]).ProvideDepositNetellerAccountID(_list[1])
						.ProvideDepositNetellerSecureID(_list[2]).ProvideDepositWithBonusCode(_list[3])
						.SelectDepositWithBonusProduct(_list[4]).ClickDepositWithBonusTermsAndCondition()
						.ClickDepositWithBonusSubscribe();
					}
				},
				{"DepositWithBonusTCAgreement", () => 
					{
						_operation.ProvideDepositNetellerAmount(_list[0]).ProvideDepositNetellerAccountID(_list[1])
						.ProvideDepositNetellerSecureID(_list[2]).ProvideDepositWithBonusCode(_list[3])
						.SelectDepositWithBonusProduct(_list[4]).ClickDepositWithBonusSubscribe();
					}
				}
			};

			_dictionary[scenario]();
        }

    }
}
