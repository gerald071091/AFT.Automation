using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "MyWallet")]
    public class MyWalletSteps : BaseSteps
    {
        [AfterScenario("MyWallet")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [When(@"I click the my wallet link")]
        public void When_I_Click_The_MyWallet_Link()
        {
            _operation.ClickMyWalletLink();
        }

    }
}
