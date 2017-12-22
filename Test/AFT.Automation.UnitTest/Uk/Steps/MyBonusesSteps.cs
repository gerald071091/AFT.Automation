using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "MyBonuses")]
    public class MyBonusesSteps : BaseSteps
    {
        [AfterScenario("MyBonuses")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [Given(@"I click the my bonuses link")]
        public void Given_I_Click_The_MyBonuses_Link()
        {
            _operation.ClickMyBonusesLink();
        }

    }
}
