using bravoTALENTS_Cucumber.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework;

namespace bravoTALENTS_Cucumber.StepsDefinition.CandidatePage
{
    [Binding]
    public sealed class SearchCandidateStepDefinition
    {
        [Given(@"I input (.*) into the search box")]
        public void GivenIInputTheIntoTheSearchBox(string candidateName)
        {
            BasePage.CandidatePO.fieldSearchCandidate.SendKeys(candidateName);
        }


        [Given(@"I click on the search icon")]
        public void GivenIClickOnTheSearchIcon()
        {
            BasePage.CandidatePO.iconSearchCandidate.Click();
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateName, "tony van"));
            //MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(By.CssSelector(".candidate-content:nth-child(1) td:nth-child(4)")));
        }

        [Then(@"the candidate list will display the search result")]
        public void ThenTheCandidateListWillDisplayTheSearchResult()
        {
            Assert.AreEqual("tony van", BasePage.CandidatePO.firstCandidateName.Text);
        }


    }
}
