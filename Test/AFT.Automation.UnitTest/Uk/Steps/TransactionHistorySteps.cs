using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Uk.Steps
{
    [Binding]
    [Scope(Feature = "TransactionHistory")]
    public class TransactionHistorySteps : BaseSteps
    {
        [AfterScenario("TransactionHistory")]
        public void TearDown()
        {
            _operation.Quit();
        }

        [Given(@"I click transaction history link")]
        public void Given_I_Click_Transaction_History_Link()
        {
            _operation.ClickTransactionHistoryLink();
        }
    }
}
