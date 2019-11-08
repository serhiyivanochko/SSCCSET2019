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


        public void hideShow() {
            
            hide_show.Click();
        }

        public void viewAllComments() {

            comment.Click();
        }
         public void viewAllPosts() {

            post.Click();
        }
        public void viewAllPagas() {

            page.Click();
        } 
        public void viewAllThemes() {

            themes_count.Click();
        }
         public string getWpVersion() {

            return version.Text;
        }

        public void seatingSearchEngine()
        {
            search_engins.Click();
        }


    }
}
