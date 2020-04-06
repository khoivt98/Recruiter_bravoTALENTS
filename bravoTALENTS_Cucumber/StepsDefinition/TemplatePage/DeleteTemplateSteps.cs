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

namespace bravoTALENTS_Cucumber.StepsDefinition.TemplatePage
{
    [Binding]
    public sealed class DeleteTemplateSteps
    {
        [Given(@"I navigate to templates screen")]
        public void GivenINavigateToTemplatesScreen()
        {
            BasePage.CandidatePO.dropdownMenu.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.menuTemplate));
            BasePage.TemplateListPO.menuTemplate.Click();
        }

        [When(@"I back to template list")]
        public void ThenIBackToTemplateList()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateDetailPO.closeTemplateDetailButton));
            BasePage.TemplateDetailPO.closeTemplateDetailButton.Click();
        }

        [When(@"I show deleted templates")]
        public void ThenIShowDeletedTemplates()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.filterTab));
            BasePage.TemplateListPO.filterTab.Click();

            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.showAllDeletedTemplateText));
            BasePage.TemplateListPO.showAllDeletedTemplateText.Click();

            Thread.Sleep(1000);
        }


        [When(@"I click into the check box of the first template")]
        public void WhenIClickIntoTheCheckBoxOfTheFirstTemplate()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementExists(By.CssSelector(".template-content:nth-child(1)")));
            BasePage.TemplateListPO.firstTemplateCheckbox.Click();
        }

        [When(@"I click on delete icon")]
        public void WhenIClickOnDeleteIcon()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.deleteIcon));
            BasePage.TemplateListPO.deleteIcon.Click();

            Thread.Sleep(1000);
        }       

        [Then(@"The first template should be deleted")]
        public void ThenTheFirstTemplateShouldBeDeleted()
        {
            Assert.IsTrue(Utility.isElementPresent(By.CssSelector("tr:nth-child(1) td.template-header__status-icon i")));
        }

        //Delete template in quick card
        [When(@"I click on quick card button")]
        public void WhenIClickOnQuickCardButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateDetailPO.quickCardButton));
            BasePage.TemplateDetailPO.quickCardButton.Click();
        }

        [When(@"I click into the delete template button")]
        public void WhenIClickIntoTheDeleteTemplateButton()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.deleteTemplateButtonInQuickCard));
            BasePage.TemplateListPO.deleteTemplateButtonInQuickCard.Click();
        }

        [Then(@"The template should be deleted")]
        public void ThenTheTemplateShouldBeDeleted()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateListPO.undoDeleteButonInQuickCard));
            Assert.IsTrue(BasePage.TemplateListPO.undoDeleteButonInQuickCard.Displayed);
        }


        //Delete template in template detail
        [When(@"I click into the delete template button in template detail")]
        public void WhenIClickIntoTheDeleteTemplateButtonInTemplateDetail()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateDetailPO.deleteTemplateButton));
            BasePage.TemplateDetailPO.deleteTemplateButton.Click();
        }

        [Then(@"The template should be deleted in template detail")]
        public void ThenTheTemplateShouldBeDeletedInTemplateDetail()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.TemplateDetailPO.undoDeleteButton));
            Assert.IsTrue(BasePage.TemplateDetailPO.undoDeleteButton.Displayed);
        }




    }
}
