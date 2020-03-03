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
        public IWebElement btnCreateJob { get; set; }

        //Create Job from scratch
        [FindsBy(How = How.CssSelector, Using = ".job-creation-action__from-scratch")]
        public IWebElement btnCreateFromScratch { get; set; }

        [FindsBy(How = How.XPath, Using = "/html//app-root//jobs-page/job-creation/job-creation-form//form[@method='POST']//input[@placeholder='Ex: Business Analyst']")]
        public IWebElement txtJobTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".select2.select2-container.select2-container--default")]
        public IList<IWebElement> sltJobCategory { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".select2-results__option")]
        public IList<IWebElement> sltOption { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-creation-form__location-dropdown")]
        public IWebElement openSltLocation { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-creation-form__location-item")]
        public IList<IWebElement> sltLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//app-root//jobs-page[@class='ng-star-inserted']/job-creation/job-creation-from-scratch//div[@class='job-creation-form__submit']/custom-button[2]/button[@class='button button--primary']")]
        public IWebElement btnCreate { get; set; }



        [FindsBy(How = How.CssSelector, Using = ".job-creation-close-icon.job-creation-list-action__close-button.small.sprite-icon.sprite-remove")]
        public IWebElement btnClose { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-creation-form__submit > custom-button:nth-of-type(1) > .button.button--secondary")]
        public IWebElement btnCancel { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-creation-form__submit custom-button:nth-of-type(2) [type]")]
        public IWebElement btnSave { get; set; }

        //Create Job from template or previous job
        [FindsBy(How = How.CssSelector, Using = ".job-creation-with-details__footer custom-button:nth-of-type(2) [type]")]
        public IWebElement btnCreateAndEdit { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-creation-with-details__footer > custom-button:nth-of-type(1) > .button.button--secondary")]
        public IWebElement btnCancel2 { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".big.job-creation-title__icon.sprite-icon.sprite-remove")]
        public IWebElement btnClose2 { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".jobs-from-previous__item.text-truncate")]
        public IList<IWebElement> listItemFromPreviousJobs { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".jobs-from-templates__item.text-truncate")]
        public IList<IWebElement> listItemFromTemplates { get; set; }

        //Job Ad
        [FindsBy(How = How.CssSelector, Using = ".--editable.job-header__job-title-display.ng-star-inserted > div > div")]
        public IWebElement txtJobName { get; set; }

    }
}
