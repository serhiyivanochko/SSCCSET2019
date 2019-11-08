using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCCSET2019.Pages.HomePage
{
    class AtGlance
    {
        IWebDriver driver = Driver.GetInstance().driver;

        IWebElement hide_show;
        IWebElement post;
        IWebElement comment;
        IWebElement page;

        IWebElement themes_count;
        IWebElement search_engins;
        IWebElement version;

        public AtGlance() {
           
            hide_show = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/button"));
            post = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[1]/a"));
            page = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[2]/a"));
            comment = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[3]/a"));

            themes_count = driver.FindElement(By.XPath(@"//*[@id='wp - version']/a"));
            version = driver.FindElement(By.XPath(@"//*[@id='wp - version']/text()[1]"));
            search_engins = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/p[2]/a"));



        }


        public void HideOrShow() {
            
            hide_show.Click();
        }

        public void ViewAllComments() {

            comment.Click();
        }
         public void ViewAllPosts() {

            post.Click();
        }
        public void ViewAllPagas() {

            page.Click();
        } 
        public void ViewAllThemes() {

            themes_count.Click();
        }
         public string GetWpVersion() {

            return version.Text;
        }

        public void GoToSeatingSearchEngine()
        {
            search_engins.Click();
        }


    }
}
