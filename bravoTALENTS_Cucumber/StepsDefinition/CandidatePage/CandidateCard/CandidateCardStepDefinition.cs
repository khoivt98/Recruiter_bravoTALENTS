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
    public sealed class CandidateCardStepDefinition
    {
        [Given(@"I click on the first candidate row")]
        public void GivenIClickOnTheFirstCandidateRow()
        {          
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidatePO.firstCandidateName, "e2e candidate"));
            BasePage.CandidatePO.firstCandidateRow.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".candidate-card")));
        }

        [Given(@"I click on the Edit Info button")]
        public void GivenIClickOnTheEditInfoButton()
        {
            Utility.moveToElement(BasePage.CandidateCardPO.linkViewCV);
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(.,'Edit Info')]")));
            BasePage.CandidateCardPO.btnEditInfo.Click();
        }

        [Given(@"I edit information of candidate with (.*) and (.*) and (.*) and (.*)")]
        public void GivenIEditInformationOfCandidateWithAndMaleAndSingleAndHCM(string mobile, string gender, string martialStatus, string city)
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".candidate-card-edit__item:nth-child(5) input")));
            BasePage.CandidateCardPO.EditInformationCandidate(mobile, gender, martialStatus, city);
        }


        [Given(@"I click on Save Edit Info button")]
        public void GivenIClickOnSaveEditInfoButton()
        {
            BasePage.CandidateCardPO.btnSaveEditInfo.Click();
        }

        [Then(@"the info of candidate should be updated (.*) and (.*) and (.*) and (.*)")]
        public void ThenTheInfoOfCandidateShouldBeUpdatedAndMaleAndSingleAndHCM(string mobile, string gender, string martialStatus, string city)
        {
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".primary-list__item:nth-child(5) span")));
            Assert.Multiple(() =>
            {
                Assert.AreEqual(mobile, BasePage.CandidateCardPO.textMobile.Text);
                Assert.AreEqual(gender, BasePage.CandidateCardPO.textGender.Text);
                Assert.AreEqual(martialStatus, BasePage.CandidateCardPO.textMartialStatus.Text);
                Assert.AreEqual(city, BasePage.CandidateCardPO.textCity.Text);
            });
        }


    }
}
