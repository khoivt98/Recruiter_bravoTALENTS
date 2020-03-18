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
        //Job detail
        [FindsBy(How = How.CssSelector, Using = "h1.template-detail-content__name--text")]
        public IWebElement templateTitle { get; set; }

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
