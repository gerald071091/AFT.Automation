using AFT.Automation.Domain.Helper;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "ResponsibleGaming")]
    public class ResponsibleGamingSteps : BaseSteps
    {
        [AfterScenario("ResponsibleGaming")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [Given(@"I click responsible gaming link")]
        public void Given_I_Click_Responsible_Gaming_Link()
        {
            _operation.ClickResponsibleGamingLink();
        }

        [Given(@"I provide the (.*) depending on (.*)")]
        public void Given_I_Provide_The_Depending_On(List<string> details, string scenario)
        {
			_list = details.ToNormalStringList();

			_dictionary = new Dictionary<string, Action>
            {
                {"RGChangeRealityCheck", () => { _operation.ClickRealityCheckBox().SelectRealityCheckTime(_list[0]); } },
                {"RGDepositLimitFieldValidation", () => { _operation.SelectDepositLimitType(_list[0]).ProvideDepositLimitAmount(_list[1]); } },
                {"RGTimeOutSelfExcludeValidation", () => { _operation.CompulsiveGamblerSurvey(_list[0]); } }
            };

			_dictionary[scenario]();
        }

        [When(@"I click the (.*) submit/save button")]
        public void When_I_Click_The_SubmitSave_Button(string category)
        {
			_dictionary = new Dictionary<string, Action>
			{
				{"DepositLimit", () => { _operation.ClickDepositLimitSubmitButton(); } },
				{"RealityCheck", () => { _operation.ClickRealityCheckSaveButton().ClickRealityCheckAcceptButton(); } },
				{"TimeOut/SelfExclude", () => { _operation.ClickTimeOutSelfExcludeSaveButton(); } }
			};

			_dictionary[category]();
        }
    }
}
