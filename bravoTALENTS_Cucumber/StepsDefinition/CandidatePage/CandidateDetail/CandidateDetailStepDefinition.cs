using bravoTALENTS_Cucumber.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
    public sealed class CandidateDetailStepDefinition
    {
        [Given(@"I click on View CV")]
        public void GivenIClickOnViewCV()
        {
            BasePage.CandidateCardPO.linkViewCV.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Add item')]")));
        }

        [Given(@"I add Summary with ""(.*)""")]
        public void GivenIAddSummaryWith(string summary)
        {
            BasePage.CandidateDetailPO.fieldSummary.SendKeys(summary);
            BasePage.CandidateCardPO.linkViewCV.Click();
        }

        [Then(@"the summary should be added with ""(.*)""")]
        public void ThenTheSummaryShouldBeAddedWith(string p0)
        {
            Assert.AreEqual("E2E Summary", BasePage.CandidateDetailPO.fieldSummary.Text);
        }



        [Given(@"I add Work Experience to the candidate with Company is ""(.*)"" and Position is ""(.*)""")]
        public void GivenIAddWorkExperienceToTheCandidateWithCompanyIsAndPositionIs(string companyName, string position)
        {
            BasePage.CandidateDetailPO.openItemPanel(BasePage.CandidateDetailPO.btnAddWorkExperience);
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("companyInput")));
            BasePage.CandidateDetailPO.fieldCompany.SendKeys(companyName);
            BasePage.CandidateDetailPO.fieldPosition.SendKeys(position);
            BasePage.CandidateDetailPO.fillDuration(BasePage.CandidateDetailPO.durationFrom[0], BasePage.CandidateDetailPO.January, BasePage.CandidateDetailPO.durationTo[0], BasePage.CandidateDetailPO.Febuary);
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Save')]")));
            BasePage.CandidateDetailPO.btnSave.Click();
        }


        [Given(@"I add Educations with Name Of School is ""(.*)""")]
        public void GivenIAddEducationsWithNameOfSchoolIs(string schoolname)
        {
            BasePage.CandidateDetailPO.openItemPanel(BasePage.CandidateDetailPO.btnAddEducation);
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("schoolNameInput")));
            BasePage.CandidateDetailPO.fieldSchoolName.SendKeys(schoolname);
            BasePage.CandidateDetailPO.fillDuration(BasePage.CandidateDetailPO.durationFrom[0], BasePage.CandidateDetailPO.January, BasePage.CandidateDetailPO.durationTo[0], BasePage.CandidateDetailPO.Febuary);
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Save')]")));
            BasePage.CandidateDetailPO.btnSave.Click();
        }


        [Given(@"I add Language Skill with Language Name is ""(.*)""")]
        public void GivenIAddLanguageSkillWithLanguageNameIs(string languageName)
        {
            BasePage.CandidateDetailPO.openItemPanel(BasePage.CandidateDetailPO.btnAddLanguage);
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("nameInput")));
            BasePage.CandidateDetailPO.fieldLanguageName.SendKeys(languageName);
            BasePage.CandidateDetailPO.dropdownLevelLanguage.Click();
            BasePage.CandidateDetailPO.levelBeginner.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Save')]")));
            BasePage.CandidateDetailPO.btnSave.Click();
        }


        [Given(@"I add Project with Project Name is ""(.*)""")]
        public void GivenIAddProjectWithProjectNameIs(string projectName)
        {
            BasePage.CandidateDetailPO.openItemPanel(BasePage.CandidateDetailPO.btnAddProject);
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".project-form #name")));
            BasePage.CandidateDetailPO.fieldProjectName.SendKeys(projectName);
            BasePage.CandidateDetailPO.fillDuration(BasePage.CandidateDetailPO.fromMonth, BasePage.CandidateDetailPO.January, BasePage.CandidateDetailPO.toMonth, BasePage.CandidateDetailPO.Febuary);
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Save')]")));
            BasePage.CandidateDetailPO.btnSave.Click();
        }


        [Given(@"I add Course with Course Name is ""(.*)""")]
        public void GivenIAddCourseWithCourseNameIs(string courseName)
        {
            BasePage.CandidateDetailPO.openItemPanel(BasePage.CandidateDetailPO.btnAddCourses);
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".course-form #name")));
            BasePage.CandidateDetailPO.fieldCourseName.SendKeys(courseName);
            BasePage.CandidateDetailPO.fillDuration(BasePage.CandidateDetailPO.fromMonth, BasePage.CandidateDetailPO.January, BasePage.CandidateDetailPO.toMonth, BasePage.CandidateDetailPO.Febuary);
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Save')]")));
            BasePage.CandidateDetailPO.btnSave.Click();
        }


        [Given(@"I add Certification with Certification Name is ""(.*)""")]
        public void GivenIAddCertificationWithCertificationNameIs(string certificationName)
        {
            BasePage.CandidateDetailPO.openItemPanel(BasePage.CandidateDetailPO.btnAddCertification);
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".certification-form #name")));
            BasePage.CandidateDetailPO.fieldCertificationName.SendKeys(certificationName);
            BasePage.CandidateDetailPO.fillDuration(BasePage.CandidateDetailPO.fromMonth, BasePage.CandidateDetailPO.January, BasePage.CandidateDetailPO.toMonth, BasePage.CandidateDetailPO.Febuary);
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Save')]")));
            BasePage.CandidateDetailPO.btnSave.Click();
        }


        [Given(@"I add Reference with Full Name is ""(.*)"" and Email is ""(.*)"" and Phone is ""(.*)""")]
        public void GivenIAddReferenceWithFullNameIsAndEmailIsAndPhoneIs(string fullName, string email, string phone)
        {
            BasePage.CandidateDetailPO.openItemPanel(BasePage.CandidateDetailPO.btnAddReference);
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".reference-form #nameInput")));
            BasePage.CandidateDetailPO.fieldFullName.SendKeys(fullName);
            BasePage.CandidateDetailPO.fieldEmail.SendKeys(email);
            BasePage.CandidateDetailPO.fieldPhone.SendKeys(phone);
            BasePage.CandidateDetailPO.fieldFullName.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Save')]")));
            BasePage.CandidateDetailPO.btnSave.Click();
        }


        [Then(@"the Title of added item should be ""(.*)""")]
        public void ThenTheTitleOfAddedItemShouldBe(string title)
        {
            Assert.AreEqual(title, BasePage.CandidateDetailPO.titleWorkExperience.Text);
        }


        [Given(@"I edit the added Work Experience with Company is ""(.*)"" and Position is ""(.*)""")]
        public void GivenIEditTheAddedWorkExperienceWithCompanyIsAndPositionIs(string companyName, string position)
        {
            Utility.moveToElement(BasePage.CandidateDetailPO.titleWorkExperience);
            BasePage.CandidateDetailPO.iconEditItem.Click();
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("companyInput")));
            BasePage.CandidateDetailPO.fieldCompany.Clear();
            BasePage.CandidateDetailPO.fieldCompany.SendKeys(companyName);
            BasePage.CandidateDetailPO.fieldPosition.Clear();
            BasePage.CandidateDetailPO.fieldPosition.SendKeys(position);
            MyDriver.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Save')]")));
            BasePage.CandidateDetailPO.btnSave.Click();
            MyDriver.wait.Until(ExpectedConditions.TextToBePresentInElement(BasePage.CandidateDetailPO.titleWorkExperience, "E2E Work Experience updated"));
        }

        [Given(@"I remove the added Work Experience")]
        public void GivenIRemoveTheAddedWorkExperience()
        {
            Utility.moveToElement(BasePage.CandidateDetailPO.titleWorkExperience);
            BasePage.CandidateDetailPO.iconDeleteItem.Click();
            BasePage.CandidateDetailPO.btnConfirmDelete.Click();
            MyDriver.wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector(".cv-content__item .time-line__title")));
        }

        [Then(@"the Work Experience should be removed")]
        public void ThenTheWorkExperienceShouldBeRemovd()
        {
            Assert.IsTrue(MyDriver.IsElementNotVisible(MyDriver.driver, By.CssSelector(".cv-content__item .time-line__title")));
        }

       

    }
}
