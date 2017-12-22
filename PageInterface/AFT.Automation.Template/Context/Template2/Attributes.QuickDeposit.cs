namespace AFT.Automation.Template.Context.Template2
{
	public partial class Attributes
	{
		/// <summary>
		/// Template 2 QuickDeposit page attributes
		/// </summary>
		protected static class QuickDepositAttribute
		{
			public const string QuickDepositCloseBtnAttr = "body > div.fancybox-overlay.fancybox-overlay-fixed > div > div > a";

			public const string QuickDepositNetellerTabAttr = "tab-neteller";

			public const string QuickDepositNetellerAmountAttr = "depositAmount";

			public const string QuickDepositNetellerAccountIDAttr = "accountid";

			public const string QuickDepositNetellerAuthCodeAttr = "secureId";

			public const string QuickDepositSkrillTabAttr = "tab-skrill";

			public const string QuickDepositSkrillAmountAttr = "depositAmount";

			public const string QuickDepositCCTabAttr = "tab-worldpay";

			public const string QuickDepositCCAmountAttr = "depositAmount";

			public const string QuickDepositCardTypeArrowAttr = "#Worldpay-LBD > div:nth-child(3) > div:nth-child(1) > div > span.select2.select2-container.select2-container--classic.select2-container--focus > span.selection > span > span.select2-selection__arrow";

			public const string QuickDepositCardTypeListResultAttr = "body > span.select2-container.select2-container--classic.select2-container--open > span > span.select2-results > ul > li";

			public const string QuickDepositCardNumberAttr = "cardnumber";

			public const string QuickDepositCCFullNameAttr = "fullname";

			public const string QuickDepositCCMonthExpiryAttr = "expiryMM"; 

			public const string QuickDepositCCYearExpiryAttr = "expiryYY";

			public const string QuickDepositCCSecurityCodeAttr = "cvv";

			public const string QuickDepositCCResetBtnAttr = "#Worldpay-LBD > div:nth-child(3) > div:nth-child(6) > p > button";

			public const string QuickDepositTermsAndConditionBoxAttr = "#payment-container > div:nth-child(5) > div.col-xs-10.text-left > label > input[type='checkbox']";

			public const string QuickDepositSubmitBtnAttr = "submit-btn";
		}
	}
}
