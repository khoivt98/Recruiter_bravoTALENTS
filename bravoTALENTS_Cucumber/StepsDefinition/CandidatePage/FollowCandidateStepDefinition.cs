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

namespace bravoTALENTS_Cucumber.StepsDefinition.CandidatePage
{
    [Binding]
    public sealed class FollowCandidateStepDefinition
    {

        [Given(@"I click on the checkbox of the first candidate")]
        public void GivenIClickOnTheCheckboxOfTheFirstCandidate()
        {
            BasePage.CandidatePO.firstCandidateCheckbox.Click();
        }

        [Given(@"I click on follow icon")]
        public void GivenIClickOnFollowIcon()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".sprite-faded-star")));
            BasePage.CandidatePO.iconFollowCandidate.Click();
            Thread.Sleep(500);
        }

        [Then(@"the candidate should be followed")]
        public void ThenTheCandidateShouldBeFollowed()
        {
            bool result = MyDriver.IsElementVisible(MyDriver.driver, By.CssSelector(".candidate-content:nth-child(1) .sprite-filled-star"));
            Assert.IsTrue(result);         
        }

        [Given(@"I click on unfollow icon")]
        public void GivenIClickOnUnfollowIcon()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".sprite-x-star")));
            BasePage.CandidatePO.iconUnFollowCandidate.Click();
        }

        [Then(@"the candidate should be unfollowed")]
        public void ThenTheCandidateShouldBeUnfollowed()
        {
            Assert.IsTrue(MyDriver.IsElementNotVisible(MyDriver.driver, By.CssSelector(".candidate-content:nth-child(1) .sprite-filled-star")));
        }

    }
}
