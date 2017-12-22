using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace AFT.Automation.Template.Model.Template2
{
    public partial class Elements
    {
        [FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.ResponsibleGamingLinkAttr)]       
        public IWebElement ResponsibleGamingLink { get; set; }

        [FindsBy(How = How.Id, Using = ResponsibleGamingAttribute.RealityCheckBoxAttr)]    
        public IWebElement RealityCheckBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.RealityCheckArrowAttr)]       
        public IWebElement RealityCheck { get; set; }

        [FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.RealityCheckListResultAttr)]        
        public IList<IWebElement> RealityCheckList { get; set; }

        [FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.RealityCheckSaveBtnAttr)]       
        public IWebElement RealityCheckSaveButton { get; set; }

		[FindsBy(How = How.ClassName, Using = ResponsibleGamingAttribute.RealityCheckAcceptBtnAttr)]
		public IWebElement RealityCheckAcceptButton { get; set; }

		[FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.DepositLimitArrowAttr)]  
        public IWebElement DepositLimit { get; set; }

        [FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.DepositLimitListResultAttr)]        
        public IList<IWebElement> DepositLimitList { get; set; }

        [FindsBy(How = How.Id, Using = ResponsibleGamingAttribute.DepositLimitAmountAttr)]        
        public IWebElement DepositLimitAmount { get; set; }

        [FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.DepositLimitSubmitBtnAttr)]      
        public IWebElement DepositLimitSubmitButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.DepositLimitCancelBtnAttr)]  
        public IWebElement DepositLimitCancelButton { get; set; }

        [FindsBy(How = How.Id, Using = ResponsibleGamingAttribute.TimeOutCheckBoxAttr)]      
        public IWebElement TimeOutCheckBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.TimeOutArrowAttr)]      
        public IWebElement TimeOut { get; set; }

        [FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.TimeOutListResultAttr)]       
        public IList<IWebElement> TimeOutList { get; set; }

        [FindsBy(How = How.Id, Using = ResponsibleGamingAttribute.SelfExcludeCheckBoxAttr)]        
        public IWebElement SelfExcludeCheckBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.SelfExcludeArrowAttr)]        
        public IWebElement SelfExclude { get; set; }

        [FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.SelfExcludeListResultAttr)]        
        public IList<IWebElement> SelfExcludeList { get; set; }

        [FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.CompulsiveGamblerRadioBtnAttr)]        
        public IList<IWebElement> CompulsiveGambleSelection { get; set; }

        [FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.TimeOutSelfExcludeSaveBtnAttr)]       
        public IWebElement TimeOutSelfExcludeSaveButton { get; set; }

        [FindsBy(How = How.Id, Using = ResponsibleGamingAttribute.TimeOutSelfExcludeModalOkBtnAttr)]
        public IWebElement TimeOutSelfExcludeModalOkButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ResponsibleGamingAttribute.ResponsibleGamingCompleteTitleAttr)]
        public IWebElement ResponsibleGamingCompleteTitle { get; set; }
    }
}
