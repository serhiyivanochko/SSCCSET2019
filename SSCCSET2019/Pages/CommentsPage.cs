using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SSCCSET2019
{
    public class CommentsPage : ATopComponent
    {

        public IWebElement AllButton
        { get { return driver.FindElement(By.XPath("//*[@id='wpbody - content']/div[3]/ul/li[1]/a")); } }
        public IWebElement MyButton
        { get { return driver.FindElement(By.XPath("//*[@id='wpbody - content']/div[3]/ul/li[2]/a")); } }
        public IWebElement InWaitButton
        { get { return driver.FindElement(By.XPath("//*[@id='wpbody - content']/div[3]/ul/li[3]/a")); } }
        public IWebElement ApprovedButton
        { get { return driver.FindElement(By.XPath("//*[@id='wpbody - content']/div[3]/ul/li[4]/a")); } }
        public IWebElement SpamButton
        { get { return driver.FindElement(By.XPath("//*[@id='wpbody - content']/div[3]/ul/li[5]/a")); } }
        public IWebElement TrashButton
        { get { return driver.FindElement(By.XPath("//*[@id='wpbody - content']/div[3]/ul/li[6]/a")); } }

        public CommentsPage(IWebDriver driver) : base(driver)
        {
          
        }
         
        public CommentsPage ClickAllButton()
        {
            AllButton.Click();
            return this;
        }
       
        public CommentsPage ClickMyButton()
        {
            MyButton.Click();
            return this;
        }

        public CommentsPage ClickInWaitButton()
        {
            InWaitButton.Click();
            return this;
        }

        public CommentsPage ClickApprovedButton()
        {
            ApprovedButton.Click();
            return this;
        }

        public CommentsPage ClickSpamButton()
        {
            ApprovedButton.Click();
            return this;
        }

        public CommentsPage ClickTrashButton()
        {
            TrashButton.Click();
            return this;
        }

    }
}
