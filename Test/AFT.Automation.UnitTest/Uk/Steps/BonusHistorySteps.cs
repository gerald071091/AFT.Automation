using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "BonusHistory")]
    public class BonusHistorySteps : BaseSteps
    {
        [AfterScenario("BonusHistory")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [Given(@"I click bonus history link")]
        public void Given_I_Click_Bonus_History_Link()
        {
            _operation.ClickBonusHistoryLink();
        }
    }
}
