using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SSCCSET2019.Pages
{
    class UpdatePluginsElements
    {

        IWebDriver driver;
        /*Plagins*/
        IWebElement updatePluginsButton;
        IWebElement pluginsSelectAllButton;
        IWebElement untiSpamPluginButton;
        IWebElement detailLink;
        IWebElement updatePlugins2Button;
        private bool isVisiblePlugins = false;
        public UpdatePluginsElements(IWebDriver webDriver)
        {
            this.driver = webDriver;
            updatePluginsButton = driver.FindElement(By.Id("upgrade-plugins"));
            pluginsSelectAllButton = driver.FindElement(By.Id("plugins-select-all"));
            untiSpamPluginButton = driver.FindElement(By.Id("checkbox_b2a77cb7afefcfe24ee09da469450cf3"));
            detailLink = driver.FindElement(By.XPath("//*[@id=\"update-plugins-table\"]/tbody/tr/td[2]/p/a"));
            updatePlugins2Button = driver.FindElement(By.Id("upgrade-plugins-2"));
        }
        public UpdatePluginsElements IfUpdateAvailable()
        {
            if (pluginsSelectAllButton == null)
            {
                isVisiblePlugins = false;
            }
            else
            {
                isVisiblePlugins = true;
            }
            return this;
        }
        public UpdatePluginsElements Update()
        {
            if (isVisiblePlugins)
            {
                pluginsSelectAllButton.Click();
                updatePluginsButton.Click();
                return this;
            }
            else
            {
                return null;
            }
        }
    }
}
