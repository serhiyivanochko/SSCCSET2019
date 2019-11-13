using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCCSET2019.Pages
{
    class UpdatesPage
    {
        IWebDriver driver;
        IWebElement title;
        IWebElement lastcheckText;
        IWebElement checkButton;
        IWebElement checkConclusionText;
        IWebElement text3;
        IWebElement redownloadButton;
        IWebElement hideButton;
        IWebElement text4;
        /*Plagins*/
        IWebElement pluginsText;
        IWebElement availablePluginsText;
        IWebElement updatePluginsButton;
        IWebElement pluginsSelectAllButton;
        IWebElement untiSpamPluginButton;
        IWebElement detailLink;
        IWebElement updatePlugins2Button;
        /*Theme*/
        IWebElement themeTitle;
        IWebElement themeCheckConclusion;
        /*Translate*/
        IWebElement translationTitle;
        IWebElement translationCheckConclusion;
        /*Help*/
        IWebElement helpButton;
        IWebElement overviewHelp;
        IWebElement overviewTextHelp;
        IWebElement howToUpdateHelp;
        IWebElement howToUpdateTextHelp;
        IWebElement documentationHelp;
        IWebElement forumHelp;
        /*Thanks and version*/
        IWebElement thanksText;
        IWebElement wordPressLink;
        IWebElement version;
        public UpdatesPage()
        {
            title = driver.FindElement(By.XPath("//*[@id=\"wpbody - content\"]/div[3]/h1"));
            lastcheckText = driver.FindElement(By.XPath("//*[@id=\"wpbody - content\"]/div[3]/p[1]/text()"));
            checkButton = driver.FindElement(By.XPath("//*[@id=\"wpbody - content\"]/div[3]/p[1]/a"));
            text3 = driver.FindElement(By.XPath("//*[@id=\"wpbody - content\"]/div[3]/ul/li/p"));
            checkConclusionText = driver.FindElement(By.XPath("//*[@id=\"wpbody - content\"]/div[3]/h2[1]/text()"));
            redownloadButton = driver.FindElement(By.Id("upgrade"));
            hideButton = driver.FindElement(By.Id("dismiss"));
            text4 = driver.FindElement(By.XPath("//*[@id=\"wpbody - content\"]/div[3]/ul/li/form/p[2]/text()"));
            pluginsText = driver.FindElement(By.XPath("//*[@id=\"wpbody - content\"]/div[3]/h2[2]"));
            availablePluginsText = driver.FindElement(By.XPath("//*[@id=\"wpbody - content\"]/div[3]/p[2]/text()"));
            updatePluginsButton = driver.FindElement(By.Id("upgrade - plugins"));
            pluginsSelectAllButton = driver.FindElement(By.Id("plugins-select-all"));
            untiSpamPluginButton = driver.FindElement(By.Id("checkbox_b2a77cb7afefcfe24ee09da469450cf3"));
            detailLink = driver.FindElement(By.XPath("//*[@id=\"update - plugins - table\"]/tbody/tr/td[2]/p/a"));
            updatePlugins2Button = driver.FindElement(By.Id("upgrade-plugins-2"));
            themeTitle = driver.FindElement(By.XPath("//*[@id=\"wpbody - content\"]/div[3]/h2[3]"));
            themeCheckConclusion = driver.FindElement(By.XPath("//*[@id=\"wpbody - content\"]/div[3]/p[3]"));
            translationTitle = driver.FindElement(By.XPath("//*[@id=\"wpbody - content\"]/div[3]/h2[4]"));
            translationCheckConclusion = driver.FindElement(By.XPath("//*[@id=\"wpbody - content\"]/div[3]/p[4]"));
            helpButton = driver.FindElement(By.Id("contextual-help-link"));
            overviewHelp = driver.FindElement(By.XPath("//*[@id=\"tab - link - overview\"]/a"));
            overviewTextHelp = driver.FindElement(By.Id("tab-link-overview"));
            howToUpdateHelp = driver.FindElement(By.XPath("//*[@id=\"tab - link - how - to - update\"]/a"));
            howToUpdateTextHelp = driver.FindElement(By.Id("tab-link-how-to-update"));
            documentationHelp = driver.FindElement(By.XPath("//*[@id=\"contextual - help - columns\"]/div[2]/p[2]/a"));
            forumHelp = driver.FindElement(By.XPath("//*[@id=\"contextual - help - columns\"]/div[2]/p[3]/a"));
            thanksText = driver.FindElement(By.Id("footer-thankyou"));
            wordPressLink = driver.FindElement(By.XPath("//*[@id=\"footer - thankyou\"]/a"));
            version = driver.FindElement(By.Id("footer-upgrade"));
        }
        public void checkUpdates()
        {
            checkButton.Click();
        }
        public void reinstallUpdates()
        {
            redownloadButton.Click();
        }
        public void hideUpdates()
        {
            hideButton.Click();
        }
        public void updatePlagins()
        {
            updatePluginsButton.Click();
        }
        public void selectAllPlugins()
        {
            pluginsSelectAllButton.Click();
        }
        public void untiSpamSelect()
        {
            untiSpamPluginButton.Click();
        }
        public void help()
        {
            helpButton.Click();
        }
    }
}
