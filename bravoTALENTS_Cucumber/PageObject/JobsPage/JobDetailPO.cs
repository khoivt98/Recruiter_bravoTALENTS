using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bravoTALENTS_Cucumber.PageObject.JobsPage
{
    class JobDetailPO
    {
        //Tab navigation
        [FindsBy(How = How.CssSelector, Using = ".tab-navigation__menu-item:nth-child(1)")]
        public IWebElement overviewTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".tab-navigation__menu-item:nth-child(2)")]
        public IWebElement jobAdTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".tab-navigation__menu-item:nth-child(3)")]
        public IWebElement advertiseTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".tab-navigation__menu-item:nth-child(4)")]
        public IWebElement talentsTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-navigation__save-as-template")]
        public IWebElement saveAsTemplateButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".default-link")]
        public IWebElement linkNavigateToTemplateScreen { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-navigation__remove-icon ")]
        public IWebElement closeIcon { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-navigation__button.--state-change")]
        public IWebElement stateChangeButton { get; set; }

        //Job Overview
        [FindsBy(How = How.CssSelector, Using = ".job-overview-container__candidates-info-item:nth-child(1)")]
        public IWebElement theAllPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-overview-container__candidates-info-item:nth-child(2)")]
        public IWebElement theSourcedPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-overview-container__candidates-info-item:nth-child(3)")]
        public IWebElement theAppliedPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-overview-container__candidates-info-item:nth-child(4)")]
        public IWebElement theInReivewPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-overview-container__candidates-info-item:nth-child(5)")]
        public IWebElement thePhoneReviewPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-overview-container__candidates-info-item:nth-child(6)")]
        public IWebElement theOnstieReviewPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-overview-container__candidates-info-item:nth-child(7)")]
        public IWebElement theOfferPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-overview-container__candidates-info-item:nth-child(8)")]
        public IWebElement theHiredPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-overview-container__candidates-info-item:nth-child(10)")]
        public IWebElement theRejectedPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a:nth-child(1) .job-overview-container__candidates-info-number")]
        public IWebElement theNumberOfAllPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a:nth-child(2) .job-overview-container__candidates-info-number")]
        public IWebElement theNumberOfSourcedPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a:nth-child(3) .job-overview-container__candidates-info-number")]
        public IWebElement theNumberOfAppliedPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a:nth-child(4) .job-overview-container__candidates-info-number")]
        public IWebElement theNumberOfInReivewPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a:nth-child(5) .job-overview-container__candidates-info-number")]
        public IWebElement theNumberOfPhoneReviewPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a:nth-child(6) .job-overview-container__candidates-info-number")]
        public IWebElement theNumberOfOnstieReviewPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a:nth-child(7) .job-overview-container__candidates-info-number")]
        public IWebElement theNumberOfOfferPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a:nth-child(8) .job-overview-container__candidates-info-number")]
        public IWebElement theNumberOfHiredPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a:nth-child(10) .job-overview-container__candidates-info-number")]
        public IWebElement theNumberOfRejectedPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-header__job-title-display div div")]
        public IWebElement theJobTitle { get; set; }

        //Job description
        [FindsBy(How = How.Id, Using = "jobDescriptionEditor")]
        public IWebElement jobDescription { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".alert.alert-error")]
        public IWebElement errorMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".alert.alert-warning")]
        public IWebElement warningMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".alert.alert-warning")]
        public IList<IWebElement> listWarningMessage { get; set; }
    }
}
