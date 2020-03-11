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
    public sealed class FollowAndUnfollowJobSteps
    {
        [When(@"I click into the check box of the first job")]
        public void WhenIClickIntoTheCheckBoxOfTheFirstJob()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementExists(By.CssSelector(".job-content:nth-child(1)")));
            BasePage.JobListPO.firstJobCheckbox.Click();
        }

        [When(@"I click on follow icon in the job action bar")]
        public void WhenIClickOnFollowIconInTheJobActionBar()
        {
            BasePage.JobListPO.followIcon.Click();
            Thread.Sleep(500);
        }

        [Then(@"The first job should be followed")]
        public void ThenTheFirstJobShouldBeFollowed()
        {
            bool result = MyDriver.IsElementVisible(MyDriver.driver, By.CssSelector("tr:nth-of-type(1) > td > .sprite-filled-star"));
            Assert.IsTrue(result);
        }

        [When(@"I click on unfollow icon in the job action bar")]
        public void WhenIClickOnUnfollowIconInTheJobActionBar()
        {
            BasePage.JobListPO.unfollowIcon.Click();
            Thread.Sleep(500);
        }

        [Then(@"The first job should be unfollowed")]
        public void ThenTheFirstJobShouldBeUnfollowed()
        {
            bool result = MyDriver.IsElementNotVisible(MyDriver.driver, By.CssSelector("tr:nth-of-type(1) > td > .sprite-filled-star"));
            Assert.IsTrue(result);
        }


    }
}
