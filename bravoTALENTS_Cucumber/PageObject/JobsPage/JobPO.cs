using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bravoTALENTS_Cucumber.PageObject
{
    class JobPO
    {
        [FindsBy(How = How.CssSelector, Using = ".job-action--first [type]")]
        public IWebElement createJobButton { get; set; }

        //Create Job panel
        [FindsBy(How = How.CssSelector, Using = ".job-creation-form__label input")]
        public IWebElement jobTitleTextBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-creation-title__icon.small.sprite-icon.sprite-remove")]
        public IWebElement closeButtonInCreateJobPanel { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-creation-action__from-scratch")]
        public IWebElement createFromScratchButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.jobs-from-previous__job-name")]
        public IList<IWebElement> listItemFromPreviousJobs { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.jobs-from-templates__job-name")]
        public IList<IWebElement> listItemFromTemplates { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.jobs-from-previous > span.no-jobs-text")]
        public IWebElement noPreviousJobsFoundText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.jobs-from-templates > span.no-jobs-text")]
        public IWebElement noTemplatesFoundText { get; set; }

        //Create Job from scratch panel    
        [FindsBy(How = How.CssSelector, Using = ".select2.select2-container.select2-container--default")]
        public IList<IWebElement> selectDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".select2-results__option")]
        public IList<IWebElement> selectDropdownItem { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-creation-form__location-dropdown")]
        public IWebElement locationDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-creation-form__location-item")]
        public IList<IWebElement> locationItem { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-creation-form__submit > custom-button > button.button.button--primary")]
        public IWebElement createButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "i.job-creation-list-action__close-button")]
        public IWebElement closeButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-creation-form__submit > custom-button > button.button.button--secondary")]
        public IWebElement cancelButtonInCreateJobPanel { get; set; }

        //Review job panel
        [FindsBy(How = How.CssSelector, Using = "div.job-creation-with-details__footer > custom-button > button.button.button--primary")]
        public IWebElement createAndEditButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-creation-with-details__footer > custom-button > button.button.button--secondary")]
        public IWebElement cancelButtonInReivewPanel { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".big.job-creation-title__icon.sprite-icon.sprite-remove")]
        public IWebElement closeButtonInReivewPanel { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-creation-with-details__job-title")]
        public IWebElement jobTitleInReivewPanel { get; set; }


        //Job Ad
        [FindsBy(How = How.CssSelector, Using = ".--editable.job-header__job-title-display.ng-star-inserted > div > div")]
        public IWebElement jobNameTextBox { get; set; }
    }
}
