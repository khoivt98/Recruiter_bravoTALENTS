using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace bravoTALENTS_Cucumber.PageObject.CandidatePage
{
    class CandidateDetailPO
    {

        //Tab Activity
        [FindsBy(How = How.LinkText, Using = "Activity")]
        public IWebElement tabActivity { get; set; }

        [FindsBy(How = How.LinkText, Using = "Interview")]
        public IWebElement tabInterview { get; set; }

        [FindsBy(How = How.LinkText, Using = "Offer")]
        public IWebElement tabOffer { get; set; }

        //Summary
        [FindsBy(How = How.CssSelector, Using = ".cv-content__item  .cv-content__summary")]
        public IWebElement fieldSummary { get; set; }      

        //Button Add items
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Add item')]")]
        public IWebElement btnAddItem { get; set; }

        [FindsBy(How = How.LinkText, Using = "Work Experience")]
        public IWebElement btnAddWorkExperience { get; set; }

        [FindsBy(How = How.LinkText, Using = "Educations")]
        public IWebElement btnAddEducation { get; set; }

        [FindsBy(How = How.LinkText, Using = "Skills")]
        public IWebElement btnAddSkill { get; set; }

        [FindsBy(How = How.LinkText, Using = "Language skills")]
        public IWebElement btnAddLanguage { get; set; }

        [FindsBy(How = How.LinkText, Using = "Projects")]
        public IWebElement btnAddProject { get; set; }

        [FindsBy(How = How.LinkText, Using = "Courses")]
        public IWebElement btnAddCourses { get; set; }

        [FindsBy(How = How.LinkText, Using = "Certifications")]
        public IWebElement btnAddCertification { get; set; }

        [FindsBy(How = How.LinkText, Using = "References")]
        public IWebElement btnAddReference { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Save')]")]
        public IWebElement btnSave { get; set; }

        //Input fields work experience
        [FindsBy(How = How.Id, Using = "companyInput")]
        public IWebElement fieldCompany { get; set; }

        [FindsBy(How = How.Id, Using = "positionInput")]
        public IWebElement fieldPosition { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".date-duration-from .select2-container")]
        public IList<IWebElement> durationFrom { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".select2-results__option:nth-child(1)")]
        public IWebElement January { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".select2-results__option:nth-child(2)")]
        public IWebElement Febuary { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".date-duration-to .select2-container")]
        public IList<IWebElement> durationTo { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".cv-content__item .time-line__title")]
        public IWebElement titleWorkExperience { get; set; }

        //input field education
        [FindsBy(How = How.Id, Using = "schoolNameInput")]
        public IWebElement fieldSchoolName { get; set; }

        //input field language
        [FindsBy(How = How.Id, Using = "nameInput")]
        public IWebElement fieldLanguageName { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".language-skills-form__item .select2-container")]
        public IWebElement dropdownLevelLanguage { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".select2-results__option:nth-child(1)")]
        public IWebElement levelBeginner { get; set; }

        //input field project
        [FindsBy(How = How.CssSelector, Using = ".project-form #name")]
        public IWebElement fieldProjectName { get; set; }

        //input field course
        [FindsBy(How = How.CssSelector, Using = ".course-form #name")]
        public IWebElement fieldCourseName { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".form-group .default-form__select2-from-month")]
        public IWebElement fromMonth { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".form-group .default-form__select2-to-month")]
        public IWebElement toMonth { get; set; }

        //input field project
        [FindsBy(How = How.CssSelector, Using = ".certification-form #name")]
        public IWebElement fieldCertificationName {get; set;}

        //input field reference
        [FindsBy(How = How.CssSelector, Using = ".reference-form #nameInput")]
        public IWebElement fieldFullName { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".form-group:nth-child(2) input")]
        public IWebElement fieldEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".form-group:nth-child(3) input")]
        public IWebElement fieldPhone { get; set; }

        //icon edit & delete item
        [FindsBy(How = How.CssSelector, Using = ".cv-content__item .sprite-x-pen")]
        public IWebElement iconEditItem { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".cv-content__item .sprite-trash")]
        public IWebElement iconDeleteItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Delete')]")]
        public IWebElement btnConfirmDelete { get; set; }

        //Comment
        [FindsBy(How = How.CssSelector, Using = ".activity-content__comment-box .comment-box__textarea")]
        public IWebElement fieldComment { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".activity-container__activity-body p")]
        public IWebElement contentComment { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".activity-container__activity-body .comment-box__textarea")]
        public IWebElement fieldEditComment { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".activity-container__activity-footer .activity-footer__reply-block-click")]
        public IWebElement btnReply { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".comment-box--reply-section .comment-box__textarea")]
        public IWebElement fieldReplyComment { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".activity__reply p")]
        public IWebElement contentCommentReply { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".activity-container__activity-footer .activity-footer__agree-click")]
        public IWebElement btnAgreeComment { get; set; }

        //Interview
        [FindsBy(How = How.CssSelector, Using = ".interview__button")]
        public IWebElement btnScheduleInterview { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".form-group .prepare-info-form__select")]
        public IWebElement dropdownInterview { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".form-group .prepare-info-form__select input")]
        public IWebElement fieldInterviewer { get; set; }

        [FindsBy(How = How.LinkText, Using = "Next")]
        public IWebElement btnNextSchedule { get; set; }

        [FindsBy(How = How.LinkText, Using = "Schedule")]
        public IWebElement btnSchedule { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".interview__item-info .interview__detail-info")]
        public IWebElement detailInterview { get; set; }

        [FindsBy(How = How.LinkText, Using = "Review")]
        public IWebElement tabReview { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".interview-result .interview-result__button-passed")]
        public IWebElement btnPassInterview { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".interview-result .interview-result__button-failed")]
        public IWebElement btnFailInterview { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".interview-result .interview-result__button-passed--active")]
        public IWebElement iconPassedInterview { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".interview-result .interview-result__button-failed--active")]
        public IWebElement iconFailedInterview { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".interview-comment__content textarea")]
        public IWebElement fieldCommentInterview { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Save')]")]
        public IWebElement btnSaveDecisionInterview { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Update Review')]")]
        public IWebElement btnUpdateReview { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".interview-comment__text-display")]
        public IWebElement txtComment { get; set; }

        //Offer
        [FindsBy(How = How.CssSelector, Using = ".offer-salary__input")]
        public IWebElement fieldSalary { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".offer-report-to__input")]
        public IWebElement fieldReportTo { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".offer-form .checkbox-label")]
        public IWebElement cbxWithoutSendEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Create Offer')]")]
        public IWebElement btnCreateOffer { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".email-section .select2-selection")]
        public IWebElement dropdownTemplateOfferEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".select2-results__option")]
        public IList<IWebElement> optionTemplateOfferEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Send Email')]")]
        public IWebElement btnSendEmailOffer { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".accept-offer .accept-offer__accept-icon")]
        public IWebElement btnStatusAccept { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".reject-offer .reject-offer__reject-icon")]
        public IWebElement btnStatusReject { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".offer__comment-box .offer__comment-input")]
        public IWebElement fieldCommentOffer { get; set; }

        [FindsBy(How = How.LinkText, Using = "Update Offer")]
        public IWebElement linkUpdateOffer { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Save')]")]
        public IWebElement btnSaveOffer { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Email Offer')]")]
        public IWebElement btnEmailOffer { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".offer-form .offer__update-decision-text")]
        public IWebElement linkUpdateDecision { get; set; }

        public void fillDuration(IWebElement dropdownFrom, IWebElement elementFrom, IWebElement dropdownTo, IWebElement elementTo)
        {
            dropdownFrom.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".select2-results__option:nth-child(1)")));
            elementFrom.Click();
            dropdownTo.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".select2-results__option:nth-child(1)")));
            elementTo.Click();
        }

        public void openItemPanel(IWebElement elementItem)
        {
            btnAddItem.Click(); 
            elementItem.Click();
        }

        public void updateStatusInterview(IWebElement elementStatus, string comment)
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".interview-result .interview-result__button-passed")));
            elementStatus.Click();
            BasePage.CandidateDetailPO.fieldCommentInterview.SendKeys(comment);
            BasePage.CandidateDetailPO.btnSaveDecisionInterview.Click();
        }

        public void updateResultInterview(IWebElement elementStatus, string comment)
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(.,'Update Review')]")));
            btnUpdateReview.Click();
            elementStatus.Click();
            fieldCommentInterview.Clear();
            fieldCommentInterview.SendKeys(comment);
            btnSaveDecisionInterview.Click();
        }

        public void createOffer(string salary, string reportTo)
        {
            fieldSalary.SendKeys(salary);
            fieldReportTo.SendKeys(reportTo);
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Create Offer')]")));
            btnCreateOffer.Click();
        }

        public void createOfferWithOutSendEmail(string salary, string reportTo)
        {
            fieldSalary.SendKeys(salary);
            fieldReportTo.SendKeys(reportTo);
            cbxWithoutSendEmail.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Create Offer')]")));
            btnCreateOffer.Click();
        }

        public void updateStatusOffer(IWebElement elementStatus, string comment)
        {
            elementStatus.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".offer__comment-box .offer__comment-input")));
            BasePage.CandidateDetailPO.fieldCommentOffer.Clear();
            BasePage.CandidateDetailPO.fieldCommentOffer.SendKeys(comment);
            btnSaveOffer.Click();
        }
    }
}
