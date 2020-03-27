using bravoTALENTS_Cucumber.PageObject;
using NUnit.Framework;
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
    public sealed class CloseJobSteps
    {
        [Then(@"I go back to ATS")]
        public void ThenIGoBackToATS()
        {
            MyDriver.driver.SwitchTo().Window(PublishJobOnJobPortalSteps.ATSApp);
        }

        [When(@"I click on closed button")]
        public void WhenIClickOnClosedButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.stateChangeButton));
            BasePage.JobDetailPO.stateChangeButton.Click();

            BasePage.JobDetailPO.closedButtonInClosedJobConfirmationModal.Click();
            PublishJobOnJobPortalSteps.currentState = BasePage.JobDetailPO.currentStateOfJob.Text;
            Thread.Sleep(500);
        }

        [Then(@"The job is closed on job portal")]
        public void ThenTheJobIsClosedOnJobPortal()
        {
            MyDriver.driver.SwitchTo().Window(PublishJobOnJobPortalSteps.lstWindow[1]);
            MyDriver.driver.Navigate().Refresh();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.theFirstJobInJobPortal));
            int count = int.Parse(BasePage.JobDetailPO.jobListTotal.Text);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(count, int.Parse(PublishJobOnJobPortalSteps.numberOfJobInList) - 1);
                Assert.AreEqual("CLOSED", PublishJobOnJobPortalSteps.currentState);
            });
        }
    }
}
