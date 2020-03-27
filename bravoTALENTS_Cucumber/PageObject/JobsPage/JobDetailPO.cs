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

        [FindsBy(How = How.CssSelector, Using = ".job-detail-page__revert-alert a:nth-child(1)")]
        public IWebElement revertYourChangeLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-detail-page__revert-alert a:nth-child(2)")]
        public IWebElement republishJobLink { get; set; }



        //Job information
        [FindsBy(How = How.CssSelector, Using = "div.job-ad-information__show-info")]
        public IWebElement theRightSidePanel { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-ad-information__title--edit-mode:nth-child(3) .select2-container")]
        public IWebElement jobCategoryDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-ad-information__title--edit-mode:nth-child(2) .select2-container")]
        public IWebElement jobTypeDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-ad-information__title--edit-mode:nth-child(1) .select2-container")]
        public IWebElement positionLevelDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".select2-results__option")]
        public IList<IWebElement> selectDropdownItem { get; set; }

        [FindsBy(How = How.Id, Using = "location-dropdown")]
        public IWebElement locationDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li.job-ad-information__location-item")]
        public IList<IWebElement> locationItem { get; set; }

        [FindsBy(How = How.CssSelector, Using = "bravo-select.job-ad-information__skill-select")]
        public IWebElement skillDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".bravo-select__item span")]
        public IList<IWebElement> selectSkill { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.checked-checkbox")] 
        public IWebElement checkboxSalary { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".salary__from-salary .default-input")]
        public IWebElement formSalaryField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".salary__to-salary .default-input")]
        public IWebElement toSalaryField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".salary__currency .select2-container")]
        public IWebElement salaryCurrencyDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".salary__salary-period .select2-container ")]
        public IWebElement salaryPeriodDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-ad-information__title--edit-mode:nth-child(7) .default-input")]
        public IWebElement vacanciesField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-ad-information__title--edit-mode:nth-child(8) .default-input")]
        public IWebElement contactPersonField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-ad-information__submit .button.button--primary")]
        public IWebElement saveButtonInJobInformation { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-ad-information__submit .button.button--secondary")]
        public IWebElement cancelButtonInJobInformation { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-ad-information__title:nth-child(1) .job-ad-information__detail")]
        public IWebElement positionLevelValue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-ad-information__title:nth-child(2) .job-ad-information__detail")]
        public IWebElement jobTypeValue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-ad-information__title:nth-child(3) .job-ad-information__detail")]
        public IWebElement jobCategoryValue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-ad-information__title:nth-child(4) .job-ad-information__detail")]
        public IWebElement locationlValue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-ad-information__title:nth-child(5) .job-ad-information__skill-text")]
        public IWebElement skillValue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-ad-information__title:nth-child(6) .job-ad-information__detail")]
        public IWebElement salaryValue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-ad-information__title:nth-child(7) .job-ad-information__detail")]
        public IWebElement vacanciesValue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-ad-information__title:nth-child(8) .job-ad-information__detail")]
        public IWebElement contactPersonValue { get; set; }

        //Apply before date picker
        [FindsBy(How = How.CssSelector, Using = ".job-header__date-picker-icon.sprite-calendar.big")]
        public IWebElement calendarIcon { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.job-header__choose-date-text")]
        public IWebElement clickHereToSet { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.topbar-title")]
        public IWebElement calendarTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "svg:nth-child(3)")]
        public IWebElement nextMonthIcon { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.day-unit")]
        public IList<IWebElement> selectDay { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.job-header__date-text")]
        public IList<IWebElement> applyBeforeDate { get; set; }


        //Job Portal
        [FindsBy(How = How.CssSelector, Using = "li:nth-child(1) div.hidden-xs a")]
        public IWebElement theFirstJobInJobPortal { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".joblist_total-jobs-number.hidden-sm.hidden-md")]
        public IWebElement jobListTotal { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.job-detail__job-description")]
        public IWebElement jobDescriptionInJobPortal { get; set; }

        //Advertise tab
        [FindsBy(How = How.CssSelector, Using = "a.avt-list-board__view_job_post")]
        public IWebElement viewjobPostLink { get; set; }
       
        //Status pipeline
        [FindsBy(How = How.CssSelector, Using = "li:nth-child(3) .job-status-bar__text")]
        public IWebElement publishedStateOnStatusBar { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-status-bar__item--current-state .job-status-bar__text")]
        public IWebElement currentStateOfJob { get; set; }

        //Confirmation modal
        [FindsBy(How = How.CssSelector, Using = ".republish-confirmation-modal__action .button.button--primary")]
        public IWebElement republishedButtonInRepublishConfirmationModal { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#closeJobConfirmationModal .button.button--primary")]
        public IWebElement closedButtonInClosedJobConfirmationModal { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".revert-confirmation-modal__action .button.button--primary")]
        public IWebElement revertButtonInRevertConfirmationModal { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".thankyou-email-form__footer .button.button--primary")]
        public IWebElement finishJobButton { get; set; }


    }
}
