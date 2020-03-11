using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bravoTALENTS_Cucumber.PageObject.JobsPage
{
    class JobListPO
    {
        //Job action bar
        [FindsBy(How = How.CssSelector, Using = "i.sprite-faded-star.big.sprite-active")]
        public IWebElement followIcon { get; set; }

        [FindsBy(How = How.CssSelector, Using = "i.sprite-x-star.big.sprite-active")]
        public IWebElement unfollowIcon { get; set; }

        //Job list
        [FindsBy(How = How.CssSelector, Using = ".job-content:nth-child(1) .checkbox-label")]
        public IWebElement firstJobCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "tr:nth-of-type(1) > td > .sprite-filled-star")]
        public IWebElement firstStarIcon { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".sprite-filled-star")]
        public IList<IWebElement> starIconList { get; set; }

        [FindsBy(How = How.CssSelector, Using = "tr.job-content ")]
        public IList<IWebElement> jobList { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-header__status-process > .job-content__status-text")]
        public IList<IWebElement> statusName { get; set; }

        [FindsBy(How = How.CssSelector, Using = " .job-header__status-process > .status-icon")]
        public IList<IWebElement> statusIcon { get; set; }

        //Main filter
        [FindsBy(How = How.CssSelector, Using = ".main-filter__item:nth-child(2)")]
        public IWebElement followedButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".main-filter__item:nth-child(1)")]
        public IWebElement allButton { get; set; }

        //Pipeline filter
        [FindsBy(How = How.CssSelector, Using = ".job-status-filter__item:nth-child(1) .job-status-filter__status-number")]
        public IWebElement allStatusPipelineNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-status-filter__item:nth-child(2) .job-status-filter__status-number")]
        public IWebElement draftPipelineNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-status-filter__item:nth-child(3) .job-status-filter__status-number")]
        public IWebElement pendingPipelineNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-status-filter__item:nth-child(4) .job-status-filter__status-number")]
        public IWebElement publishedPipelineNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-status-filter__item:nth-child(5) .job-status-filter__status-number")]
        public IWebElement closedPipelineNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-status-filter__item:nth-child(6) .job-status-filter__status-number")]
        public IWebElement finishedPipelineNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-status-filter__item:nth-child(1)")]
        public IWebElement allStatusPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-status-filter__item:nth-child(2)")]
        public IWebElement draftPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-status-filter__item:nth-child(3)")]
        public IWebElement pendingPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-status-filter__item:nth-child(4)")]
        public IWebElement publishedPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-status-filter__item:nth-child(5)")]
        public IWebElement closedPipeline { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".job-status-filter__item:nth-child(6)")]
        public IWebElement finishedPipeline { get; set; }

    }
}
