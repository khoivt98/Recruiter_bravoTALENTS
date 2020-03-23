﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bravoTALENTS_Cucumber
{
    class Utility
    {
        public static string getScreenshot(IWebDriver driver, String screenshotname)
        {
            string dateTakeScreenShot = DateTime.Now.ToString("dd-MM-yyyy");
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            //string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            //string finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "ErrorScreenshots\\" + screenshotname + "_" + dateTakeScreenShot + ".png";
            string finalpth = @"C:\Projects\Recruiter_bravoTALENTS\bravoTALENTS_Cucumber\ExtentReport\ErrorScreenshots\ERROR_" + screenshotname + "_" + dateTakeScreenShot + ".png";
            string localpath = new Uri(finalpth).LocalPath;
            screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
            return localpath;
        }

        public static Boolean isElementPresent(By locatorKey)
        {
            try
            {
                MyDriver.driver.FindElement(locatorKey);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static Boolean checkName(IList<IWebElement> list, IWebElement name)
        {
            Boolean flag = true;
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Click();
                if (list[i].Text.Equals(name.Text))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }

        public static int getTotalItemInList(IList<IWebElement> list, IWebDriver driver)
        {
            var count = 0;
            for (int i = 0; i < list.Count(); i += list.Count() - (i + 1))
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(list[i]);
                actions.Perform();
                if (i + 1 == list.Count())
                {
                    count = i + 1;
                    break;
                }                
            }
            return count;
        }

        public static int getTotalItemWithStatusInList(IList<IWebElement> list, IWebDriver driver, string status)
        {
            int count = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].Text.Equals(status))
                {
                    count = i + 1;
                }
            }
            return count;
        }

        public static int getTotalItemWithColorIconInList(IList<IWebElement> list, IWebDriver driver, string color)
        {
            int count = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].GetAttribute("style").Equals(color))
                {
                    count = i + 1;
                }
            }
            return count;
        }

        public static void selectOptionFromDropdown(IWebElement element, string title)
        {
            SelectElement dropdownElement = new SelectElement(element);
            dropdownElement.SelectByText(title);
        }

        public static void moveToElement(IWebElement element)
        {
            Actions action = new Actions(MyDriver.driver);
            action.MoveToElement(element).Perform();
        }
    }
}
