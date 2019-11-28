using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace SSCCSET2019.Logic
{
    class FilterBlock
    {
        protected static IWebDriver driver;
        Filter items = new Filter(driver);
        public void LogIn()
        {
            driver.Navigate().GoToUrl("http://localhost/site1/wp-login.php?loggedout=true");
            driver.FindElement(By.Id("user_login")).SendKeys("ostap21");
            driver.FindElement(By.Id("user_pass")).SendKeys("jKeY8QZ&FHOE7n09Dg");
            driver.FindElement(By.Id("wp-submit")).Click();
        }
        public Filter GoToAddNewPage()
        {
            items.ClickPage();
            return new Filter(driver);
        }
        public Filter GoToFilterBlock()
        {
            items.ClicKOnTheCurrentPage();
            return new Filter(driver);
        }
        public Filter GoToPublic()
        {
            items.PublicVoidClick();
            return new Filter(driver);
        }
        public Filter GoToNotesPage()
        {
            items.NotesClick();
            return new Filter(driver);
        }
        public Filter GoToRealFilter()
        {
            items.Selectors();
            return new Filter(driver);
        }
        public Filter GoToRealFilter1()
        {
            items._Selectors();
            return new Filter(driver);
        }
    }
}
