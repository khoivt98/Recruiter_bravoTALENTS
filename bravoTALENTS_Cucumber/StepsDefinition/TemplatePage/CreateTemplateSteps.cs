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

namespace bravoTALENTS_Cucumber.StepsDefinition.TemplatePage
{
    [Binding]
    public sealed class CreateTemplateSteps
    {
        string templateName = "test";

        [When(@"I click on create template button")]
        public void WhenIClickOnCreateTemplateButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.createTemplateButton));
            BasePage.TemplateListPO.createTemplateButton.Click();
        }

        [When(@"I enter template name")]
        public void WhenIEnterTemplateName()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.templateNameTextBox));
            BasePage.TemplateListPO.templateNameTextBox.SendKeys(templateName);
        }

        [When(@"I click create button")]
        public void WhenIClickCreateButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.createButtonInCreateTemplatePanel));
            BasePage.TemplateListPO.createButtonInCreateTemplatePanel.Click();
        }


        //Create job template
        [When(@"I select template type is job")]
        public void WhenISelectTemplateTypeIsJob()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.templateTypeDropdown));
            BasePage.TemplateListPO.templateTypeDropdown.Click();

            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.jobDetail));
            BasePage.TemplateListPO.jobDetail.Click();
        }

        [Then(@"The job template is created")]
        public void ThenTheJobTemplateIsCreated()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateDetailPO.templateTitle));
            string templateTitle = BasePage.TemplateDetailPO.templateTitle.Text;
            string templateType = BasePage.TemplateDetailPO.templateType.Text;
            string currentState = BasePage.TemplateDetailPO.currentState.Text;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(templateTitle, templateName);
                Assert.AreEqual(templateType, "Job Details");
                Assert.AreEqual(currentState, "DRAFT");
            });
        }

        //Create email template
        [When(@"I select template type is email")]
        public void WhenISelectTemplateTypeIsEmail()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.templateTypeDropdown));
            BasePage.TemplateListPO.templateTypeDropdown.Click();

            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.email));
            BasePage.TemplateListPO.email.Click();
        }

        [Then(@"The email template is created")]
        public void ThenTheEmailTemplateIsCreated()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateDetailPO.templateTitle));
            string templateTitle = BasePage.TemplateDetailPO.templateTitle.Text;
            string templateType = BasePage.TemplateDetailPO.templateType.Text;
            string currentState = BasePage.TemplateDetailPO.currentState.Text;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(templateTitle, templateName);
                Assert.AreEqual(templateType, "Email");
                Assert.AreEqual(currentState, "DRAFT");
            });
        }

        //Create interview prep template
        [When(@"I select template type is interview prep")]
        public void WhenISelectTemplateTypeIsInterviewPrep()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.templateTypeDropdown));
            BasePage.TemplateListPO.templateTypeDropdown.Click();

            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.interviewPrep));
            BasePage.TemplateListPO.interviewPrep.Click();
        }

        [Then(@"The interview prep template is created")]
        public void ThenTheInterviewPrepTemplateIsCreated()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateDetailPO.templateTitle));
            string templateTitle = BasePage.TemplateDetailPO.templateTitle.Text;
            string templateType = BasePage.TemplateDetailPO.templateType.Text;
            string currentState = BasePage.TemplateDetailPO.currentState.Text;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(templateTitle, templateName);
                Assert.AreEqual(templateType, "Interview Prep");
                Assert.AreEqual(currentState, "DRAFT");
            });
        }

    }
}
