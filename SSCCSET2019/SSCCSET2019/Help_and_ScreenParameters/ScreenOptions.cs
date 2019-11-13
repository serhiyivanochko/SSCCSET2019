using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SSCCSET2019.Help_and_ScreenParameters
{
      public class ScreenOptions
    {
        IWebDriver driver;
        //Column Constructor Buttoms
        public IWebElement ColumnsLabel
        { get { return driver.FindElement(By.XPath("//*[@id='adv-settings']/fieldset[1]/legend")); } }
        public IWebElement AuthorLabel
        { get { return driver.FindElement(By.Id("author-hide")); } }
        public IWebElement ResponseLabel
        { get { return driver.FindElement(By.Id("response - hide")); } }
        public IWebElement SendedLabel
        { get { return driver.FindElement(By.Id("date - hide")); } }

        //Page Numbering
        public IWebElement RecordNumberLabel
        { get { return driver.FindElement(By.XPath("//*[@id='adv-settings']/fieldset[2]/legend")); } }
        public IWebElement NumberPageLabel
        { get { return driver.FindElement(By.XPath("//label[contains(@for,'edit_comments_per_page')]")); } }
        public IWebElement NumberPageEdit
        { get { return driver.FindElement(By.Id("edit_comments_per_page")); } }

        public IWebElement SubmitButton
        { get { return driver.FindElement(By.Id("screen - options - apply")); } }

    }
}