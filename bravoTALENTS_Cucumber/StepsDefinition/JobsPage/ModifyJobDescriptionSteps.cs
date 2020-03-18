using System;
using bravoTALENTS_Cucumber.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace bravoTALENTS_Cucumber.StepsDefinition.JobsPage
{
    [Binding]
    public sealed class ModifyJobDescriptionSteps
    {
        Actions actions = new Actions(MyDriver.driver);
        string colorErrorMessage = "rgba(255, 239, 239, 1)";
        string colorWarningMessage = "rgba(255, 251, 223, 1)";
        string duplicatedTitlesMessage = " You have duplicated titles. Please remove the duplicated ones. ";
        string messagejobContentSmallerThan150 = " Your Job Ad is too short. Please provide more information. An ideal Job Ad should be more than 150 words. ";
        string missingDescriptionFollowTitleMessage = " Please provide information for the missing description. ";
        string missingBothTitleAndDescriptionMessage = " Please enter at least one title and a description following that title. ";
        string missingDescriptionMessage = " Please enter description for your title. ";
        string missingTitleMessage = " Please enter at least one title. ";

        [When(@"I click on job description")]
        public void WhenIClickOnJobDescription()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.jobDescription));
            BasePage.JobDetailPO.jobDescription.Click();
            Thread.Sleep(500);
        }


        [When(@"I remove job description")]
        public void WhenIRemoveJobDescription()
        {
            BasePage.JobDetailPO.jobDescription.Clear();
            BasePage.JobDetailPO.jobDescription.Click();          
            actions.SendKeys(Keys.Tab).Perform();
        }

        [When(@"I input duplicated titles")]
        public void WhenIInputDuplicatedTitles()
        {
            BasePage.JobDetailPO.jobDescription.Clear();
            var executor = MyDriver.driver as IJavaScriptExecutor;
            executor.ExecuteScript("arguments[0].innerHTML = '<h2>Job Description</h2>" +
                "<p>Enter your job description here.</p>" +
                "<h2>Job Description</h2>" +
                "<p>Enter responsibilities here.</p>'", BasePage.JobDetailPO.jobDescription);
            BasePage.JobDetailPO.jobDescription.Click();
            actions.SendKeys(Keys.Tab).Perform();
            Thread.Sleep(500);
        }

        [Then(@"The missing title and description message is displayed")]
        public void ThenTheMissingTitleAndDescriptionMessageIsDisplayed()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".alert.alert-error")));
            string message = BasePage.JobDetailPO.errorMessage.Text;
            string backgroundColor = BasePage.JobDetailPO.errorMessage.GetCssValue("background-color");


            Assert.Multiple(() =>
            {
                Assert.AreEqual(message, missingBothTitleAndDescriptionMessage);
                Assert.AreEqual(backgroundColor, colorErrorMessage);
            });
        }

        [Then(@"The duplicated titles message is displayed")]
        public void ThenTheDuplicatedTitlesMessageIsDisplayed()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".alert.alert-warning:nth-child(1)")));
            string message = BasePage.JobDetailPO.listWarningMessage[0].Text;
            string backgroundColor = BasePage.JobDetailPO.warningMessage.GetCssValue("background-color");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(duplicatedTitlesMessage, message);
                Assert.AreEqual(colorWarningMessage, backgroundColor);
            });
        }

        [When(@"I input Job description smaller than (.*)")]
        public void WhenIInputJobDescriptionSmallerThan(int p0)
        {
            BasePage.JobDetailPO.jobDescription.Clear();
            var executor = MyDriver.driver as IJavaScriptExecutor;
            executor.ExecuteScript("arguments[0].innerHTML = '<h2>Job Description</h2>" +
                "<p>Enter your job description here.</p>" +
                "<h2>Responsibilities</h2>" +
                "<p>Enter responsibilities here.</p>'", BasePage.JobDetailPO.jobDescription);
            BasePage.JobDetailPO.jobDescription.Click();
            actions.SendKeys(Keys.Tab).Perform();
            Thread.Sleep(500);
        }

        [Then(@"The job content smaller than (.*) message is displayed")]
        public void ThenTheJobContentSmallerThanMessageIsDisplayed(int p0)
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".alert.alert-warning:nth-child(1)")));
            string message = BasePage.JobDetailPO.warningMessage.Text;
            string backgroundColor = BasePage.JobDetailPO.warningMessage.GetCssValue("background-color");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(messagejobContentSmallerThan150, message);
                Assert.AreEqual(colorWarningMessage, backgroundColor);
            });
        }

        [When(@"I input Job description missing title")]
        public void WhenIInputJobDescriptionMissingTitle()
        {
            BasePage.JobDetailPO.jobDescription.Clear();
            var executor = MyDriver.driver as IJavaScriptExecutor;
            executor.ExecuteScript("arguments[0].innerHTML = '<p>Enter responsibilities here.</p>'", BasePage.JobDetailPO.jobDescription);
            BasePage.JobDetailPO.jobDescription.Click();
            actions.SendKeys(Keys.Tab).Perform();
            Thread.Sleep(500);
        }

        [Then(@"The missing title message is displayed")]
        public void ThenTheMissingTitleMessageIsDisplayed()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".alert.alert-error")));
            string message = BasePage.JobDetailPO.errorMessage.Text;
            string backgroundColor = BasePage.JobDetailPO.errorMessage.GetCssValue("background-color");


            Assert.Multiple(() =>
            {
                Assert.AreEqual(missingTitleMessage, message);
                Assert.AreEqual(colorErrorMessage, backgroundColor);
            });
        }

        [When(@"I input Job description missing description")]
        public void WhenIInputJobDescriptionMissingDescription()
        {
            BasePage.JobDetailPO.jobDescription.Clear();
            var executor = MyDriver.driver as IJavaScriptExecutor;
            executor.ExecuteScript("arguments[0].innerHTML = '<h2>Enter responsibilities here.</h2>'", BasePage.JobDetailPO.jobDescription);
            BasePage.JobDetailPO.jobDescription.Click();
            actions.SendKeys(Keys.Tab).Perform();
            Thread.Sleep(500);
        }

        [Then(@"The missing description message is displayed")]
        public void ThenTheMissingDescriptionMessageIsDisplayed()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".alert.alert-error")));
            string message = BasePage.JobDetailPO.errorMessage.Text;
            string backgroundColor = BasePage.JobDetailPO.errorMessage.GetCssValue("background-color");


            Assert.Multiple(() =>
            {
                Assert.AreEqual(missingDescriptionMessage, message);
                Assert.AreEqual(colorErrorMessage, backgroundColor);
            });
        }

        [When(@"I input Job description missing description follow title")]
        public void WhenIInputJobDescriptionMissingDescriptionFollowTitle()
        {
            BasePage.JobDetailPO.jobDescription.Clear();
            var executor = MyDriver.driver as IJavaScriptExecutor;
            executor.ExecuteScript("arguments[0].innerHTML = '<h2>Job Description</h2>" +
                "<p>Enter your job description here.</p>" +
                "<h2>Responsibilities</h2>'", BasePage.JobDetailPO.jobDescription);
            BasePage.JobDetailPO.jobDescription.Click();
            actions.SendKeys(Keys.Tab).Perform();
            Thread.Sleep(500);
        }

        [Then(@"The missing description follow title  message is displayed")]
        public void ThenTheMissingDescriptionFollowTitleMessageIsDisplayed()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".alert.alert-warning:nth-child(1)")));
            string message = BasePage.JobDetailPO.warningMessage.Text;
            string backgroundColor = BasePage.JobDetailPO.warningMessage.GetCssValue("background-color");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(missingDescriptionFollowTitleMessage, message);
                Assert.AreEqual(colorWarningMessage, backgroundColor);
            });
        }



    }
}
