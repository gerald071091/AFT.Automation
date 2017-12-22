using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "Login")]
    public class LoginSteps : BaseSteps
    {

        [AfterScenario("Login")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [Given(@"I enter my Username using (.*)")]
        public void Given_I_Enter_My_Username_Using(string username)
        {
            _operation.ProvideLoginUserName(username);
        }

        [Given(@"I enter my password using (.*)")]
        public void Given_I_Enter_My_Password_Using(string password)
        {
            _operation.ProvideLoginPassword(password);
        }

        [When(@"I click the login button")]
        public void When_I_Click_The_Login_Button()
        {
            _operation.ClickLoginButton();
        }
    }
}
