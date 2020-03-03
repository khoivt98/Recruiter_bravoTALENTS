using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bravoTALENTS_Cucumber.PageObject
{
    class BasePage
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(MyDriver.driver, page);
            return page;
        }

        public static LoginPO loginPO
        {
            get { return GetPage<LoginPO>(); }
        }

        public static JobPO JobPO
        {
            get { return GetPage<JobPO>(); }
        }
    }
}
