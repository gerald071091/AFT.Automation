using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "Sportsbook")]
    public class SportsbookSteps : BaseSteps
    {
        [AfterScenario("Sportsbook")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [When(@"I click the sportsbook link")]
        public void When_I_Click_The_Sportsbook_Link()
        {
            _operation.ClickHeaderSportsbookLink();
        }

        [Then(@"I should see the sportsbook iframe")]
        public void Then_I_Should_See_The_Sportsbook_Iframe()
        {
            DoesContains(_operation.GetTheCurrentUrl(), "sportsbook");
            DoesEqual(_operation.IsSportsbookIframePresent(), true);
        }
    }
}
