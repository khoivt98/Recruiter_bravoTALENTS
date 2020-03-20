using System;
using System.Collections.Generic;
using System.Threading;
using bravoTALENTS_Cucumber.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace bravoTALENTS_Cucumber.StepsDefinition.CandidatePage
{
    [Binding]
    public sealed class FilterCandidateStepDefinition
    {
        [Given(@"I click on the Followed menu")]
        public void GivenIClickOnTheFollowedMenu()
        {
            BasePage.CandidatePO.filterFollowedCandidate.Click();
            Thread.Sleep(2000);
        }

        [Then(@"the candidate list will display the followed candidate")]
        public void ThenTheCandidateListWillDisplayTheFollowedCandidate()
        {
            bool result = MyDriver.IsElementVisible(MyDriver.driver, By.CssSelector(".candidate-content:nth-child(1) .sprite-filled-star"));
            Assert.IsTrue(result);
        }

        [Given(@"I click on the Sourced pipeline")]
        public void GivenIClickOnTheSourcedPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(.,'Sourced')]")));
            BasePage.CandidatePO.filterSourced.Click();
        }

        [Given(@"I click on the Applied pipeline")]
        public void GivenIClickOnTheAppliedPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(.,'Applied')]")));
            BasePage.CandidatePO.filterApplied.Click();
        }

        [Then(@"the candidate list will display the candidates have status Applied")]
        public void ThenTheCandidateListWillDisplayTheCandidatesHaveStatus()
        {
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateStatus, "Applied"));
            Assert.AreEqual("Applied", BasePage.CandidatePO.firstCandidateStatus.Text);
        }



        [Then(@"the candidate list will display the candidates have status Sourced")]
        public void ThenTheCandidateListWillDisplayTheCandidatesHaveStatusSourced()
        {
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateStatus, "Sourced"));
            Assert.AreEqual("Sourced", BasePage.CandidatePO.firstCandidateStatus.Text);
        }

        [Given(@"I click on the In Review pipeline")]
        public void GivenIClickOnTheInReviewPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(.,'In Review')]")));
            BasePage.CandidatePO.filterInReview.Click();
        }

        [Then(@"the candidate list will display the candidates have status In Review")]
        public void ThenTheCandidateListWillDisplayTheCandidatesHaveStatusInReview()
        {
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateStatus, "In Review"));
            Assert.AreEqual("In Review", BasePage.CandidatePO.firstCandidateStatus.Text);
        }

        [Given(@"I click on the Phone Interview pipeline")]
        public void GivenIClickOnThePhoneInterviewPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(.,'Phone Interview')]")));
            BasePage.CandidatePO.filterPhoneInterview.Click();
        }

        [Then(@"the candidate list will display the candidates have status Phone Interview")]
        public void ThenTheCandidateListWillDisplayTheCandidatesHaveStatusPhoneInterview()
        {
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateStatus, "Phone Interview"));
            Assert.AreEqual("Phone Interview", BasePage.CandidatePO.firstCandidateStatus.Text);
        }

        [Given(@"I click on the On-site Interview pipeline")]
        public void GivenIClickOnTheOn_SiteInterviewPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(.,'On-site Interview')]")));
            BasePage.CandidatePO.filterOnsiteInterview.Click();
        }

        [Then(@"the candidate list will display the candidates have status On-site Interview")]
        public void ThenTheCandidateListWillDisplayTheCandidatesHaveStatusOn_SiteInterview()
        {
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateStatus, "On-site Interview"));
            Assert.AreEqual("On-site Interview", BasePage.CandidatePO.firstCandidateStatus.Text);
        }

        [Given(@"I click on the Offer pipeline")]
        public void GivenIClickOnTheOfferPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(.,'Offer')]")));
            BasePage.CandidatePO.filterOffer.Click();
        }

        [Then(@"the candidate list will display the candidates have status Offer")]
        public void ThenTheCandidateListWillDisplayTheCandidatesHaveStatusOffer()
        {
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateStatus, "Offer"));
            Assert.AreEqual("Offer", BasePage.CandidatePO.firstCandidateStatus.Text);
        }

        [Given(@"I click on icon right arrow pipeline")]
        public void GivenIClickOnIconRightArrowPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".sprite-big-right-arrow")));
            BasePage.CandidatePO.iconArrowRightPipeline.Click();
        }

        [Given(@"I click on the Hired pipeline")]
        public void GivenIClickOnTheHiredPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(.,'Hired')]")));
            BasePage.CandidatePO.filterHired.Click();
        }

        [Then(@"the candidate list will display the candidates have status Hired")]
        public void ThenTheCandidateListWillDisplayTheCandidatesHaveStatusHired()
        {
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateStatus, "Hired"));
            Assert.AreEqual("Hired", BasePage.CandidatePO.firstCandidateStatus.Text);
        }

        [Given(@"I click into Filter icon")]
        public void GivenIClickIntoFilterIcon()
        {
            BasePage.CandidatePO.iconFilterJob.Click();     
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".jobs-section__option-job-filter")));
        }

        [Given(@"I filter the candidate with E(.*)E job")]
        public void GivenIFilterTheCandidateWithEEJob(int p0)
        {
            IWebElement E2EJob = MyDriver.getElementByName(BasePage.CandidatePO.listJobFilter, "E2E Job");
            E2EJob.Click();
            Thread.Sleep(1000);
            BasePage.CandidatePO.iconCloseFilterPanel.Click();
        }

        [Then(@"the candidate list will display the candidates has the filtered job")]
        public void ThenTheCandidateListWillDisplayTheCandidatesHasTheFilteredJob()
        {
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateName, "e2e candidate"));
            Assert.AreEqual("E2E Job", BasePage.CandidatePO.firstCandidateJob.Text);
        }

        [Given(@"I filter the candidate with the E(.*)e tag")]
        public void GivenIFilterTheCandidateWithTheEeTag(int p0)
        {
            BasePage.CandidatePO.E2eTag.Click();
            Thread.Sleep(1000);
            BasePage.CandidatePO.iconCloseFilterPanel.Click();
        }

        [Then(@"the candidate list will display the candidates has the filtered tag")]
        public void ThenTheCandidateListWillDisplayTheCandidatesHasTheFilteredTag()
        {
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateName, "e2e candidate"));
            Assert.AreEqual("e2e candidate", BasePage.CandidatePO.firstCandidateName.Text);
        }

        [Given(@"I click on the checkbox Show rejected candidates")]
        public void GivenIClickOnTheCheckboxShowRejectedCandidates()
        {
            BasePage.CandidatePO.cbxShowRejectedCandidate.Click();
            BasePage.CandidatePO.iconCloseFilterPanel.Click();
        }

        [Given(@"I click on the Rejected pipeline")]
        public void GivenIClickOnTheRejectedPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(.,'Rejected')]")));
            BasePage.CandidatePO.filterRejected.Click();
            Thread.Sleep(2000);
        }

        [Then(@"the candidate list will display the candidates have status Rejected")]
        public void ThenTheCandidateListWillDisplayTheCandidatesHaveStatusRejected()
        {
            Assert.IsTrue(MyDriver.IsElementVisible(MyDriver.driver, By.CssSelector(".candidate-content:nth-child(1) .sprite-circle-remove")));
        }


    }
}
