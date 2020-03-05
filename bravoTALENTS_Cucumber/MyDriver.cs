using bravoTALENTS_Cucumber.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bravoTALENTS_Cucumber
{
    public class MyDriver
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;

        //public static bool IsElementVisible(IWebDriver driver, By element)
        //{
        //    if (driver.FindElements(element).Count > 0)
        //    {
        //        if (driver.FindElement(element).Displayed)
        //            return true;
        //        else
        //            return false;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        /*public static bool IsElementNotVisible(IWebDriver driver, By element)
        {
            if (driver.FindElements(element).Count > 0)
            {
                if (driver.FindElement(element).Displayed)
                    return false;
                else
                    return false;
            }
            else
            {
                return true;
            }
        }*/
        public static bool IsElementVisible(IWebDriver driver, By element)
        {
            if (driver.FindElements(element).Count > 0)
                return true;
            else
                return false;
        }

        public static bool IsElementNotVisible(IWebDriver driver, By element)
        {
            if (driver.FindElements(element).Count > 0)         
                    return false;
            else
                return true;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static IWebElement getElementByName(IList<IWebElement> list, string name)
        {
            IWebElement element;
            for (int i=0; i < list.Count; i++)
            {
                if(list[i].Text == name)
                {
                    element = list[i];
                    return element;
                }
            }
            return null;
        }
    }
}
