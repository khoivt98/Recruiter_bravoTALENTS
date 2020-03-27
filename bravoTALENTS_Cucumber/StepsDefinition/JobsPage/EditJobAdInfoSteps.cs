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
    public sealed class EditJobAdInfoSteps
    {
        string positionLevel;
        string jobType;
        string jobCategory;
        string location;
        string skill;
        string salary = "Negotiable";
        string fromSalary = "1000";
        string toSalary = "1200";
        string vacancies = "10";
        string contactPerson = "Ms. Kim";

        [When(@"I click on the right side")]
        public void WhenIClickOnTheRightSide()
        {
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(BasePage.JobDetailPO.theRightSidePanel));
            BasePage.JobDetailPO.theRightSidePanel.Click();
        }

        [When(@"I edit all fields in the job information")]
        public void WhenIEditAllFieldsInTheJobInformation()
        {
            BasePage.JobDetailPO.positionLevelDropdown.Click();
            positionLevel = BasePage.JobDetailPO.selectDropdownItem[5].Text;
            BasePage.JobDetailPO.selectDropdownItem[5].Click();

            BasePage.JobDetailPO.jobTypeDropdown.Click();
            jobType = BasePage.JobDetailPO.selectDropdownItem[3].Text;
            BasePage.JobDetailPO.selectDropdownItem[3].Click();

            BasePage.JobDetailPO.jobCategoryDropdown.Click();
            jobCategory = BasePage.JobDetailPO.selectDropdownItem[2].Text;
            BasePage.JobDetailPO.selectDropdownItem[2].Click();

            BasePage.JobDetailPO.locationDropdown.Click();
            location = BasePage.JobDetailPO.locationItem[1].Text;
            BasePage.JobDetailPO.locationItem[1].Click();

            if (Utility.isElementPresent(By.CssSelector("span.ng-clear-wrapper.ng-star-inserted")))
            {
                MyDriver.driver.FindElement(By.CssSelector("span.ng-clear-wrapper.ng-star-inserted")).Click();
            }
            BasePage.JobDetailPO.skillDropdown.Click();
            skill = BasePage.JobDetailPO.selectSkill[4].Text;
            BasePage.JobDetailPO.selectSkill[4].Click();

            BasePage.JobDetailPO.vacanciesField.Clear();
            BasePage.JobDetailPO.vacanciesField.SendKeys(vacancies);

            BasePage.JobDetailPO.contactPersonField.Clear();
            BasePage.JobDetailPO.contactPersonField.SendKeys(contactPerson);
        }

        [When(@"I click on the negotiable checkbox")]
        public void WhenIClickOnTheNegotiableCheckbox()
        {           
            if (BasePage.JobDetailPO.checkboxSalary.Selected == false)
            {
                Utility.clickOnHiddenInput("Id", "currency");
            }
        }

        [When(@"I input the salary")]
        public void WhenIInputTheSalary()
        {           
            Utility.clickOnHiddenInput("Id", "currency");

            BasePage.JobDetailPO.formSalaryField.Clear();
            BasePage.JobDetailPO.formSalaryField.SendKeys(fromSalary);

            BasePage.JobDetailPO.toSalaryField.Clear();
            BasePage.JobDetailPO.toSalaryField.SendKeys(toSalary);

            BasePage.JobDetailPO.salaryCurrencyDropdown.Click();
            string currency = BasePage.JobDetailPO.selectDropdownItem[1].Text;
            BasePage.JobDetailPO.selectDropdownItem[1].Click();
                
            BasePage.JobDetailPO.salaryPeriodDropdown.Click();
            string period = BasePage.JobDetailPO.selectDropdownItem[2].Text;
            BasePage.JobDetailPO.selectDropdownItem[2].Click();
                
            salary = fromSalary + " - " + toSalary + " " + currency + " / " + period;          
        }


        [When(@"I click on the save button")]
        public void WhenIClickOnTheSaveButton()
        {
            BasePage.JobDetailPO.saveButtonInJobInformation.Click();
        }

        [Then(@"The job information is updated")]
        public void ThenTheJobInformationIsUpdated()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(positionLevel, BasePage.JobDetailPO.positionLevelValue.Text);
                Assert.AreEqual(jobType, BasePage.JobDetailPO.jobTypeValue.Text);
                Assert.AreEqual(jobCategory, BasePage.JobDetailPO.jobCategoryValue.Text);
                Assert.AreEqual(location, BasePage.JobDetailPO.locationlValue.Text);
                Assert.AreEqual(skill, BasePage.JobDetailPO.skillValue.Text);
                Assert.AreEqual(salary, BasePage.JobDetailPO.salaryValue.Text.Trim());
                Assert.AreEqual(vacancies, BasePage.JobDetailPO.vacanciesValue.Text);
                Assert.AreEqual(contactPerson, BasePage.JobDetailPO.contactPersonValue.Text);
            });
        }
    }
}
