using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "GameHistory")]
    public class GameHistorySteps : BaseSteps
    {
        [AfterScenario("GameHistory")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [Given(@"I click game history link")]
        public void GivenIClickGameHistoryLink()
        {
            _operation.ClickGameHistoryLink();
        }

    }
}
