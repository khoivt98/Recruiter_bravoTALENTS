using bravoTALENTS_Cucumber.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace bravoTALENTS_Cucumber.StepsDefinition.JobsPage
{
    [Binding]
    public sealed class RepublishJobAfterCloseJobSteps
    {
        [When(@"I click on publish button on the status pipeline")]
        public void WhenIClickOnPublishButtonOnTheStatusPipeline()
        {
            BasePage.JobDetailPO.publishedStateOnStatusBar.Click();

            BasePage.JobDetailPO.republishedButtonInRepublishConfirmationModal.Click();

            PublishJobOnJobPortalSteps.currentState = BasePage.JobDetailPO.currentStateOfJob.Text;
        }
    }
}
