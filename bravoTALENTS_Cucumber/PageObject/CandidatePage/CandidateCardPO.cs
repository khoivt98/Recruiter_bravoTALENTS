using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace bravoTALENTS_Cucumber.PageObject.CandidatePage
{
    class CandidateCardPO
    {
        //Edit info candidate
        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Edit Info')]")]
        public IWebElement btnEditInfo { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = ".candidate-list-action__button .sprite-remove")]
        public IWebElement btnCloseCandidateCardPanel { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".candidate-card-edit__item:nth-child(4) input")]
        public IWebElement fieldEmail { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = ".candidate-card-edit__item:nth-child(5) input")]  
        public IWebElement fieldMobile { get; set; } 

        [FindsBy(How = How.CssSelector, Using = ".candidate-card-edit__item:nth-child(6) .select2-selection")]
        public IWebElement dropdownGender { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".select2-results__option")]
        public IList<IWebElement> optionsGender { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".candidate-card-edit__item:nth-child(7) .select2-selection")]
        public IWebElement dropdownMartialStatus { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".select2-results__option")]
        public IList<IWebElement> optionsMartialStatus { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".candidate-card-edit__item:nth-child(10) input")]
        public IWebElement fieldCity { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".candidate-card-edit__footer .button--primary")]
        public IWebElement btnSaveEditInfo { get; set; } 

        [FindsBy(How = How.XPath, Using = "//span[contains(.,' No job application ')]")]
        public IWebElement linkNoJobApplication { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".primary-list__item:nth-child(2) span")]
        public IWebElement textMobile { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".primary-list__item:nth-child(4) span")]
        public IWebElement textGender { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".primary-list__item:nth-child(5) span")]
        public IWebElement textMartialStatus { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".primary-list__item:nth-child(3) span")]
        public IWebElement textCity { get; set; }

        //Add attachment
        [FindsBy(How = How.Id, Using = "upload")]
        public IWebElement uploadFile { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".primary-list__link .primary-list__text--full")]
        public IWebElement uploadedFileText { get; set; } 

        [FindsBy(How = How.XPath, Using = "//p[contains(.,'+ Add new tag')]")]
        public IWebElement linkAddTag { get; set; }

        [FindsBy(How = How.Id, Using = "dropdownMenuInput")]
        public IWebElement inputTagField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".application-tag__text:nth-child(1)")]
        public IWebElement firstTagOfCandidate { get; set; }

        //Assign job to the candidate

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Select job')]")]
        public IWebElement dropdownAssignJob { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".select2-results__option")]
        public IList<IWebElement> listAssignJob { get; set; }

        //Change status of the candidate
        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Assign application')]")]
        public IWebElement assignApplicationLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Assign')]")]
        public IWebElement btnAssignApplication { get; set; } 

        [FindsBy(How = How.CssSelector, Using = ".ng-tns-c32-6 .select2-hidden-accessible")]
        public IWebElement dropdownListAssignJob { get; set; }

        [FindsBy(How = How.LinkText, Using = "Applied")]
        public IWebElement btnAppliedStatus { get; set; }

        [FindsBy(How = How.LinkText, Using = "In Review")]
        public IWebElement btnInReviewStatus { get; set; }

        [FindsBy(How = How.LinkText, Using = "Phone Interview")]
        public IWebElement btnPhoneInterviewStatus { get; set; }

        [FindsBy(How = How.LinkText, Using = "On-site Interview")]
        public IWebElement btnOnsiteInterviewStatus { get; set; }

        [FindsBy(How = How.LinkText, Using = "Offer")]
        public IWebElement btnOfferStatus { get; set; }

        //Change status to Hired
        [FindsBy(How = How.Id, Using = "nextState")]
        public IWebElement btnHiredStatus { get; set; } 

        [FindsBy(How = How.CssSelector, Using = ".form-group .email-form__input")]
        public IWebElement subjectEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Confirm hiring and send email')]")]
        public IWebElement btnConfirmSendHiredEmail { get; set; }

        //Reject candidate
        [FindsBy(How = How.Id, Using = "rejectedApplication")]
        public IWebElement iconReject { get; set; }

        [FindsBy(How = How.LinkText, Using = "Undo Reject")]
        public IWebElement btnUndoReject { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//span[contains(.,'This candidate has been rejected.')]")]
        public IWebElement msgReject { get; set; }

        //View job
        [FindsBy(How = How.CssSelector, Using = ".candidate-card__info .candidate-card__small-link")]
        public IWebElement linkViewJob { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-header .job-header__job-title-section div")]
        public IWebElement jobHeaderTitle { get; set; }

        //View CV
        [FindsBy(How = How.LinkText, Using = "View CV")]
        public IWebElement linkViewCV { get; set; }

        public void EditInformationCandidate(string mobile, string gender, string martialStatus, string city)
        {
            fieldMobile.Clear();
            fieldMobile.SendKeys(mobile);
            BasePage.CandidateCardPO.dropdownGender.Click();
            Thread.Sleep(500);
            MyDriver.getElementByName(BasePage.CandidateCardPO.optionsGender, gender).Click();
            BasePage.CandidateCardPO.dropdownMartialStatus.Click();
            Thread.Sleep(500);
            MyDriver.getElementByName(BasePage.CandidateCardPO.optionsMartialStatus, martialStatus).Click();
            fieldCity.Clear();
            fieldCity.SendKeys(city);
        }

        public void AddAccountantApplicationInCandidateCard()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(.,' No job application ')]")));
            linkNoJobApplication.Click();
            assignApplicationLink.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(.,'Select job')]")));
            dropdownAssignJob.Click();
            Thread.Sleep(500);
            IWebElement AccountantApplication = MyDriver.getElementByName(listAssignJob, "Accountant");
            AccountantApplication.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Assign')]")));
            btnAssignApplication.Click();
        }

        public void ChangeStatusCandidate(IWebElement status)
        {
            status.Click();           
        }
    }
}
