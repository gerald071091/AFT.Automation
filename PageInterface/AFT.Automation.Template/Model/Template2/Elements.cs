using System;
using AFT.Automation.Domain.Interface.Objects;
using AFT.Automation.Template.Context.Template2;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFT.Automation.Template.Model.Template2
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

		#region Not Implemented

		public IWebElement FooterAgeRestrictionIconLink
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IWebElement FooterPromotionsLink
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IWebElement FooterSafeAndSecureIconLink
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IWebElement FooterSiteIconLink
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IWebElement LoginDetailsDropDown
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion Not Implemented
    }
}
