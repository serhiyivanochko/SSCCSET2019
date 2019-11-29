using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Wordpress
{
    class PageMediaFile
    {
        private bool browserUploader = false;
        private bool multifileBootloader = true;
        IWebDriver driver;
        IWebElement _download_new_media;
        IWebElement _helper_link;
        IWebElement _max_size;
        IWebElement _thankyou;
        IWebElement _url_wordpress;
        IWebElement _version;
        IWebElement _url_browser_loader;
        IWebElement _multi_file_bootloader;
        public PageMediaFile()
        {
            driver = new FirefoxDriver();
            _download_new_media = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[3]/h1"));
            _helper_link = driver.FindElement(By.Id("contextual-help-link"));
            _max_size = driver.FindElement(By.ClassName("max-upload-size"));
            _thankyou = driver.FindElement(By.Id("WordPress"));
            _url_wordpress = driver.FindElement(By.CssSelector("#footer-thankyou > a:nth-child(1)"));
            _version = driver.FindElement(By.Id("footer-upgrade"));
            _url_browser_loader = driver.FindElement(By.LinkText("загрузчик браузера"));
            _multi_file_bootloader = driver.FindElement(By.LinkText("Переключиться на многофайловый загрузчик"));
        }
        public PageMediaFile ClicOnTheButUrlBrowserLoader()
        {
            if (browserUploader == false && multifileBootloader == true)
            {
                _url_browser_loader.Click();
                new BrowserUploader();
            }
            if (browserUploader == true && multifileBootloader == false)
            {
                _multi_file_bootloader.Click();
                new MultiFileBootloader();
            }
            browserUploader = !browserUploader;
            multifileBootloader = !multifileBootloader;
            return this;
        }
        public PageMediaFile ClicOnTheButHelpLink()
        {
            _helper_link.Click();
            return this;
        }
        public string ClickOnTheLinkWordpress()
        {
            _url_wordpress.Click();
            return "https://ru.wordpress.org/";
        }
    }
}
