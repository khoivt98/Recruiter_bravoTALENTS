using bravoTALENTS_Cucumber.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;


namespace bravoTALENTS_Cucumber.StepDefinition
{
    [Binding]
    public sealed class LoginSteps
    {

      

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            MyDriver.driver.Navigate().GoToUrl("https://recruiter-systemtest.bravotalents.com/");
        }

        [Given(@"I login into bravoTALENTS")]
        public void GivenILoginIntoBravoTALENTS()
        {
            BasePage.loginPO.Login("toantest@mailinator.com", "Toan844940");
            MyDriver.wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".bravo-header__navigation-menu-btn-content-text")));
        }

        [Then(@"I should navigate to jobs page")]
        public void ThenIShouldNavigateToJobsPage()
        {
            IWebElement result = MyDriver.driver.FindElement(By.CssSelector(".bravo-header__navigation-menu-btn-content-text"));
            Assert.AreEqual("JOBS", result.Text);
        }

    }
}
