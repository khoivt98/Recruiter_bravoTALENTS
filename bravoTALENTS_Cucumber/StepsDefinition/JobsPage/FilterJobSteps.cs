using bravoTALENTS_Cucumber.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
    public sealed class FilterJobSteps
    {
        [When(@"I click on Followed button")]
        public void WhenIClickOnFollowedButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobListPO.followedButton));
            BasePage.JobListPO.followedButton.Click();
        }

        [Then(@"All follow job is displayed in the list")]
        public void ThenAllFollowJobIsDisplayedInTheList()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementExists(By.CssSelector("tr.job-content")));
            int totalJobsInList = Utility.getTotalItemInList(BasePage.JobListPO.jobList, MyDriver.driver);
            int totalFollowedJobs = BasePage.JobListPO.starIconList.Count();
            
            Assert.Multiple(() =>
            {
                Assert.AreEqual(int.Parse(BasePage.JobListPO.allStatusPipelineNumber.Text), totalJobsInList);
                Assert.AreEqual(totalJobsInList, totalFollowedJobs);
            });
        }

        [When(@"I click on draft pipeline")]
        public void WhenIClickOnDraftPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobListPO.draftPipeline));
            BasePage.JobListPO.draftPipeline.Click();
        }

        [Then(@"All draft job is displayed in the list")]
        public void ThenAllDraftJobIsDisplayedInTheList()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementExists(By.CssSelector("tr.job-content")));
            int totalJobsInList = Utility.getTotalItemInList(BasePage.JobListPO.jobList, MyDriver.driver);
            int countJobsHaveDraftStatus = Utility.getTotalItemWithStatusInList(BasePage.JobListPO.statusName, MyDriver.driver, "Draft");
            int countJobHaveDraftIcon = Utility.getTotalItemWithColorIconInList(BasePage.JobListPO.statusIcon, MyDriver.driver, "background: rgb(140, 162, 176);");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(int.Parse(BasePage.JobListPO.draftPipelineNumber.Text), totalJobsInList);
                Assert.AreEqual(totalJobsInList, countJobsHaveDraftStatus, "Wrong status");
                Assert.AreEqual(totalJobsInList, countJobHaveDraftIcon, "Wrong status icon");
            });
        }

        [When(@"I click on pending pipeline")]
        public void WhenIClickOnPendingPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobListPO.pendingPipeline));
            BasePage.JobListPO.pendingPipeline.Click();
        }

        [Then(@"All pending job is displayed in the list")]
        public void ThenAllPendingJobIsDisplayedInTheList()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementExists(By.CssSelector("tr.job-content")));
            int totalJobsInList = Utility.getTotalItemInList(BasePage.JobListPO.jobList, MyDriver.driver);
            int countJobsHavePendingStatus = Utility.getTotalItemWithStatusInList(BasePage.JobListPO.statusName, MyDriver.driver, "Pending");
            int countJobHavePendingIcon = Utility.getTotalItemWithColorIconInList(BasePage.JobListPO.statusIcon, MyDriver.driver, "background: rgb(6, 169, 206);");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(int.Parse(BasePage.JobListPO.pendingPipelineNumber.Text), totalJobsInList);
                Assert.AreEqual(totalJobsInList, countJobsHavePendingStatus, "Wrong status");
                Assert.AreEqual(totalJobsInList, countJobHavePendingIcon, "Wrong status icon");
            });
        }

        [When(@"I click on published pipeline")]
        public void WhenIClickOnPublishedPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobListPO.publishedPipeline));
            BasePage.JobListPO.publishedPipeline.Click();
        }

        [Then(@"All published job is displayed in the list")]
        public void ThenAllPublishedJobIsDisplayedInTheList()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementExists(By.CssSelector("tr.job-content")));
            int totalJobsInList = Utility.getTotalItemInList(BasePage.JobListPO.jobList, MyDriver.driver);
            int countJobsHavePublishedStatus = Utility.getTotalItemWithStatusInList(BasePage.JobListPO.statusName, MyDriver.driver, "Published");
            int countJobHavePublishedIcon = Utility.getTotalItemWithColorIconInList(BasePage.JobListPO.statusIcon, MyDriver.driver, "background: rgb(90, 191, 109);");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(int.Parse(BasePage.JobListPO.publishedPipelineNumber.Text), totalJobsInList);
                Assert.AreEqual(totalJobsInList, countJobsHavePublishedStatus, "Wrong status");
                Assert.AreEqual(totalJobsInList, countJobHavePublishedIcon, "Wrong status icon");
            });
        }

        [When(@"I click on closed pipeline")]
        public void WhenIClickOnClosedPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobListPO.closedPipeline));
            BasePage.JobListPO.closedPipeline.Click();
        }

        [Then(@"All closed job is displayed in the list")]
        public void ThenAllClosedJobIsDisplayedInTheList()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementExists(By.CssSelector("tr.job-content")));
            int totalJobsInList = Utility.getTotalItemInList(BasePage.JobListPO.jobList, MyDriver.driver);
            int countJobsHaveClosedStatus = Utility.getTotalItemWithStatusInList(BasePage.JobListPO.statusName, MyDriver.driver, "Closed");
            int countJobHaveClosedIcon = Utility.getTotalItemWithColorIconInList(BasePage.JobListPO.statusIcon, MyDriver.driver, "background: rgb(241, 175, 28);");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(int.Parse(BasePage.JobListPO.closedPipelineNumber.Text), totalJobsInList);
                Assert.AreEqual(totalJobsInList, countJobsHaveClosedStatus, "Wrong status");
                Assert.AreEqual(totalJobsInList, countJobHaveClosedIcon, "Wrong status icon");
            });
        }

        [When(@"I click on finished pipeline")]
        public void WhenIClickOnFinishedPipeline()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobListPO.finishedPipeline));
            BasePage.JobListPO.finishedPipeline.Click();
        }

        [Then(@"All finished job is displayed in the list")]
        public void ThenAllFinishedJobIsDisplayedInTheList()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementExists(By.CssSelector("tr.job-content")));
            int totalJobsInList = Utility.getTotalItemInList(BasePage.JobListPO.jobList, MyDriver.driver);
            int countJobsHaveFinishedStatus = Utility.getTotalItemWithStatusInList(BasePage.JobListPO.statusName, MyDriver.driver, "Finished");
            int countJobHaveFinishedIcon = Utility.getTotalItemWithColorIconInList(BasePage.JobListPO.statusIcon, MyDriver.driver, "background: rgb(98, 114, 125);");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(int.Parse(BasePage.JobListPO.finishedPipelineNumber.Text), totalJobsInList);
                Assert.AreEqual(totalJobsInList, countJobsHaveFinishedStatus, "Wrong status");
                Assert.AreEqual(totalJobsInList, countJobHaveFinishedIcon, "Wrong status icon");
            });
        }


    }
}
