
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace SSCCSET2019.Pages
{
    class TopBarPage
    {
        IWebDriver driver;

        IWebElement barWPLogo;

        IWebElement barAboutWP;
        IWebElement barWPOrg;
        IWebElement barDocumentation;
        IWebElement barSupportForums;
        IWebElement barFeedback;

        IWebElement barSiteName;
        IWebElement barViewSite;

        IWebElement barUpDates;
        IWebElement barComments;
        IWebElement barNewContent;
        IWebElement barNewPost;
        IWebElement barNewMedia;
        IWebElement barNewPage;
        IWebElement barNewUser;
        IWebElement barMyAccount;
        public TopBarPage()
            {
            barWPLogo = driver.FindElement(By.Id("wp-admin-bar-site-name"));
            barAboutWP = driver.FindElement(By.Id("wp-admin-bar-about"));
            barWPOrg = driver.FindElement(By.Id("wp-admin-bar-wporg"));
            barDocumentation = driver.FindElement(By.Id("wp-admin-bar-documentation"));
            barSupportForums = driver.FindElement(By.Id("wp-admin-bar-support-forums"));
            barFeedback = driver.FindElement(By.Id("wp-admin-bar-feedback"));
            barSiteName = driver.FindElement(By.Id("wp-admin-bar-updates"));
            barViewSite = driver.FindElement(By.Id("wp-admin-bar-view-site")); 
            barUpDates =  driver.FindElement(By.Id("wp-admin-bar-site-name"));
            barComments = driver.FindElement(By.Id("wp-admin-bar-comments"));
            barNewContent = driver.FindElement(By.Id("wp-admin-bar-site-name"));
            barNewPost = driver.FindElement(By.Id("wp-admin-bar-new-post"));
            barNewMedia = driver.FindElement(By.Id("wp-admin-bar-new-media"));
            barNewPage = driver.FindElement(By.Id("wp-admin-bar-new-page")); 
            barNewUser = driver.FindElement(By.Id("wp-admin-bar-new-user")); 
            barMyAccount = driver.FindElement(By.Id("wp-admin-bar-my-account"));
        }
        
        public void OpenSitePage()
        {
            barSiteName.Click();
        }
        public void OpenUpDatesPage()
        {
            barUpDates.Click();
        
        }
        public void OpenCommentsPage()
        {
            barComments.Click();
        }
        public void OpenNewPostPage()
        {
            barNewContent.Click();
        }
        public void OpenMyAccountPage()
        {
            barMyAccount.Click();
        }
    }
}
