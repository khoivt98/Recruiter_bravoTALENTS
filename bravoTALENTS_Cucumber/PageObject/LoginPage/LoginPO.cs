using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bravoTALENTS_Cucumber.PageObject
{
    class LoginPO
    {
        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".btn.btn-default.common-button.valid")]
        public IWebElement btnSignin { get; set; }

        public void Login(string email, string password)
        {
            txtEmail.SendKeys(email);
            txtPassword.SendKeys(password);
            btnSignin.Click();
        }
    }
}
