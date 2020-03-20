using bravoTALENTS_Cucumber.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace bravoTALENTS_Cucumber.StepsDefinition.CandidatePage.CandidateCard
{
    [Binding]
    public sealed class ChangeStatusCandidateStepDefinition
    {
        [Given(@"I add an application to the candidate")]
        public void GivenIAddAnApplicationToTheCandidate()
        {
            BasePage.CandidateCardPO.AddAccountantApplicationInCandidateCard();
        }

        [Given(@"I close the candidate card panel")]
        public void GivenICloseTheCandidateCardPanel()
        {
            BasePage.CandidateCardPO.btnCloseCandidateCardPanel.Click();
        }


        [Given(@"I change the status to Applied")]
        public void GivenIChangeTheStatusToApplied()
        {
            BasePage.CandidateCardPO.ChangeStatusCandidate(BasePage.CandidateCardPO.btnAppliedStatus);
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateStatus, "Applied"));
        }

        [Given(@"I change the status to In Review")]
        public void GivenIChangeTheStatusToInReview()
        {
            GivenIChangeTheStatusToApplied();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("In Review")));
            //change status to In review
            BasePage.CandidateCardPO.ChangeStatusCandidate(BasePage.CandidateCardPO.btnInReviewStatus);
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateStatus, "In Review"));
        }

        [Given(@"I change the status to Phone Interview")]
        public void GivenIChangeTheStatusToPhoneInterview()
        {
            GivenIChangeTheStatusToInReview();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Phone Interview")));
            //change status to Phone interview
            BasePage.CandidateCardPO.ChangeStatusCandidate(BasePage.CandidateCardPO.btnPhoneInterviewStatus);
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateStatus, "Phone Interview"));
        }

        [Given(@"I change the status to On-site Interview")]
        public void GivenIChangeTheStatusToOn_SiteInterview()
        {
            GivenIChangeTheStatusToPhoneInterview();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("On-site Interview")));
            //change status to On-site interview
            BasePage.CandidateCardPO.ChangeStatusCandidate(BasePage.CandidateCardPO.btnOnsiteInterviewStatus);
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateStatus, "On-site Interview"));
        }

        [Given(@"I change the status to Offer")]
        public void GivenIChangeTheStatusToOffer()
        {
            GivenIChangeTheStatusToOn_SiteInterview();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Offer")));
            //change status to Offer
            BasePage.CandidateCardPO.ChangeStatusCandidate(BasePage.CandidateCardPO.btnOfferStatus);
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateStatus, "Offer"));
        }

        [Given(@"I change the status to Hired")]
        public void GivenIChangeTheStatusToHired()
        {
            GivenIChangeTheStatusToOffer();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Hired")));
            BasePage.CandidateCardPO.ChangeStatusCandidate(BasePage.CandidateCardPO.btnHiredStatus);
            BasePage.CandidateCardPO.subjectEmail.SendKeys("Subject");
            BasePage.CandidateCardPO.btnConfirmSendHiredEmail.Click();
        }


        [Then(@"the status of the candidate should be ""(.*)""")]
        public void ThenTheStatusOfTheCandidateShouldBe(string status)
        {
            Assert.AreEqual(status, BasePage.CandidatePO.firstCandidateStatus.Text);
        }


    }
}
