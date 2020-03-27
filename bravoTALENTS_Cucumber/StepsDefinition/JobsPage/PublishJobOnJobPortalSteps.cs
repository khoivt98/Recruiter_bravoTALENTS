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
    public sealed class PublishJobOnJobPortalSteps
    {
        string jobTitle = "Video editor";
        public static String numberOfJobInList;
        public static String currentState;
        public static List<string> lstWindow;
        public static String ATSApp;
        

        [When(@"I create new job")]
        public void WhenICreateNewJob()
        {
            ATSApp = MyDriver.driver.CurrentWindowHandle;
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobPO.createJobButton));
            BasePage.JobPO.createJobButton.Click();

            BasePage.JobPO.jobTitleTextBox.SendKeys(jobTitle);
            Thread.Sleep(500);

            BasePage.JobPO.createFromScratchButton.Click();

            BasePage.JobPO.openJobCategoryDropdown.Click();
            Thread.Sleep(250);
            BasePage.JobPO.selectDropdownItem[1].Click();

            BasePage.JobPO.openJobTypeDropdown.Click();
            Thread.Sleep(250);
            BasePage.JobPO.selectDropdownItem[1].Click();

            BasePage.JobPO.openPositionLevelDropdown.Click();
            Thread.Sleep(250);
            BasePage.JobPO.selectDropdownItem[1].Click();

            BasePage.JobPO.locationDropdown.Click();
            Thread.Sleep(250);
            BasePage.JobPO.locationItem[0].Click();

            BasePage.JobPO.createButton.Click();
        }

        [When(@"I click on ready for review button")]
        public void WhenIClickOnReadyForReviewButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.stateChangeButton));
            BasePage.JobDetailPO.stateChangeButton.Click();
        }

        [When(@"I click on advertise button")]
        public void WhenIClickOnAdvertiseButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.stateChangeButton));
            BasePage.JobDetailPO.stateChangeButton.Click();
        }

        [When(@"I click on publish button")]
        public void WhenIClickOnPublishButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.stateChangeButton));
            BasePage.JobDetailPO.stateChangeButton.Click();
            Thread.Sleep(500);
        }

        [Then(@"The job is published on job portal")]
        public void ThenTheJobIsPublishedOnJobPortal()
        {
            currentState = BasePage.JobDetailPO.currentStateOfJob.Text;
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.viewjobPostLink));
            BasePage.JobDetailPO.viewjobPostLink.Click();
            Thread.Sleep(500);
            lstWindow = MyDriver.driver.WindowHandles.ToList();
            MyDriver.driver.SwitchTo().Window(lstWindow[1]);

            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.theFirstJobInJobPortal));
            numberOfJobInList = BasePage.JobDetailPO.jobListTotal.Text;
            
            Assert.Multiple(() =>
            {
                Assert.AreEqual(jobTitle, BasePage.JobDetailPO.theFirstJobInJobPortal.Text);
                Assert.AreEqual("PUBLISHED", currentState);
            });
        }
    }
}
