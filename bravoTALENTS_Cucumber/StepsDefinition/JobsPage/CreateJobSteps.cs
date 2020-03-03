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
        private IWebDriver driver;
        private WebDriverWait wait;
        public CreateJobSteps()
        {
            driver = MyDriver.driver;
            wait = new WebDriverWait(MyDriver.driver, TimeSpan.FromSeconds(60));
        }

        [When(@"I click Create job button")]
        public void WhenIClickCreateJobButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobPO.btnCreateJob));
            BasePage.JobPO.btnCreateJob.Click();
        }

        [When(@"I enter text into job title field")]
        public void WhenIEnterTextIntoJobTitleField()
        {
            BasePage.JobPO.txtJobTitle.SendKeys("CTO (Chief Technology Officer)");
            Thread.Sleep(500);
        }

        [When(@"I click on the Create from scratch button")]
        public void WhenIClickOnTheCreateFromScratchButton()
        {
            BasePage.JobPO.btnCreateFromScratch.Click();
        }

        [When(@"I select job category")]
        public void WhenISelectJobCategory()
        {
            BasePage.JobPO.sltJobCategory[0].Click();
            BasePage.JobPO.sltOption[1].Click();
        }

        [When(@"I select job type")]
        public void WhenISelectJobType()
        {
            BasePage.JobPO.sltJobCategory[1].Click();
            BasePage.JobPO.sltOption[1].Click();
        }

        [When(@"I select position level")]
        public void WhenISelectPositionLevel()
        {
            BasePage.JobPO.sltJobCategory[2].Click();
            BasePage.JobPO.sltOption[1].Click();
        }

        [When(@"I select location")]
        public void WhenISelectLocation()
        {
            BasePage.JobPO.openSltLocation.Click();
            BasePage.JobPO.sltLocation[0].Click();
            
        }

        [When(@"I click on create button")]
        public void WhenIClickOnCreateButton()
        {
            BasePage.JobPO.btnCreate.Click();
        }


        [Then(@"I create new job successful")]
        public void ThenICreateNewJobSuccessful()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".--editable.job-header__job-title-display.ng-star-inserted > div > div")));
            Assert.AreEqual("CTO (Chief Technology Officer)", BasePage.JobPO.txtJobName.Text);
        }

        [When(@"I click on the job in the template list")]
        public void WhenIClickOnTheJobInTheTemplateList()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobPO.listItemFromTemplates[0]));
            BasePage.JobPO.listItemFromTemplates[0].Click();
        }

        [When(@"I click on create and edit button")]
        public void WhenIClickOnCreateAndEditButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobPO.btnCreateAndEdit));
            BasePage.JobPO.btnCreateAndEdit.Click();
        }

        [When(@"I click the X icon")]
        public void WhenIClickTheXIcon()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobPO.btnClose));
            BasePage.JobPO.btnClose.Click();
        }

        [Then(@"The create job panel should closed")]
        public void ThenTheCreateJobPanelShouldClosed()
        {
            ScenarioContext.Current.Pending();
        }



    }
}
