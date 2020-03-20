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
    public sealed class ScheduleInterviewStepDefinition
    {
        [Given(@"I navigate to Interview tab")]
        public void GivenINavigateToInterviewTab()
        {
            BasePage.CandidateDetailPO.tabInterview.Click();
        }


        [Given(@"I schedule an interview to the candidate with the interviewer is ""(.*)""")]
        public void GivenIScheduleAnInterviewToTheCandidateWithTheInterviewerIs(string interivewer)
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".interview__button")));
            BasePage.CandidateDetailPO.btnScheduleInterview.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".form-group .prepare-info-form__select")));
            BasePage.CandidateDetailPO.dropdownInterview.Click();
            BasePage.CandidateDetailPO.fieldInterviewer.SendKeys(interivewer);
            BasePage.CandidateDetailPO.fieldInterviewer.SendKeys(Keys.Enter);
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Next")));
            BasePage.CandidateDetailPO.btnNextSchedule.Click();
            Thread.Sleep(2000);
            BasePage.CandidateDetailPO.btnSchedule.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".interview__list .interview__item")));
        }

        [Then(@"the interview should be scheduled successfully")]
        public void ThenTheInterviewShouldBeScheduledSuccessfully()
        {          
            Assert.IsTrue(MyDriver.IsElementVisible(MyDriver.driver, By.CssSelector(".interview__list .interview__item")));
        }

        [Given(@"I navigate to the detail of the interview")]
        public void GivenINavigateToTheDetailOfTheInterview()
        {
            BasePage.CandidateDetailPO.detailInterview.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Review")));
            BasePage.CandidateDetailPO.tabReview.Click();
        }

        [Given(@"I update status of the interview to Passed with the comment is ""(.*)""")]
        public void GivenIUpdateStatusOfTheInterviewToPassedWithTheCommentIs(string comment)
        {
            BasePage.CandidateDetailPO.updateStatusInterview(BasePage.CandidateDetailPO.btnPassInterview, comment);
        }


        [Then(@"the status of the interviewe should be Passed")]
        public void ThenTheStatusOfTheIntervieweShouldBePassed()
        {
            Assert.IsTrue(MyDriver.IsElementVisible(MyDriver.driver, By.CssSelector(".interview-result .interview-result__button-passed--active")));
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".activity .activity-container__activity-body")));
        }

        [Given(@"I update status of the interview to Failed with the comment is ""(.*)""")]
        public void GivenIUpdateStatusOfTheInterviewToFailedWithTheCommentIs(string comment)
        {
            BasePage.CandidateDetailPO.updateStatusInterview(BasePage.CandidateDetailPO.btnFailInterview, comment);
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".activity .activity-container__activity-body")));
        }

        [Then(@"the status of the interviewe should be Failed")]
        public void ThenTheStatusOfTheIntervieweShouldBeFailed()
        {
            Assert.IsTrue(MyDriver.IsElementVisible(MyDriver.driver, By.CssSelector(".interview-result .interview-result__button-failed--active")));
        }

        [Given(@"I update the result of the interview from Failed to Passed with the ccomment is ""(.*)""")]
        public void GivenIUpdateTheResultOfTheInterviewFromFailedToPassedWithTheCcommentIs(string comment)
        {
            BasePage.CandidateDetailPO.updateResultInterview(BasePage.CandidateDetailPO.btnPassInterview, comment);
        }

        [Given(@"I update the result of the interview from Passed to Failed with the ccomment is ""(.*)""")]
        public void GivenIUpdateTheResultOfTheInterviewFromPassedToFailedWithTheCcommentIs(string comment)
        {
            BasePage.CandidateDetailPO.updateResultInterview(BasePage.CandidateDetailPO.btnFailInterview, comment);
        }

        [Then(@"the status of the interviewe should be Passed with the comment is ""(.*)""")]
        public void ThenTheStatusOfTheIntervieweShouldBePassedWithTheCommentIs(string comment)
        {
            Assert.Multiple(() =>
            {
                Assert.IsTrue(MyDriver.IsElementVisible(MyDriver.driver, By.CssSelector(".interview-result .interview-result__button-passed--active")));
                Assert.AreEqual(comment, BasePage.CandidateDetailPO.txtComment.Text);
            });
           
        }

        [Then(@"the status of the interviewe should be Failed with the comment is ""(.*)""")]
        public void ThenTheStatusOfTheIntervieweShouldBeFailedWithTheCommentIs(string comment)
        {
            Assert.Multiple(() =>
            {
                Assert.IsTrue(MyDriver.IsElementVisible(MyDriver.driver, By.CssSelector(".interview-result .interview-result__button-failed--active")));
                Assert.AreEqual(comment, BasePage.CandidateDetailPO.txtComment.Text);
            });           
        }



    }
}
