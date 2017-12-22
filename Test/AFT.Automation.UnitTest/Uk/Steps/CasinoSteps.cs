using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "Casino")]
    public class CasinoSteps : BaseSteps
    {
        [AfterScenario("Casino")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [When(@"I click the casino link")]
        public void When_I_Click_The_Casino_Link()
        {
            _operation.ClickHeaderCasinoLink();
        }

        [Then(@"I should see the casino page with game category listing")]
        public void Then_I_Should_See_The_Casino_Page_With_Game_Category_Listing()
        {
            DoesContains(_operation.GetTheCurrentUrl(), "casino");
            DoesEqual(_operation.IsCasinoGameCategoryLoaded(), true);
        }

    }
}
