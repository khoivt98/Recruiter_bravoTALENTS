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

namespace bravoTALENTS_Cucumber.StepsDefinition.CandidatePage.CandidateDetail
{
    [Binding]
    public sealed class CreateOfferStepDefinition
    {
        [Given(@"I navigate to Offer tab")]
        public void GivenINavigateToOfferTab()
        {
            BasePage.CandidateDetailPO.tabOffer.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".offer-salary__input")));
        }

        [Given(@"I create an offer to the candidate with Salary is ""(.*)"" and Report to ""(.*)""")]
        public void GivenICreateAnOfferToTheCandidateWithSalaryIsAndReportTo(string salary, string reportTo)
        {
            BasePage.CandidateDetailPO.createOffer(salary, reportTo);
        }

        [Given(@"I send email offer to the candidate")]
        public void GivenISendEmailOfferToTheCandidate()
        {
            Thread.Sleep(2000);
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".email-section .select2-selection")));
            BasePage.CandidateDetailPO.dropdownTemplateOfferEmail.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".select2-results__option")));
            MyDriver.getElementByName(BasePage.CandidateDetailPO.optionTemplateOfferEmail, "Offer Email With Benefits").Click();
            Thread.Sleep(2000);
            BasePage.CandidateDetailPO.btnSendEmailOffer.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".activity-container .activity-container__activity-body")));
        }

        [Then(@"the offer should be created successfully and Email Offer button is not displayed")]
        public void ThenTheOfferShouldBeCreatedSuccessfully()
        {
            Assert.Multiple(() =>
            {
                Assert.IsTrue(MyDriver.IsElementNotVisible(MyDriver.driver, By.XPath("//button[contains(.,'Email Offer')]")));
                Assert.IsTrue(MyDriver.IsElementVisible(MyDriver.driver, By.CssSelector(".activity-container .activity-container__activity-body")));
            });
        }

        [Given(@"I create an offer without send email to the candidate with Salary is ""(.*)"" and Report to ""(.*)""")]
        public void GivenICreateAnOfferWithoutSendEmailToTheCandidateWithSalaryIsAndReportTo(string salary, string reportTo)
        {
            BasePage.CandidateDetailPO.createOfferWithOutSendEmail(salary, reportTo);
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(.,'Email Offer')]")));
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".activity-container .activity-container__activity-body")));
        }

        [Then(@"the offer should be created successfully and Email Offer button is displayed")]
        public void ThenTheOfferShouldBeCreatedSuccessfullyAndEmailOfferButtonIsDisplayed()
        {
            Assert.Multiple(() =>
            {
                Assert.IsTrue(MyDriver.IsElementVisible(MyDriver.driver, By.XPath("//button[contains(.,'Email Offer')]")));
                Assert.IsTrue(MyDriver.IsElementVisible(MyDriver.driver, By.CssSelector(".activity-container .activity-container__activity-body")));               
            });
        }


        [Given(@"I update status offer to Accepted with the comment ""(.*)""")]
        public void GivenIUpdateStatusOfferToAcceptedWithTheComment(string comment)
        {
            BasePage.CandidateDetailPO.updateStatusOffer(BasePage.CandidateDetailPO.btnStatusAccept, comment);
        }


        [Then(@"the status offer should be Accepted")]
        public void ThenTheStatusOfferShouldBePassed()
        {
            Assert.IsTrue(MyDriver.IsElementVisible(MyDriver.driver, By.CssSelector(".accept-offer .accept-offer--accept-checked")));
        }

        [Given(@"I update status offer to Rejected with the comment ""(.*)""")]
        public void GivenIUpdateStatusOfferToRejectedWithTheComment(string comment)
        {
            BasePage.CandidateDetailPO.updateStatusOffer(BasePage.CandidateDetailPO.btnStatusReject, comment);
            
        }

        [Then(@"the status offer should be Rejected")]
        public void ThenTheStatusOfferShouldBeRejected()
        {
            Assert.IsTrue(MyDriver.IsElementVisible(MyDriver.driver, By.CssSelector(".reject-offer .reject-offer--reject-checked")));
        }

        [Given(@"I update offer of the candidate with the salary is ""(.*)""")]
        public void GivenIUpdateOfferOfTheCandidateWithTheSalaryIs(string salary)
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Update Offer")));
            BasePage.CandidateDetailPO.linkUpdateOffer.Click();
            Thread.Sleep(500);
            BasePage.CandidateDetailPO.fieldSalary.Clear();
            BasePage.CandidateDetailPO.fieldSalary.SendKeys(salary);
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Save')]")));
            BasePage.CandidateDetailPO.btnSaveOffer.Click();
        }

        [Then(@"the offer should be upgrade with salary is ""(.*)""")]
        public void ThenTheOfferShouldBeUpgradeWithSalaryIs(string salary)
        {
            Assert.AreEqual(salary, BasePage.CandidateDetailPO.fieldSalary.Text);
        }

        [Given(@"I click on Email Offer button")]
        public void GivenIClickOnEmailOfferButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Email Offer')]")));
            BasePage.CandidateDetailPO.btnEmailOffer.Click();
        }

        [Then(@"the offer should be sent to the candidate and Email Offer button is not displayed")]
        public void ThenTheOfferShouldBeSentToTheCandidateAndEmailOfferButtonIsNotDisplayed()
        {
            Assert.IsTrue(MyDriver.IsElementNotVisible(MyDriver.driver, By.XPath("//button[contains(.,'Email Offer')]")));
        }

        [Given(@"I update the result of the offer from Accepted to Rejected with the comment ""(.*)""")]
        public void GivenIUpdateTheResultOfTheOfferFromAcceptedToRejectedWithTheComment(string comment)
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".offer-form .offer__update-decision-text")));
            BasePage.CandidateDetailPO.linkUpdateDecision.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".reject-offer .reject-offer__reject-icon")));
            BasePage.CandidateDetailPO.updateStatusOffer(BasePage.CandidateDetailPO.btnStatusReject, comment);
        }

        [Given(@"I update the result of the offer from Rejected to Accepted with the comment ""(.*)""")]
        public void GivenIUpdateTheResultOfTheOfferFromRejectedToAcceptedWithTheComment(string comment)
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".offer-form .offer__update-decision-text")));
            BasePage.CandidateDetailPO.linkUpdateDecision.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".accept-offer .accept-offer__accept-icon")));
            BasePage.CandidateDetailPO.updateStatusOffer(BasePage.CandidateDetailPO.btnStatusAccept, comment);
        }



    }
}
