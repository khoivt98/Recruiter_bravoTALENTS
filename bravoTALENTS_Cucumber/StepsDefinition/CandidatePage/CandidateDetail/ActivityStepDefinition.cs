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
    public sealed class ActivityStepDefinition
    {
        [Given(@"I navigate to Activity tab")]
        public void GivenINavigateToActivityTab()
        {
            BasePage.CandidateDetailPO.tabActivity.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".activity-content__comment-box .comment-box__textarea")));
        }

        [Given(@"I add Comment to the candidate with ""(.*)""")]
        public void GivenIAddCommentToTheCandidateWith(string comment)
        {
            BasePage.CandidateDetailPO.fieldComment.SendKeys(comment);
            BasePage.CandidateDetailPO.fieldComment.SendKeys(Keys.Enter);
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".activity-container__activity-body p")));
        }

        [Then(@"the Comment should be added with ""(.*)""")]
        public void ThenTheCommentShouldBeAddedWith(string comment)
        {
            Assert.AreEqual(comment, BasePage.CandidateDetailPO.contentComment.Text);
        }

        [Given(@"I edit the added comment with ""(.*)""")]
        public void GivenIEditTheAddedCommentWith(string comment)
        {
            BasePage.CandidateDetailPO.contentComment.Click();
            BasePage.CandidateDetailPO.fieldEditComment.SendKeys(comment);
            BasePage.CandidateDetailPO.fieldEditComment.SendKeys(Keys.Enter);
        }

        [Given(@"I reply a comment of the candidate with ""(.*)""")]
        public void GivenIReplyACommentOfTheCandidateWith(string replycomment)
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".activity-container__activity-footer .activity-footer__reply-block-click")));
            BasePage.CandidateDetailPO.btnReply.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".comment-box--reply-section .comment-box__textarea")));
            BasePage.CandidateDetailPO.fieldReplyComment.SendKeys(replycomment);
            BasePage.CandidateDetailPO.fieldReplyComment.SendKeys(Keys.Enter);
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".activity__reply p")));
        }

        [Then(@"the Reply Comment should be added with ""(.*)""")]
        public void ThenTheReplyCommentShouldBeAddedWith(string replycomment)
        {
            Assert.AreEqual(replycomment, BasePage.CandidateDetailPO.contentCommentReply.Text);
        }

        [Given(@"I agree the comment of the candidate")]
        public void GivenIAgreeTheCommentOfTheCandidate()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".activity-container__activity-footer .activity-footer__agree-click")));
            BasePage.CandidateDetailPO.btnAgreeComment.Click();
        }


        [Then(@"the Comment text should be ""(.*)""")]
        public void ThenTheCommentTextShouldBe(string txt)
        {
            Assert.AreEqual(txt, BasePage.CandidateDetailPO.btnAgreeComment.Text);
        }

        [Given(@"I undo agree the comment of the candidate")]
        public void GivenIUndoAgreeTheCommentOfTheCandidate()
        {
            Thread.Sleep(500);
            BasePage.CandidateDetailPO.btnAgreeComment.Click();
        }
    }
}
