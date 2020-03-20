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
    public sealed class RejectCandidateStepDefinition
    {
        [Given(@"I reject the candidate")]
        public void GivenIRejectTheCandidate()
        {
            BasePage.CandidateCardPO.iconReject.Click();
        }

        [Then(@"the message ""(.*)"" should be displayed")]
        public void ThenTheMessageShouldBeDisplayed(string msg)
        {
            Assert.AreEqual(msg, BasePage.CandidateCardPO.msgReject.Text);     
        }


        [Given(@"I undo reject the candidate")]
        public void GivenIUndoRejectTheCandidate()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Undo Reject")));
            BasePage.CandidateCardPO.btnUndoReject.Click();
        }

        [Then(@"the candidate should be undo rejected successfully")]
        public void ThenTheCandidateShouldBeUndoRejectedSuccessfully()
        {
            Assert.IsTrue(MyDriver.IsElementNotVisible(MyDriver.driver, By.XPath("//span[contains(.,'This candidate has been rejected.')]")));
        }

    }
}
