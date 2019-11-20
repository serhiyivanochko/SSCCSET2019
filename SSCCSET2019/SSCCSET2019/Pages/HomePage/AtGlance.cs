using OpenQA.Selenium;
using System.Threading;

namespace SSCCSET2019.Pages.HomePage
{
    class AtGlance
    {
        IWebDriver driver;
        IWebElement hideShow;
        IWebElement post;
        IWebElement comment;
        IWebElement page;
        IWebElement themesCount;
        IWebElement updtBtn;
        public AtGlance(IWebDriver driver)
        {
            this.driver = driver;
            if (IsVisible(driver))
            {
                post = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[1]/a"));
                page = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[2]/a"));
                comment = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[3]/a"));
                themesCount = driver.FindElement(By.XPath(@"//*[@id='wp-version']/a"));
                updtBtn = driver.FindElement(By.XPath(@"//*[@id='wp-version-message']/a"));
            }
            else
            {
                HideOrShow();
                post = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[1]/a"));
                page = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[2]/a"));
                comment = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/div/div/ul/li[3]/a"));
                themesCount = driver.FindElement(By.XPath(@"//*[@id='wp-version']/a"));
                updtBtn = driver.FindElement(By.XPath(@"//*[@id='wp-version-message']/a"));
            }
        }

        public void HideOrShow()
        {
           hideShow.Click();
        }
        public static bool IsVisible(IWebDriver driver )
        {
            IWebElement hideShow = driver.FindElement(By.XPath(@"//*[@id='dashboard_right_now']/button"));
            return (hideShow.GetAttribute("aria-expanded") == "true");
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
   

