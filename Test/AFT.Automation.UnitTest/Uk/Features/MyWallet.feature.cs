﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AFT.Automation.UnitTest.Uk.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("MyWallet")]
    [NUnit.Framework.CategoryAttribute("MyWallet")]
    public partial class MyWalletFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MyWallet.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MyWallet", null, ProgrammingLanguage.CSharp, new string[] {
                        "MyWallet"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("MyWallet_Scenario")]
        [NUnit.Framework.TestCaseAttribute("chrome", "bvs", "bvs.skymw1,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "bvs", "bvs.skymw2,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "bvs", "bvs.skymw3,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "bvs", "bvs.skymw4,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "bvs", "bvs.skymw5,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "bvs", "bvs.skymw6,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "bte", "bte.skymw1,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "bte", "bte.skymw2,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "bte", "bte.skymw3,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "bte", "bte.skymw4,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "bte", "bte.skymw5,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "bte", "bte.skymw6,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "stp", "stp.skymw1,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "stp", "stp.skymw2,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "stp", "stp.skymw3,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "stp", "stp.skymw4,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "stp", "stp.skymw5,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "stp", "stp.skymw6,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "let", "let.skymw1,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "let", "let.skymw2,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "let", "let.skymw3,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "let", "let.skymw4,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "let", "let.skymw5,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "let", "let.skymw6,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "ole", "ole.skymw1,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "ole", "ole.skymw2,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "ole", "ole.skymw3,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "ole", "ole.skymw4,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "ole", "ole.skymw5,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "ole", "ole.skymw6,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "tbt", "tbt.skymw1,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "tbt", "tbt.skymw2,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "tbt", "tbt.skymw3,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "tbt", "tbt.skymw4,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "tbt", "tbt.skymw5,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "tbt", "tbt.skymw6,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "fun", "fun.skymw1,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "fun", "fun.skymw2,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "fun", "fun.skymw3,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "fun", "fun.skymw4,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "fun", "fun.skymw5,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "fun", "fun.skymw6,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "jen", "jen.skymw1,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "jen", "jen.skymw2,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "jen", "jen.skymw3,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "jen", "jen.skymw4,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "jen", "jen.skymw5,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "jen", "jen.skymw6,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "set", "set.skymw1,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "set", "set.skymw2,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "set", "set.skymw3,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "set", "set.skymw4,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "set", "set.skymw5,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "set", "set.skymw6,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "tlc", "tlc.skymw1,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "tlc", "tlc.skymw2,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "tlc", "tlc.skymw3,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "tlc", "tlc.skymw4,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "tlc", "tlc.skymw5,a1234567", "MyWalletUrlVerification", null, Category="source:Source\\MyWallet.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "tlc", "tlc.skymw6,a1234567", "MyWalletBalances", null, Category="source:Source\\MyWallet.xlsx")]
        public virtual void MyWallet_Scenario(string browser, string qAsites, string loginDetails, string scenario, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MyWallet_Scenario", exampleTags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given(string.Format("I am on the home page of {0} and using {1}", qAsites, browser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
    testRunner.And(string.Format("I login using the following {0}", loginDetails), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And("I click the my account link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.When("I click the my wallet link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then(string.Format("I should see a message, redirect to another page, or see a details depending on {" +
                        "0}", scenario), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion