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
    public sealed class AddTagIntoCandidateStepDefinition
    {
        [Given(@"I add a tag ""(.*)"" into the candidate")]
        public void GivenIAddATagIntoTheCandidate(string tag)
        {
            BasePage.CandidateCardPO.linkAddTag.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("dropdownMenuInput")));
            BasePage.CandidateCardPO.inputTagField.SendKeys(tag);
            BasePage.CandidateCardPO.inputTagField.SendKeys(Keys.Enter);
        }

        [Then(@"the tag ""(.*)"" should be displayed")]
        public void ThenTheTagShouldBeDisplayed(string tag)
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".application-tag__text:nth-child(1)")));
            Assert.AreEqual(tag, BasePage.CandidateCardPO.firstTagOfCandidate.Text);
            
        }

    }
}
