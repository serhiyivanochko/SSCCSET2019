using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCCSET2019.Pages.HomePage
{
    class AtGlanceElements
    {
        private bool isVisible = false;
        IWebDriver driver;
        IWebElement hideShow;
        IWebElement post;
        IWebElement comment;
        IWebElement page;
        IWebElement themesCount;
        IWebElement updtBtn;
        public AtGlanceElements(IWebDriver driver)
        {
                hideShow = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/button"));
                post = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[1]/a"));
                page = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[2]/a"));
                comment = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[3]/a"));
                themesCount = driver.FindElement(By.XPath(@"//*[@id='wp-version']/a"));
                post = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[1]/a"));
                page = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[2]/a"));
                comment = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[3]/a"));
                themesCount = driver.FindElement(By.XPath(@"//*[@id='wp-version']/a"));
                updtBtn = driver.FindElement(By.XPath(@"//*[@id='wp-version-message']/a"));
        }

        public AtGlanceElements HideOrShow()
        {
            hideShow.Click();
            if (hideShow.GetAttribute("aria-expanded") == "true")
            {
                isVisible = false;
            }
            else
            {
                isVisible = true;
            }
            return this;
        }
        public CommentPage ClickComments()
        {
            comment.Click();
            return new CommentPage();
        }
        public PostsPage ClickPosts()
        {
            post.Click();
            return new PostsPage();
        }
        public PagesPage ViewAllPages()
        {
            page.Click();
            return new PagesPage();
        }
        public ThemesPage ViewAllThemes()
        {
            themesCount.Click();
            return new ThemesPage();
        }
        public UpdatesPage ClickUpdateBtn()
        {
            updtBtn.Click();
            return new UpdatesPage();
        }
    }
}
