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
        private IWebDriver driver;
        private WebDriverWait wait;
        public LoginSteps()
        {
            driver = MyDriver.driver;
            wait = new WebDriverWait(MyDriver.driver, TimeSpan.FromSeconds(60));
        }
        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            driver.Navigate().GoToUrl("https://systemtest-accounts.bravosurveys.com/account/login?returnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fresponse_type%3Did_token%2520token%26client_id%3DResponsiveHRv2%26state%3D9cubmhtTG02kTBCYT0JnmGngDQPqeQeJpPr5jDKm%26redirect_uri%3Dhttps%253A%252F%252Frecruiter-systemtest.bravotalents.com%252Flogin%26scope%3Dopenid%2520profile%2520email%2520roles%2520hrtoolInternalApi%2520organization%26nonce%3D9cubmhtTG02kTBCYT0JnmGngDQPqeQeJpPr5jDKm");
        }

        [Given(@"I login into bravoTALENTS")]
        public void GivenILoginIntoBravoTALENTS()
        {
            BasePage.loginPO.Login("zoi004@mailinator.com", "Khoi@123");
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".bravo-header__navigation-menu-btn-content-text")));
        }

        [Then(@"I should navigate to jobs page")]
        public void ThenIShouldNavigateToJobsPage()
        {
            IWebElement result = driver.FindElement(By.CssSelector(".bravo-header__navigation-menu-btn-content-text"));
            Assert.AreEqual("JOBS", result.Text);
        }

    }
}
