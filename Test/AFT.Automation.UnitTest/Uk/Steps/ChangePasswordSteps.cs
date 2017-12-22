using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "ChangePassword")]
    public class ChangePasswordSteps : BaseSteps
    {
        [AfterScenario("ChangePassword")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [Given(@"I proceed to change password page")]
        public void Given_I_Proceed_To_Change_Password_Page()
        {
            _operation.ClickMyAccountLink()
                .ClickMyDetailsLink();      
        }

        [Given(@"I click the change password button")]
        public void Given_I_Click_The_Change_Password_Button()
        {
            _operation.ClickChangePasswordButton();
        }

        [When(@"I click the update button")]
        public void When_I_Click_The_Update_Button()
        {
            _operation.ClickChangePasswordUpdateButton();
        }

    }
}
