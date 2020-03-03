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
            string finalpth = @"C:\Users\khoi.vo\source\repos\bravoTALENTS_Cucumber\bravoTALENTS_Cucumber\ExtentReport\ErrorScreenshots\ERROR_" + screenshotname + "_" + dateTakeScreenShot + ".png";
            string localpath = new Uri(finalpth).LocalPath;
            screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
            return localpath;
        }
    }
}
