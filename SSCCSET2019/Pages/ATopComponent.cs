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
    public abstract class ATopComponent
    {
        protected IWebDriver driver;
        public IWebElement TitleLabel
            { get { return driver.FindElement(By.XPath("//*[@id= 'wpbody - content']/div[3]/h1")); } }

        protected ATopComponent(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string GetTitleLabaleText()
        {
            return TitleLabel.Text;
        }
        public void ClickTitleLabel()
        {
            TitleLabel.Click();
        }
    }
}
