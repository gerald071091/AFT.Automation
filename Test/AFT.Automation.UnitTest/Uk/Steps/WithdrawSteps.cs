using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "Withdraw")]
    public class WithdrawSteps : BaseSteps
    {
        [AfterScenario("Withdraw")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [Given(@"I click the withdraw link")]
        public void Given_I_Click_The_Withdraw_Link()
        {
            _operation.ClickWithdrawLink();
        }

        [Given(@"I provide the withdraw amount (.*)")]
        public void Given_I_Provide_The_Withdraw_Amount(string amount)
        {
            _operation.ProvideWithdrawAmount(amount);
        }

        [Given(@"I click the withdraw next button")]
        public void Given_I_Click_The_Withdraw_Next_Button()
        {
            _operation.ClickWithdrawNextButton();
        }

        [When(@"I click the withraw button")]
        public void When_I_Click_The_Withraw_Button()
        {
            _operation.ClickWithdrawButton();
        }

    }
}
