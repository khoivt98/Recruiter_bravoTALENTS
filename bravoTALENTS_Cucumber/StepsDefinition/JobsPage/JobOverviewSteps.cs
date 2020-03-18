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

namespace bravoTALENTS_Cucumber.StepsDefinition.JobsPage
{
    [Binding]
    public sealed class JobOverviewSteps
    {
        string totalCandidateInOverviewScreen;
        string jobTitleInOverviewScreen;

        [When(@"I click into the first job")]
        public void WhenIClickIntoTheFirstJob()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementExists(By.CssSelector(".job-content:nth-child(1)")));
            BasePage.JobListPO.theFirstJob.Click();
        }

        [When(@"I click on the all pipeline")]
        public void WhenIClickOnTheAllPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.theAllPipeline));
            totalCandidateInOverviewScreen = BasePage.JobDetailPO.theNumberOfAllPipeline.Text;
            jobTitleInOverviewScreen = BasePage.JobDetailPO.theJobTitle.Text;
            BasePage.JobDetailPO.theAllPipeline.Click();
        }

        [Then(@"The candidate list is filter by all and job")]
        public void ThenTheCandidateListIsFilterByAllAndJob()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(1) .pipeline-filter__stage-number")));
            string totalCandidateInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("li:nth-child(1) .pipeline-filter__stage-number")).Text;
            string jobTitleInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("span.filter-panel__label")).Text;
            

            Assert.Multiple(() =>
            {
                Assert.AreEqual(totalCandidateInCandidateScreen, totalCandidateInOverviewScreen, "Wrong number");
                Assert.AreEqual(jobTitleInCandidateScreen, jobTitleInOverviewScreen, "Wrong title");
                Assert.IsTrue(Utility.isElementPresent(By.CssSelector(".pipeline-filter__item:nth-child(1) .pipeline-filter__item-detail.active")));
            });
        }

        [When(@"I click on the sourced pipeline")]
        public void WhenIClickOnTheSourcedPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.theSourcedPipeline));
            totalCandidateInOverviewScreen = BasePage.JobDetailPO.theNumberOfSourcedPipeline.Text;
            jobTitleInOverviewScreen = BasePage.JobDetailPO.theJobTitle.Text;
            BasePage.JobDetailPO.theSourcedPipeline.Click();
        }

        [Then(@"The candidate list is filter by sourced and job")]
        public void ThenTheCandidateListIsFilterBySourcedAndJob()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(2) .pipeline-filter__stage-number")));
            string totalCandidateInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("li:nth-child(2) .pipeline-filter__stage-number")).Text;
            string jobTitleInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("span.filter-panel__label")).Text;


            Assert.Multiple(() =>
            {
                Assert.AreEqual(totalCandidateInCandidateScreen, totalCandidateInOverviewScreen, "Wrong number");
                Assert.AreEqual(jobTitleInCandidateScreen, jobTitleInOverviewScreen, "Wrong title");
                Assert.IsTrue(Utility.isElementPresent(By.CssSelector(".pipeline-filter__item:nth-child(2) .pipeline-filter__item-detail.active")));
            });
        }

        [When(@"I click on the applied pipeline")]
        public void WhenIClickOnTheAppliedPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.theAppliedPipeline));
            totalCandidateInOverviewScreen = BasePage.JobDetailPO.theNumberOfAppliedPipeline.Text;
            jobTitleInOverviewScreen = BasePage.JobDetailPO.theJobTitle.Text;
            BasePage.JobDetailPO.theAppliedPipeline.Click();
        }

        [Then(@"The candidate list is filter by applied and job")]
        public void ThenTheCandidateListIsFilterByAppliedAndJob()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(3) .pipeline-filter__stage-number")));
            string totalCandidateInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("li:nth-child(3) .pipeline-filter__stage-number")).Text;
            string jobTitleInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("span.filter-panel__label")).Text;


            Assert.Multiple(() =>
            {
                Assert.AreEqual(totalCandidateInCandidateScreen, totalCandidateInOverviewScreen, "Wrong number");
                Assert.AreEqual(jobTitleInCandidateScreen, jobTitleInOverviewScreen, "Wrong title");
                Assert.IsTrue(Utility.isElementPresent(By.CssSelector(".pipeline-filter__item:nth-child(3) .pipeline-filter__item-detail.active")));
            });
        }

        [When(@"I click on the in review pipeline")]
        public void WhenIClickOnTheInReviewPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.theInReivewPipeline));
            totalCandidateInOverviewScreen = BasePage.JobDetailPO.theNumberOfInReivewPipeline.Text;
            jobTitleInOverviewScreen = BasePage.JobDetailPO.theJobTitle.Text;
            BasePage.JobDetailPO.theInReivewPipeline.Click();
        }

        [Then(@"The candidate list is filter by in review and job")]
        public void ThenTheCandidateListIsFilterByInReviewAndJob()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(4) .pipeline-filter__stage-number")));
            string totalCandidateInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("li:nth-child(4) .pipeline-filter__stage-number")).Text;
            string jobTitleInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("span.filter-panel__label")).Text;


            Assert.Multiple(() =>
            {
                Assert.AreEqual(totalCandidateInCandidateScreen, totalCandidateInOverviewScreen, "Wrong number");
                Assert.AreEqual(jobTitleInCandidateScreen, jobTitleInOverviewScreen, "Wrong title");
                Assert.IsTrue(Utility.isElementPresent(By.CssSelector(".pipeline-filter__item:nth-child(4) .pipeline-filter__item-detail.active")));
            });
        }

        [When(@"I click on the phone interview pipeline")]
        public void WhenIClickOnThePhoneInterviewPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.thePhoneReviewPipeline));
            totalCandidateInOverviewScreen = BasePage.JobDetailPO.theNumberOfPhoneReviewPipeline.Text;
            jobTitleInOverviewScreen = BasePage.JobDetailPO.theJobTitle.Text;
            BasePage.JobDetailPO.thePhoneReviewPipeline.Click();
        }

        [Then(@"The candidate list is filter by phone interview and job")]
        public void ThenTheCandidateListIsFilterByPhoneInterviewAndJob()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(5) .pipeline-filter__stage-number")));
            string totalCandidateInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("li:nth-child(5) .pipeline-filter__stage-number")).Text;
            string jobTitleInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("span.filter-panel__label")).Text;


            Assert.Multiple(() =>
            {
                Assert.AreEqual(totalCandidateInCandidateScreen, totalCandidateInOverviewScreen, "Wrong number");
                Assert.AreEqual(jobTitleInCandidateScreen, jobTitleInOverviewScreen, "Wrong title");
                Assert.IsTrue(Utility.isElementPresent(By.CssSelector(".pipeline-filter__item:nth-child(5) .pipeline-filter__item-detail.active")));
            });
        }

        [When(@"I click on the on site interview pipeline")]
        public void WhenIClickOnTheOnSiteInterviewPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.theOnstieReviewPipeline));
            totalCandidateInOverviewScreen = BasePage.JobDetailPO.theNumberOfOnstieReviewPipeline.Text;
            jobTitleInOverviewScreen = BasePage.JobDetailPO.theJobTitle.Text;
            BasePage.JobDetailPO.theOnstieReviewPipeline.Click();
        }

        [Then(@"The candidate list is filter by on site interview and job")]
        public void ThenTheCandidateListIsFilterByOnSiteInterviewAndJob()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(6) .pipeline-filter__stage-number")));
            string totalCandidateInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("li:nth-child(6) .pipeline-filter__stage-number")).Text;
            string jobTitleInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("span.filter-panel__label")).Text;


            Assert.Multiple(() =>
            {
                Assert.AreEqual(totalCandidateInCandidateScreen, totalCandidateInOverviewScreen, "Wrong number");
                Assert.AreEqual(jobTitleInCandidateScreen, jobTitleInOverviewScreen, "Wrong title");
                Assert.IsTrue(Utility.isElementPresent(By.CssSelector(".pipeline-filter__item:nth-child(6) .pipeline-filter__item-detail.active")));
            });
        }

        [When(@"I click on the offer pipeline")]
        public void WhenIClickOnTheOfferPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.theOfferPipeline));
            totalCandidateInOverviewScreen = BasePage.JobDetailPO.theNumberOfOfferPipeline.Text;
            jobTitleInOverviewScreen = BasePage.JobDetailPO.theJobTitle.Text;
            BasePage.JobDetailPO.theOfferPipeline.Click();
        }

        [Then(@"The candidate list is filter by offer and job")]
        public void ThenTheCandidateListIsFilterByOfferAndJob()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(7) .pipeline-filter__stage-number")));
            string totalCandidateInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("li:nth-child(7) .pipeline-filter__stage-number")).Text;
            string jobTitleInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("span.filter-panel__label")).Text;


            Assert.Multiple(() =>
            {
                Assert.AreEqual(totalCandidateInCandidateScreen, totalCandidateInOverviewScreen, "Wrong number");
                Assert.AreEqual(jobTitleInCandidateScreen, jobTitleInOverviewScreen, "Wrong title");
                Assert.IsTrue(Utility.isElementPresent(By.CssSelector(".pipeline-filter__item:nth-child(7) .pipeline-filter__item-detail.active")));
            });
        }

        [When(@"I click on the hired pipeline")]
        public void WhenIClickOnTheHiredPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.theHiredPipeline));
            totalCandidateInOverviewScreen = BasePage.JobDetailPO.theNumberOfHiredPipeline.Text;
            jobTitleInOverviewScreen = BasePage.JobDetailPO.theJobTitle.Text;
            BasePage.JobDetailPO.theHiredPipeline.Click();
        }

        [Then(@"The candidate list is filter by hired and job")]
        public void ThenTheCandidateListIsFilterByHiredAndJob()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(8) .pipeline-filter__stage-number")));
            string totalCandidateInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("li:nth-child(8) .pipeline-filter__stage-number")).Text;
            string jobTitleInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("span.filter-panel__label")).Text;


            Assert.Multiple(() =>
            {
                Assert.AreEqual(totalCandidateInCandidateScreen, totalCandidateInOverviewScreen, "Wrong number");
                Assert.AreEqual(jobTitleInCandidateScreen, jobTitleInOverviewScreen, "Wrong title");
                Assert.IsTrue(Utility.isElementPresent(By.CssSelector(".pipeline-filter__item:nth-child(8) .pipeline-filter__item-detail.active")));
            });
        }

        [When(@"I click on the rejected pipeline")]
        public void WhenIClickOnTheRejectedPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.theRejectedPipeline));
            totalCandidateInOverviewScreen = BasePage.JobDetailPO.theNumberOfRejectedPipeline.Text;
            jobTitleInOverviewScreen = BasePage.JobDetailPO.theJobTitle.Text;
            BasePage.JobDetailPO.theRejectedPipeline.Click();
        }

        [Then(@"The candidate list is filter by rejected and job")]
        public void ThenTheCandidateListIsFilterByRejectedAndJob()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(2) .pipeline-filter__stage-number")));
            string totalCandidateInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("li:nth-child(2) .pipeline-filter__stage-number")).Text;
            string jobTitleInCandidateScreen = MyDriver.driver.FindElement(By.CssSelector("span.filter-panel__label")).Text;


            Assert.Multiple(() =>
            {
                Assert.AreEqual(totalCandidateInCandidateScreen, totalCandidateInOverviewScreen, "Wrong number");
                Assert.AreEqual(jobTitleInCandidateScreen, jobTitleInOverviewScreen, "Wrong title");
                Assert.IsTrue(Utility.isElementPresent(By.CssSelector(".pipeline-filter__item:nth-child(2) .pipeline-filter__item-detail.active")));
            });
        }


    }
}
