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
    public sealed class CreateCandidateStepDefinition
    {
        [Given(@"I navigate to Candidate screen")]
        public void GivenINavigateToCandidateScreen()
        {
            BasePage.CandidatePO.dropdownMenu.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Candidates")));
            BasePage.CandidatePO.menuCandidate.Click();
        }

        [Given(@"I change candidate mode to All")]
        public void GivenIChangeCandidateModeToAll()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("sprite-arrow-right")));
            BasePage.CandidatePO.dropdownCandidateMode.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".pipeline-filter__drop-down-item:nth-child(2) .pipeline-filter__drop-down-label")));
            BasePage.CandidatePO.candidateModeAll.Click(); ;
        }


        [Given(@"I click on Add candidate button")]
        public void GivenIClickOnAddCandidateButton()
        {
            BasePage.CandidatePO.btnAddCandidate.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("firstName")));
        }

        [Given(@"I create candidate with (.*) and (.*)")]
        public void GivenICreateCandidateWithEeAndCandidateAndEecandidateMailinator_Com(string firstName, string lastName)
        {
            BasePage.CandidatePO.fieldFirstName.SendKeys(firstName);
            BasePage.CandidatePO.fieldLastName.SendKeys(lastName);
            string randomText = MyDriver.RandomString(8);
            string finalText = randomText + "@mailinator.com";
            BasePage.CandidatePO.fieldEmail.SendKeys(finalText);
            BasePage.CandidatePO.fieldFirstName.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Save')]")));
            BasePage.CandidatePO.btnSaveCandidate.Click();
            Thread.Sleep(5000);
        }


        [Then(@"the created candidate will be displayed in the candidate list")]
        public void ThenTheCreatedCandidateWillBeDisplayedInTheCandidateList()
        {      
            Assert.AreEqual("e2e candidate", BasePage.CandidatePO.firstCandidateName.Text);
        }

        [Given(@"I add an application Accountant into the candidate")]
        public void GivenIAddAnApplicationAccountantIntoTheCandidate()
        {
            BasePage.CandidatePO.addApplicationIntoCandidate();
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateJob, "Accountant"));
        }

        [Then(@"the candidate is added the selected application")]
        public void ThenTheCandidateIsAddedTheSelectedApplication()
        {
            Assert.AreEqual("Accountant", BasePage.CandidatePO.firstCandidateJob.Text);
        }

    }
}
