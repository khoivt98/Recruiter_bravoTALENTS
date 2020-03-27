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
    public sealed class RepublishobAfterEditJobDescriptionSteps
    {
        [When(@"I click on view job post link")]
        public void WhenIClickOnViewJobPostLink()
        {
            PublishJobOnJobPortalSteps.currentState = BasePage.JobDetailPO.currentStateOfJob.Text;
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.viewjobPostLink));
            BasePage.JobDetailPO.viewjobPostLink.Click();
            Thread.Sleep(500);
            PublishJobOnJobPortalSteps.lstWindow = MyDriver.driver.WindowHandles.ToList();
            MyDriver.driver.SwitchTo().Window(PublishJobOnJobPortalSteps.lstWindow[0]);
        }


        [When(@"I click on republish your job button")]
        public void WhenIClickOnRepublishYourJobButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.republishJobLink));
            BasePage.JobDetailPO.republishJobLink.Click();
            Thread.Sleep(500);
        }

        [Then(@"The job description is republished")]
        public void ThenTheJobDescriptionIsRepublished()
        {
            MyDriver.driver.SwitchTo().Window(PublishJobOnJobPortalSteps.lstWindow[1]);
            MyDriver.driver.Navigate().Refresh();

            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.theFirstJobInJobPortal));
            BasePage.JobDetailPO.theFirstJobInJobPortal.Click();

            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.job-detail__job-description")));

            string jobDescriptionInJobPortal = BasePage.JobDetailPO.jobDescriptionInJobPortal.Text;

            Assert.AreEqual(RevertJobDiscriptionSteps.jobDiscriptionAfterEdit, jobDescriptionInJobPortal);
        }

    }
}
