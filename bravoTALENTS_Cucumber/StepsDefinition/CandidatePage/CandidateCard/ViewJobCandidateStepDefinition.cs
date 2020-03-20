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
    public sealed class ViewJobCandidateStepDefinition
    {
        [Given(@"I click on the View Job link")]
        public void GivenIClickOnTheViewJobLink()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".candidate-card__info .candidate-card__small-link")));
            BasePage.CandidateCardPO.linkViewJob.Click();
        }

        [Then(@"the job of the candidate should be displayed")]
        public void ThenTheJobOfTheCandidateShouldBeDisplayed()
        {
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidateCardPO.jobHeaderTitle, "Accountant"));
            Assert.AreEqual("Accountant", BasePage.CandidateCardPO.jobHeaderTitle.Text);
        }

    }
}
