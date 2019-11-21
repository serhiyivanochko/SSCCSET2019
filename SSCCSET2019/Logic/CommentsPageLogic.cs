using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace SSCCSET2019.Logic
{
    class CommentsPageLogic
    {
        protected static IWebDriver driver;
        CommentsPage items = new CommentsPage(driver);
        public void LogIn()
        {
            driver.Navigate().GoToUrl("http://localhost/site1/wp-login.php?loggedout=true");
            driver.FindElement(By.Id("user_login")).SendKeys("Nexzoor");
            driver.FindElement(By.Id("user_pass")).SendKeys("rocketsven23");
            driver.FindElement(By.Id("wp-submit")).Click();
        }
        public CommentsPage GoToMyComments()
        {
            items.ClickMyButton();
            return new CommentsPage(driver);
        }
        public CommentsPage GoToAllComments()
        {
            items.ClickAllButton();
            return new CommentsPage(driver);
        }
        public CommentsPage GoToInWaitComments()
        {
            items.ClickInWaitButton();
            return new CommentsPage(driver);
        }
        public CommentsPage GoToApprovedComments()
        {
            items.ClickApprovedButton();
            return new CommentsPage(driver);
        }
        public CommentsPage GoToSpamComments()
        {
            items.ClickSpamButton();
            return new CommentsPage(driver);
        }
        public CommentsPage GoToTrashComments()
        {
            items.ClickTrashButton();
            return new CommentsPage(driver);
        }
       
    }
}
