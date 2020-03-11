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

namespace bravoTALENTS_Cucumber.StepsDefinition
{
    [Binding]
    public sealed class CreateJobSteps
    {
        private string jobTitle = "Video editor";

        [When(@"I click Create job button")]
        public void WhenIClickCreateJobButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobPO.createJobButton));
            BasePage.JobPO.createJobButton.Click();
        }

        [When(@"I enter text into job title field")]
        public void WhenIEnterTextIntoJobTitleField()
        {
            BasePage.JobPO.jobTitleTextBox.SendKeys(jobTitle);
            Thread.Sleep(500);
        }

        [When(@"I click on the Create from scratch button")]
        public void WhenIClickOnTheCreateFromScratchButton()
        {
            BasePage.JobPO.createFromScratchButton.Click();
        }

        [When(@"I select job category")]
        public void WhenISelectJobCategory()
        {
            BasePage.JobPO.openJobCategoryDropdown.Click();
            BasePage.JobPO.selectDropdownItem[1].Click();
        }

        [When(@"I select job type")]
        public void WhenISelectJobType()
        {
            BasePage.JobPO.openJobTypeDropdown.Click();
            BasePage.JobPO.selectDropdownItem[1].Click();
        }

        [When(@"I select position level")]
        public void WhenISelectPositionLevel()
        {
            BasePage.JobPO.openPositionLevelDropdown.Click();
            BasePage.JobPO.selectDropdownItem[1].Click();
        }

        [When(@"I select location")]
        public void WhenISelectLocation()
        {
            BasePage.JobPO.locationDropdown.Click();
            BasePage.JobPO.locationItem[0].Click();
            
        }

        [When(@"I click on create button")]
        public void WhenIClickOnCreateButton()
        {
            BasePage.JobPO.createButton.Click();
        }


        [Then(@"I create new job successful")]
        public void ThenICreateNewJobSuccessful()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".--editable.job-header__job-title-display.ng-star-inserted > div > div")));
            Assert.AreEqual(jobTitle, BasePage.JobPO.jobNameTextBox.Text);
        }


        //Create job from template successful
        [When(@"I click on the job in the template list")]
        public void WhenIClickOnTheJobInTheTemplateList()
        {
            Boolean isNoPreviousJobsFound = Utility.isElementPresent(By.CssSelector("div.jobs-from-templates > span.no-jobs-text"));
            if (isNoPreviousJobsFound == true)
            {
                Assert.False(BasePage.JobPO.noPreviousJobsFoundText.Displayed, "No templates found");
            }
            else
            {
                MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobPO.listItemFromTemplates[0]));
                BasePage.JobPO.listItemFromTemplates[0].Click();
            }           
        }

        [When(@"I click on create and edit button")]
        public void WhenIClickOnCreateAndEditButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobPO.createAndEditButton));
            BasePage.JobPO.createAndEditButton.Click();
        }


        //Create job from previous jobs successful
        [When(@"I click on the job in the previous jobs list")]
        public void WhenIClickOnTheJobInThePreviousJobsList()
        {
            Boolean isNoPreviousJobsFound = Utility.isElementPresent(By.CssSelector("div.jobs-from-previous > span.no-jobs-text"));
            if (isNoPreviousJobsFound == true)
            {
                Assert.False(BasePage.JobPO.noPreviousJobsFoundText.Displayed, "No previous jobs found");
            }
            else
            {
                MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobPO.listItemFromPreviousJobs[0]));
                BasePage.JobPO.listItemFromPreviousJobs[0].Click();
            }          
        }


        //Close the create job panel successful by using X icon
        [When(@"I click the X icon")]
        public void WhenIClickTheXIcon()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobPO.closeButtonInCreateJobPanel));
            BasePage.JobPO.closeButtonInCreateJobPanel.Click();
        }

        [Then(@"The create job panel should closed")]
        public void ThenTheCreateJobPanelShouldClosed()
        {
            IWebElement createJobPanel = MyDriver.driver.FindElement(By.CssSelector("job-creation-form > div.job-creation-card.job-creation-card--hide"));
            Assert.IsFalse(createJobPanel.Displayed);
        }


        //Close the create job manually panel successful by using X icon
        [When(@"I click the X icon in the create job manually panel")]
        public void WhenIClickTheXIconInTheCreateJobManuallyPanel()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobPO.closeButton));
            BasePage.JobPO.closeButton.Click();
        }


        [Then(@"The create job manually panel should closed")]
        public void ThenTheCreateJobManuallyPanelShouldClosed()
        {
            IWebElement createJobManuallyPanel = MyDriver.driver.FindElement(By.CssSelector("job-creation-from-scratch > div.job-creation-card.job-creation-card--hide"));
            Assert.IsFalse(createJobManuallyPanel.Displayed);
        }


        //Close the create job and review job panel successful by using X icon
        [When(@"I click the X icon in the create job and review job panel")]
        public void WhenIClickTheXIconInTheCreateJobAndReviewJobPanel()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobPO.closeButtonInReivewPanel));
            BasePage.JobPO.closeButtonInReivewPanel.Click();
        }

        [Then(@"The create job and review job panel should closed")]
        public void ThenTheCreateJobAndReviewJobPanelShouldClosed()
        {
            IWebElement reivewJobPanel = MyDriver.driver.FindElement(By.CssSelector("job-creation-from-scratch > div.job-creation-card.job-creation-card--hide"));
            Assert.IsFalse(reivewJobPanel.Displayed);
        }

        //Close the create job manually panel successful by using cancel button
        [When(@"I click the cancel button in the create job manually panel")]
        public void WhenIClickTheCancelButtonInTheCreateJobManuallyPanel()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobPO.cancelButtonInCreateJobPanel));
            BasePage.JobPO.cancelButtonInCreateJobPanel.Click();
        }

        //Close the create job and review job panel successful by using cancel button
        [When(@"I click the cancel button in the create job and review job panel")]
        public void WhenIClickTheCancelButtonInTheCreateJobAndReviewJobPanel()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobPO.cancelButtonInReivewPanel));
            BasePage.JobPO.cancelButtonInReivewPanel.Click();
        }


        //The data in review panel is changed when I click on another job in template list
        [Then(@"The job title in list and preview panel is equal")]
        public void ThenTheJobTitleInListAndPreviewPanelIsEqual()
        {
            Boolean flag = Utility.checkName(BasePage.JobPO.listItemFromTemplates, BasePage.JobPO.jobTitleInReivewPanel);
            Assert.IsTrue(flag, "The job title in list and preview panel is not equal");
        }






    }
}
