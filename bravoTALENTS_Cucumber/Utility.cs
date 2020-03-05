using OpenQA.Selenium;
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

        public static Boolean checkName (IList<IWebElement> list, IWebElement name)
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
    }
}
