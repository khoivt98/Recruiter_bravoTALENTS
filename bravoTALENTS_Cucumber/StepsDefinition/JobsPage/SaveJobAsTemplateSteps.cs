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
    public sealed class SaveJobAsTemplateSteps
    {
        string jobTitleInJobScreen;

        [When(@"I click on job ad button")]
        public void WhenIClickOnJobAdButton()
        {
            BasePage.JobDetailPO.jobAdTab.Click();
        }

        [When(@"i click on save as template button")]
        public void WhenIClickOnSaveAsTemplateButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.saveAsTemplateButton));
            BasePage.JobDetailPO.saveAsTemplateButton.Click();
            Thread.Sleep(1000);
        }

        [When(@"I click on the link in the message")]
        public void WhenIClickOnTheLinkInTheMessage()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.linkNavigateToTemplateScreen));
            jobTitleInJobScreen = BasePage.JobDetailPO.theJobTitle.Text;
            BasePage.JobDetailPO.linkNavigateToTemplateScreen.Click();
        }

        [Then(@"I navigate to template detail screen")]
        public void ThenINavigateToTemplateDetailScreen()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateDetailPO.templateTitle));
            Assert.AreEqual(jobTitleInJobScreen, BasePage.TemplateDetailPO.templateTitle.Text);
        }

    }
}
