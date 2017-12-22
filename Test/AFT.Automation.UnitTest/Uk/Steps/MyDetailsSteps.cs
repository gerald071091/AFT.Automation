using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "MyDetails")]
    public class MyDetailsSteps : BaseSteps
    {
        [AfterScenario("MyDetails")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [Given(@"I click the my details link")]
        public void Given_I_Click_The_MyDetails_Link()
        {
            _operation.ClickMyDetailsLink();
        }

    }
}
