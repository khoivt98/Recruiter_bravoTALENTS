using bravoTALENTS_Cucumber.PageObject.CandidatePage;
using bravoTALENTS_Cucumber.PageObject.JobsPage;
using bravoTALENTS_Cucumber.PageObject.TemplatePage;
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

        public static JobListPO JobListPO
        {
            get { return GetPage<JobListPO>(); }
        }

        public static JobDetailPO JobDetailPO
        {
            get { return GetPage<JobDetailPO>(); }
        }

        public static CandidatePO CandidatePO
        {
            get { return GetPage<CandidatePO>(); }
        }

        public static TemplateDetailPO TemplateDetailPO
        {
            get { return GetPage<TemplateDetailPO>(); }
        }

        public static TemplateListPO TemplateListPO
        {
            get { return GetPage<TemplateListPO>(); }
        }
    }
}
