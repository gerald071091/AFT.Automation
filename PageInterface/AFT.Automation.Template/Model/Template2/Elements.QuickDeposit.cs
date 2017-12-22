using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace AFT.Automation.Template.Model.Template2
{
	public partial class Elements
	{
		[FindsBy(How = How.CssSelector, Using = QuickDepositAttribute.QuickDepositCloseBtnAttr)]
		public IWebElement QuickDepositCloseButton { get; set; }

		[FindsBy(How = How.Id, Using = QuickDepositAttribute.QuickDepositNetellerTabAttr)]
		public IWebElement QuickDepositNetellerTab { get; set; }

		[FindsBy(How = How.Id, Using = QuickDepositAttribute.QuickDepositNetellerAmountAttr)]
		public IWebElement QuickDepositNetellerAmount { get; set; }

		[FindsBy(How = How.Id, Using = QuickDepositAttribute.QuickDepositNetellerAccountIDAttr)]
		public IWebElement QuickDepositNetellerAccountID { get; set; }

		[FindsBy(How = How.Id, Using = QuickDepositAttribute.QuickDepositNetellerAuthCodeAttr)]
		public IWebElement QuickDepositNetellerAuthCode { get; set; }

		[FindsBy(How = How.Id, Using = QuickDepositAttribute.QuickDepositSkrillTabAttr)]
		public IWebElement QuickDepositSkrillTab { get; set; }

		[FindsBy(How = How.Id, Using = QuickDepositAttribute.QuickDepositSkrillAmountAttr)]
		public IWebElement QuickDepositSkrillAmount { get; set; }

		[FindsBy(How = How.Id, Using = QuickDepositAttribute.QuickDepositCCTabAttr)]
		public IWebElement QuickDepositCCTab { get; set; }

		[FindsBy(How = How.Id, Using = QuickDepositAttribute.QuickDepositCCAmountAttr)]
		public IWebElement QuickDepositCCAmount { get; set; }

		[FindsBy(How = How.CssSelector, Using = QuickDepositAttribute.QuickDepositCardTypeArrowAttr)]
		public IWebElement QuickDepositCardType { get; set; }

		[FindsBy(How = How.CssSelector, Using = QuickDepositAttribute.QuickDepositCardTypeListResultAttr)]
		public IList<IWebElement> QuickDepositCardTypeList { get; set; }

		[FindsBy(How = How.Id, Using = QuickDepositAttribute.QuickDepositCardNumberAttr)]
		public IWebElement QuickDepositCCNumber { get; set; }

		[FindsBy(How = How.Id, Using = QuickDepositAttribute.QuickDepositCCFullNameAttr)]
		public IWebElement QuickDepositCCFullName { get; set; }

		[FindsBy(How = How.Name, Using = QuickDepositAttribute.QuickDepositCCMonthExpiryAttr)]
		public IWebElement QuickDepositCCMonthExpiry { get; set; }

		[FindsBy(How = How.Name, Using = QuickDepositAttribute.QuickDepositCCYearExpiryAttr)]
		public IWebElement QuickDepositCCYearExpiry { get; set; }

		[FindsBy(How = How.Id, Using = QuickDepositAttribute.QuickDepositCCSecurityCodeAttr)]
		public IWebElement QuickDepositCCSecurityCode { get; set; }

		[FindsBy(How = How.CssSelector, Using = QuickDepositAttribute.QuickDepositCCResetBtnAttr)]
		public IWebElement QuickDepositCCResetButton { get; set; }

		[FindsBy(How = How.CssSelector, Using = QuickDepositAttribute.QuickDepositTermsAndConditionBoxAttr)]
		public IWebElement QuickDepositTermsAndConditionBox { get; set; }

		[FindsBy(How = How.Id, Using = QuickDepositAttribute.QuickDepositSubmitBtnAttr)]
		public IWebElement QuickDepositSubmitButton { get; set; }
	}
}
