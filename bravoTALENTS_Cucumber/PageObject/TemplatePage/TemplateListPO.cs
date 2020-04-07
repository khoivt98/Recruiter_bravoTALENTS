using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bravoTALENTS_Cucumber.PageObject.TemplatePage
{
    class TemplateListPO
    {
        [FindsBy(How = How.LinkText, Using = "Templates")]
        public IWebElement menuTemplate { get; set; }

        //General bar
        [FindsBy(How = How.XPath, Using = "//li[@title = 'All']")]
        public IWebElement allTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@title = 'System']")]
        public IWebElement systemTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@title = 'Company']")]
        public IWebElement companyTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@title = 'Filter']")]
        public IWebElement filterTab { get; set; }

        //Action bar
        [FindsBy(How = How.CssSelector, Using = ".template-action__item .button")]
        public IWebElement createTemplateButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".candidate-action__icon.sprite-trash.big.sprite-active")]
        public IWebElement deleteIcon { get; set; }

        //Create template panel
        [FindsBy(How = How.Id, Using = "nameInput")]
        public IWebElement templateNameTextBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "bravo-select.template-creation-form__type-select")]
        public IWebElement templateTypeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@title = 'Job Details']")]
        public IWebElement jobDetailType { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@title = 'Email']")]
        public IWebElement emailType { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@title = 'Interview Prep']")]
        public IWebElement interviewPrepType { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".template-creation__submit .button--primary")]
        public IWebElement createButtonInCreateTemplatePanel { get; set; }

        //Filter panel
        [FindsBy(How = How.CssSelector, Using = "div.template-filter__type-options span:nth-child(1)")]
        public IWebElement jobDetailCheckBoxText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.template-filter__type-options span:nth-child(2)")]
        public IWebElement emailCheckBoxText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.template-filter__type-options span:nth-child(3)")]
        public IWebElement interviewPrepCheckBoxText { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".template-filter__checkbox__label-text.template-filter__checkbox__label-text--bold")]
        public IWebElement showAllDeletedTemplateText { get; set; }

        //Quick card panel
        [FindsBy(How = How.CssSelector, Using = "li.template-list-action__item:nth-child(1)")]
        public IWebElement moveToTemplateDetailButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li.template-list-action__item:nth-child(2)")]
        public IWebElement closeQuickCardButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li.template-list-action__item:nth-child(3)")]
        public IWebElement publishTemplateButtonInQuickCard { get; set; }

        //Template list
        [FindsBy(How = How.CssSelector, Using = ".template-content:nth-child(1) .checkbox-label")]
        public IWebElement firstTemplateCheckbox { get; set; }
    }
}
