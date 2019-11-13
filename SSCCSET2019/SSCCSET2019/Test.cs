using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
namespace SSCCSET2019
{
   class Help
    {
        IWebDriver driver;
        public void Start_the_bros()
        {
            driver = new FirefoxDriver();
        }
        private IWebElement review;
        private IWebElement acc_action;
        private IWebElement add_files;
        private IWebElement documentation;
        private IWebElement forum_help;
        public Help()
        {
            review = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[1]/a"));
            acc_action = driver.FindElement(By.CssSelector("#tab-link-actions-links > a:nth-child(1)"));
            add_files = driver.FindElement(By.CssSelector("#tab-link-attaching-files > a:nth-child(1)"));
            documentation = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[2]/p[2]/a"));
            forum_help = driver.FindElement(By.CssSelector(".contextual-help-sidebar > p:nth-child(3) > a:nth-child(1)"));
        }
        public Help ReviewObjectClick()
        {
            review.Click();
            return this;
        }
        public Help ActionObjectClick()
        {
            acc_action.Click();
            return this;
        }
        public Help AddFilesObjectClick()
        {
            add_files.Click();
            return this;
        }
        public Help DocumentationObjectClick()
        {
            documentation.Click();
            return ?;
        }
        public Help ForumHelpObjectClick()
        {
            forum_help.Click();
            return ?;
        }
    }
}
