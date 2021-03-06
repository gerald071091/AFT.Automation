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
    [NUnit.Framework.DescriptionAttribute("ChangePassword")]
    [NUnit.Framework.CategoryAttribute("ChangePassword")]
    public partial class ChangePasswordFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ChangePassword.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ChangePassword", null, ProgrammingLanguage.CSharp, new string[] {
                        "ChangePassword"});
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
        [NUnit.Framework.DescriptionAttribute("ChangePassword_Scenario")]
        [NUnit.Framework.TestCaseAttribute("chrome", "bvs", "bvs.skycp1,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "bvs", "bvs.skycp3,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "bvs", "bvs.skycp5,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "bte", "bte.skycp1,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "bte", "bte.skycp3,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "bte", "bte.skycp5,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "stp", "stp.skycp1,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "stp", "stp.skycp3,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "stp", "stp.skycp5,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "let", "let.skycp1,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "let", "let.skycp3,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "let", "let.skycp5,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "ole", "ole.skycp1,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "ole", "ole.skycp3,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "ole", "ole.skycp5,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "tbt", "tbt.skycp1,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "tbt", "tbt.skycp3,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "tbt", "tbt.skycp5,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "fun", "fun.skycp1,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "fun", "fun.skycp3,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "fun", "fun.skycp5,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "jen", "jen.skycp1,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "jen", "jen.skycp3,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "jen", "jen.skycp5,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "set", "set.skycp1,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "set", "set.skycp3,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "set", "set.skycp5,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("chrome", "tlc", "tlc.skycp1,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("firefox", "tlc", "tlc.skycp3,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        [NUnit.Framework.TestCaseAttribute("ie", "tlc", "tlc.skycp5,a1234567", "\"\",\"\",\"\"", "ChangePassFieldValidation", null, Category="source:Source\\ChangePassword.xlsx")]
        public virtual void ChangePassword_Scenario(string browser, string qAsites, string loginDetails, string details, string scenario, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ChangePassword_Scenario", exampleTags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given(string.Format("I am on the home page of {0} and using {1}", qAsites, browser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.And(string.Format("I login using the following {0}", loginDetails), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And("I proceed to change password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.And("I click the change password button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And(string.Format("I provide the following {0}", details), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I click the update button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then(string.Format("I should see a message, redirect to another page, or see a details depending on {" +
                        "0}", scenario), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
