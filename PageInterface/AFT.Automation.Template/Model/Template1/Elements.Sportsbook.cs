﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFT.Automation.Template.Model.Template1
{
    public partial class Elements
    {
        [FindsBy(How = How.CssSelector, Using = SportsbookAttribute.SportsbookIframeAttr)]
        public IWebElement SportsbookIframe { get; set; }
    }
}
