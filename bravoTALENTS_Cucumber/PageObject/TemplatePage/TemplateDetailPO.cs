using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bravoTALENTS_Cucumber.PageObject.TemplatePage
{
    class TemplateDetailPO
    {
        //General
        [FindsBy(How = How.CssSelector, Using = "h1.template-detail-content__name--text")]
        public IWebElement templateTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.template-detail-content__type--text")]
        public IWebElement templateType { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li.template-progress-bar__item--current-state span")]
        public IWebElement currentState { get; set; }

        //Action bar
        [FindsBy(How = How.XPath, Using = "//li[@title = 'Close']")]
        public IWebElement closeTemplateDetailButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@title = 'Quick card']")]
        public IWebElement quickCardButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@title = 'Delete template']")]
        public IWebElement deleteTemplateButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@title = 'Make a copy']")]
        public IWebElement makeACopyButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@title = 'Published']")]
        public IWebElement publishTemplateButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@title = 'Undo Delete']")]
        public IWebElement undoDeleteButton { get; set; }


        //Job detail
        [FindsBy(How = How.CssSelector, Using = "div.template-detail-info__view-item:nth-child(2) span")]
        public IWebElement positionLevel { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.template-detail-info__view-item:nth-child(3) span")]
        public IWebElement jobType { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.template-detail-info__view-item:nth-child(4) span")]
        public IWebElement jobCategory { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.template-detail-info__view-item:nth-child(5) .template-detail-info__view-item-text")]
        public IWebElement location { get; set; }



    }
}
