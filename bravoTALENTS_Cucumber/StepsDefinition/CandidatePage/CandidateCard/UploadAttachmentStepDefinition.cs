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

namespace bravoTALENTS_Cucumber.StepsDefinition.CandidatePage.CandidateCard
{
    [Binding]
    public sealed class UploadAttachmentStepDefinition
    {
        [Given(@"I upload a attachment into the candidate")]
        public void GivenIUploadAAttachmentIntoTheCandidate()
        {
            BasePage.CandidateCardPO.uploadFile.SendKeys("C:/Projects/Recruiter_bravoTALENTS/bravoTALENTS_Cucumber/Data/CV.docx");
        }

        [Then(@"the uploaded attachement should be displayed")]
        public void ThenTheUploadedAttachementShouldBeDisplayed()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".primary-list__link .primary-list__text--full")));
            Assert.AreEqual("CV.docx", BasePage.CandidateCardPO.uploadedFileText.Text);
        }

    }
}
