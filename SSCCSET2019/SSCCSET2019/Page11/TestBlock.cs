using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    class FiltersBlock
    {
        IWebDriver driver;


        protected IWebElement AddNewPage;
        protected IWebElement AllCurrent;
        protected IWebElement MadePublic;
        protected IWebElement Note;

        protected IWebElement select;
        protected IWebElement _select;

        protected IWebElement AppllyButton;
        protected IWebElement Filterate;


        public FiltersBlock() {
            AddNewPage = driver.FindElement(By.XPath("//*[@id='wpbody - content']/div[4]/a"));
            AllCurrent = driver.FindElement(By.XPath("//*[@id='wpbody - content']/div[4]/ul/li[1]/a"));
            MadePublic = driver.FindElement(By.XPath("//*[@id='wpbody - content']/div[4]/ul/li[2]/a"));
            Note = driver.FindElement(By.XPath("//*[@id='wpbody - content']/div[4]/ul/li[3]/a"));
            //Find element by name for filters

            select = driver.FindElement(By.TagName("select"));
            _select = driver.FindElement(By.Name("m"));

            //Find element by ID 

            AppllyButton = driver.FindElement(By.Id("doaction"));
            Filterate = driver.FindElement(By.Id("post-query-submit"));



        }
        //Click on the button
        public FiltersBlock ClickPage()
        {
            AddNewPage.Click();
            return this;
        }
        public FiltersBlock ClicKOnTheCurrentPage() {
            AllCurrent.Click();
            return this;
        }
        public FiltersBlock PublicVoidClick()
        {
            MadePublic.Click();
            return this;
        }
        public FiltersBlock NotesClick()
        {
            Note.Click();
            return this;
        }

        public void Selectors() {
            IList<IWebElement> allOptions = select.FindElements(By.TagName("option"));
            foreach (IWebElement option in allOptions)
            {
                option.Click();
            }

        }
        public void _Selectors()
        {
            IList<IWebElement> all_Options = _select.FindElements(By.TagName("option"));
            foreach (IWebElement option in all_Options)
            {
                option.Click();
            }

        }



    }
}