using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "Deposit")]
    public class DepositSteps : BaseSteps
    {
        [AfterScenario("Deposit")]
        public void TearDown()
        {
            _operation.Quit();
        }

        #region Deposit_Neteller_Link

        [When(@"I click the click here hyperlink")]
        public void When_I_Click_The_Click_Here_Hyperlink()
        {
            _operation.ClickDepositNetellerHomePageLink();
        }

        [Then(@"I should see the neteller page")]
        public void Then_I_Should_See_The_Neteller_Page()
        {
            _operation.GoToTab("Home - NETELLER");
            DoesContains(_operation.GetTheCurrentUrl(), "neteller");
            _operation.GoToDefaultTab()
                .ClickLogoutButton();
        }

        #endregion Deposit_Neteller_Link

    }
}
