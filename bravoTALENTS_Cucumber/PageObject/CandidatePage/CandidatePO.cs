using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bravoTALENTS_Cucumber.PageObject.CandidatePage
{
    class CandidatePO
    {
        //Menu Candidate
        [FindsBy(How = How.ClassName, Using = "bravo-menu__btn-content")]
        public IWebElement dropdownMenu { get; set; }

        [FindsBy(How = How.LinkText, Using = "Candidates")]
        public IWebElement menuCandidate { get; set; } 

        [FindsBy(How = How.ClassName, Using = "sprite-arrow-right")]
        public IWebElement dropdownCandidateMode { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".pipeline-filter__drop-down-item:nth-child(2) .pipeline-filter__drop-down-label")]
        public IWebElement candidateModeAll { get; set; }
        
        //Create a new candidate
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Add Candidate')]")] 
        public IWebElement btnAddCandidate { get; set; }
        
        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement fieldFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement fieldLastName { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement fieldEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Save')]")]
        public IWebElement btnSaveCandidate { get; set; }

        //Import candidate file 
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'+ Import candidates')]")]
        public IWebElement btnImportCandidate { get; set; }

        [FindsBy(How = How.Id, Using = "file")]
        public IWebElement fieldUploadFile { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".candidate-import__checkmark:nth-child(2)")]
        public IWebElement optionSkipCandidate { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".candidate-import__button-container .button--primary")]
        public IWebElement btnImport { get; set; } 

        [FindsBy(How = How.CssSelector, Using = ".alert-success")]
        public IWebElement alertSuccessMSG { get; set; }

        //Add an application into the candidate
        [FindsBy(How = How.CssSelector, Using = ".sprite-assign")]
        public IWebElement iconAddApplication { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Select job')]")]
        public IWebElement dropdownAssignJob { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".select2-results__option")]
        public IList<IWebElement> listAssignJob { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-application-card__submit .button--primary")]
        public IWebElement btnAddApplication { get; set; }

        //Candidate Attribute
        [FindsBy(How = How.CssSelector, Using = ".candidate-content:nth-child(1)")]
        public IWebElement firstCandidateRow { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".candidate-content:nth-child(1) td:nth-child(4) div")]
        public IWebElement firstCandidateName { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".candidate-content:nth-child(1) .candidate-table__body__job-section")]
        public IWebElement firstCandidateJob { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".candidate-content:nth-child(1) .checkbox-label")]
        public IWebElement firstCandidateCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".candidate-content:nth-child(1) td:nth-child(6)")]
        public IWebElement firstCandidateAppliedDate { get; set; }

        //Follow candidate
        [FindsBy(How = How.CssSelector, Using = ".sprite-faded-star")]
        public IWebElement iconFollowCandidate { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".candidate-content:nth-child(1) .sprite-filled-star")]
        public IWebElement firstCandidateNameFollowed { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".sprite-x-star")]
        public IWebElement iconUnFollowCandidate { get; set; }

        //Search candidate  
        [FindsBy(How = How.CssSelector, Using = ".navigation-search__text")]
        public IWebElement fieldSearchCandidate { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".navigation-search__submit-button")]
        public IWebElement iconSearchCandidate { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-result__candidate-list")]
        public IWebElement suggestionListSearchResult { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-result__candidate-list-item:nth-child(1)")]
        public IWebElement firstCandidateInSuggestionList { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".candidate-card__info .candidate-card__name")]
        public IWebElement candidateNameInCandidateCard { get; set; }

        //Filter followed candidate
        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Followed')]")]
        public IWebElement filterFollowedCandidate { get; set; }

        //Filtler candidate by status 
        [FindsBy(How = How.CssSelector, Using = ".sprite-big-right-arrow")]
        public IWebElement iconArrowRightPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".candidate-content:nth-child(1) .candidate-content__status-text")]
        public IWebElement firstCandidateStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'Sourced')]")]
        public IWebElement filterSourced { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'Applied')]")]
        public IWebElement filterApplied { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'In Review')]")]
        public IWebElement filterInReview { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'Phone Interview')]")]
        public IWebElement filterPhoneInterview { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'On-site Interview')]")]
        public IWebElement filterOnsiteInterview { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'Offer')]")]
        public IWebElement filterOffer { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'Hired')]")]
        public IWebElement filterHired { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Show rejected candidates')]")]
        public IWebElement cbxShowRejectedCandidate { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'Rejected')]")]
        public IWebElement filterRejected { get; set; }

        //Filter candidate by job 
        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Filter')]")]
        public IWebElement iconFilterJob { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'E2E Job')]")]
        public IWebElement E2EJob { get; set; } 

        [FindsBy(How = How.CssSelector, Using = ".filter-action-list__button .sprite-remove")]
        public IWebElement iconCloseFilterPanel { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".jobs-section__option-job-filter-item .jobs-section__job-name")]
        public IList<IWebElement> listJobFilter { get; set; }

        //Filter candidate by tag
        [FindsBy(How = How.LinkText, Using = "E2e (1)")]
        public IWebElement E2eTag { get; set; }

        public void addApplicationIntoCandidate()
        {
            iconAddApplication.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(.,'Select job')]")));
            dropdownAssignJob.Click();
            IWebElement AccountantApplication = MyDriver.getElementByName(listAssignJob, "Accountant");
            AccountantApplication.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".job-application-card__submit .button--primary")));
            btnAddApplication.Click();
        }
    }
}
