using AFT.Automation.Domain.Interface.Objects;
using AFT.Automation.Template.Context.Template1;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFT.Automation.Template.Model.Template1
{
    public partial class Elements : Attributes, IBaseElement
    {
        [FindsBy(How = How.CssSelector, Using = CommonAttributes.CommonModalMessageAttr)]
        public IWebElement ModalMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = CommonAttributes.CommonModalSubmitBtnAttr)]        
        public IWebElement ModalOKBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = CommonAttributes.CommonMyAccountLinkAttr)]       
        public IWebElement MyAccountLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = CommonAttributes.CommonMyDetailsLinkAttr)]        
        public IWebElement MyDetailsLink { get; set; }

		[FindsBy(How = How.CssSelector, Using = CommonAttributes.CommonHeaderMainWalletAttr)]
		public IWebElement HeaderMainWallet { get; set; }
    }
}
