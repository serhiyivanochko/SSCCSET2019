using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCCSET2019.Pages
{
    class UpdatesHelpElements
    {
        IWebDriver driver;
        private bool isVisibleHelp = false;
        /*Help*/
        IWebElement helpButton;
        IWebElement overviewHelp;
        IWebElement overviewTextHelp;
        IWebElement howToUpdateHelp;
        IWebElement howToUpdateTextHelp;
        IWebElement documentationHelp;
        IWebElement forumHelp;
        public UpdatesHelpElements(IWebDriver webDriver)
        {
            this.driver = webDriver;
            helpButton = driver.FindElement(By.Id("contextual-help-link"));
            overviewHelp = driver.FindElement(By.XPath("//*[@id=\"tab-link-overview\"]/a"));
            overviewHelp = driver.FindElement(By.Id("tab-link-overview"));
            howToUpdateHelp = driver.FindElement(By.XPath("//*[@id=\"tab-link-how-to-update\"]/a"));
            howToUpdateTextHelp = driver.FindElement(By.Id("tab-link-how-to-update"));
            documentationHelp = driver.FindElement(By.XPath("//*[@id=\"contextual-help-columns\"]/div[2]/p[2]/a"));
            forumHelp = driver.FindElement(By.XPath("//*[@id=\"contextual-help-columns\"]/div[2]/p[3]/a"));
        }
        public UpdatesHelpElements HelpHideOrShow()
        {
            helpButton.Click();
            if (helpButton.GetAttribute("aria-expanded") == "true")
            {
                isVisibleHelp = false;
            }
            else
            {
                isVisibleHelp = true;
            }
            return this;
        }
        /*public string OvervieW()
        {
            if (isVisibleHelp)
            {
                overviewHelp.Click();
                return this;
            }
            else
            {
                return null;
            }

        }*/
    }
}
