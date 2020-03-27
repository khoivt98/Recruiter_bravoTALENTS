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
    public sealed class EditApplyBeforeDateSteps
    {
        string date;

        [When(@"I click on the calendar icon")]
        public void WhenIClickOnTheCalendarIcon()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.theJobTitle));

            if (Utility.isElementPresent(By.CssSelector("span.job-header__date-text")))
            {
                BasePage.JobDetailPO.calendarIcon.Click();
            }
            else
            {              
                BasePage.JobDetailPO.clickHereToSet.Click();
            }           
        }

        [When(@"I select date")]
        public void WhenISelectDate()
        {           
            BasePage.JobDetailPO.nextMonthIcon.Click();
            string monthAndYear = BasePage.JobDetailPO.calendarTitle.Text;

            string day =MyDriver.getElementByName(BasePage.JobDetailPO.selectDay, "10").Text;
            MyDriver.getElementByName(BasePage.JobDetailPO.selectDay, "10").Click();

            date = day + " " + monthAndYear;
        }

        [Then(@"The apply before date is updated")]
        public void ThenTheApplyBeforeDateIsUpdated()
        {
            Assert.AreEqual(DateTime.Parse(BasePage.JobDetailPO.applyBeforeDate.Last().Text), DateTime.Parse(date));
        }

    }
}
