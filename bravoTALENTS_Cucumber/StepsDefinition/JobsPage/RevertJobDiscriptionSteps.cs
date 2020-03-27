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
    public sealed class RevertJobDiscriptionSteps
    {
        public static string jobDiscriptionBeforeEdit;
        public static string jobDiscriptionAfterEdit;
        public static string jobDiscriptionAfterRevert;

        [When(@"I click on job Ad button on navigation bar")]
        public void WhenIClickOnJobAdButtonOnNavigationBar()
        {
            BasePage.JobDetailPO.jobAdTab.Click();
        }


        [When(@"I edit job description")]
        public void WhenIEditJobDescription()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.jobDescription));
            BasePage.JobDetailPO.jobDescription.Click();
            Thread.Sleep(250);

            jobDiscriptionBeforeEdit = BasePage.JobDetailPO.jobDescription.Text;

            BasePage.JobDetailPO.jobDescription.SendKeys("saasasa");

            jobDiscriptionAfterEdit = BasePage.JobDetailPO.jobDescription.Text;

            MyDriver.actions.SendKeys(Keys.Tab).Perform();
        }

        [When(@"I click on revert change button")]
        public void WhenIClickOnRevertChangeButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.revertYourChangeLink));
            BasePage.JobDetailPO.revertYourChangeLink.Click();

            BasePage.JobDetailPO.revertButtonInRevertConfirmationModal.Click();

            jobDiscriptionAfterRevert = BasePage.JobDetailPO.jobDescription.Text;
        }

        [Then(@"The job description is Reverted")]
        public void ThenTheJobDescriptionIsReverted()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(jobDiscriptionBeforeEdit, jobDiscriptionAfterRevert);
                Assert.AreNotEqual(jobDiscriptionBeforeEdit, jobDiscriptionAfterEdit);
            });
        }
    }
}
