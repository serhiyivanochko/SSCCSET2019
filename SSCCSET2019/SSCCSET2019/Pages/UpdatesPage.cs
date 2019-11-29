using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SSCCSET2019.Pages
{
    class UpdatesPage
    {
        private bool isVisiblePluginsAvailable = true;

        IWebDriver driver;
        IWebElement title;
        IWebElement lastcheckText;
        IWebElement checkButton;
        IWebElement checkConclusionText;
        IWebElement text3;
        IWebElement text4;
        /*Plagins*/
        IWebElement pluginsText;
        IWebElement availablePluginsText;
        /*Theme*/
        IWebElement themeTitle;
        IWebElement themeCheckConclusion;
        /*Translate*/
        IWebElement translationTitle;
        IWebElement translationCheckConclusion;
        /*Thanks and version*/
        IWebElement thanksText;
        IWebElement wordPressLink;
        IWebElement version;
        public UpdatesPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            title = driver.FindElement(By.XPath("//*[@id=\"wpbody-content\"]/div[3]/h1"));
            lastcheckText = driver.FindElement(By.XPath("//*[@id=\"wpbody-content\"]/div[3]/p[1]"));
            checkButton = driver.FindElement(By.XPath("//*[@id=\"wpbody-content\"]/div[3]/p[1]/a"));
            text3 = driver.FindElement(By.XPath("//*[@id=\"wpbody-content\"]/div[3]/ul/li/p"));
            checkConclusionText = driver.FindElement(By.XPath("//*[@id=\"wpbody-content\"]/div[3]/h2[1]"));
            //aboutButton = driver.FindElement(By.XPath("//*[@id=\"wpbody-content\"]/div[3]/p[2]/a"));
            //hideShow = driver.FindElement(By.Id("show-dismissed"));
            text4 = driver.FindElement(By.XPath("//*[@id=\"wpbody-content\"]/div[3]/ul/li/form/p[2]"));
            pluginsText = driver.FindElement(By.XPath("//*[@id=\"wpbody-content\"]/div[3]/h2[2]"));
            availablePluginsText = driver.FindElement(By.XPath("//*[@id=\"wpbody-content\"]/div[3]/p[2]"));
            themeTitle = driver.FindElement(By.XPath("//*[@id=\"wpbody-content\"]/div[3]/h2[3]"));
            themeCheckConclusion = driver.FindElement(By.XPath("//*[@id=\"wpbody-content\"]/div[3]/p[3]"));
            translationTitle = driver.FindElement(By.XPath("//*[@id=\"wpbody-content\"]/div[3]/h2[4]"));
            translationCheckConclusion = driver.FindElement(By.XPath("//*[@id=\"wpbody-content\"]/div[3]/p[4]"));
            thanksText = driver.FindElement(By.Id("footer-thankyou"));
            wordPressLink = driver.FindElement(By.XPath("//*[@id=\"footer-thankyou\"]/a"));
            version = driver.FindElement(By.Id("footer-upgrade"));
        }
        public UpdatesPage CheckUpdates()
        {
            checkButton.Click();
            return this;
        }
        public UpdatesPage hideOrShoW()
        {
            Visible v1 = new Visible(driver);
            v1.IsVisibleHideButton();
            v1.ReinstallUpdates();
            Hiden h1 = new Hiden(driver);
            h1.IsVisibleHideButton();
            h1.AboutButton();
            h1.Opened();
            h1.Undo();
            return this;

        }
        public UpdatesPage WordPressLink()
        {
            wordPressLink.Click();
            return this;
        }
    }
}
