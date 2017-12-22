using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "ForgotPassword")]
    public class ForgotPasswordSteps : BaseSteps
    {
        [AfterScenario("ForgotPassword")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [Given(@"I click the forgot password link")]
        public void Given_I_Click_The_ForgotPassword_Link()
        {
            _operation.ClickForgotPasswordLink();
        }

        [When(@"I click the send button")]
        public void When_I_Click_The_Send_Button()
        {
            _operation.ClickForgotPasswordSubmitButton();
        }
    }
}
