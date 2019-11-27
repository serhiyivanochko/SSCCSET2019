using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Wordpress
{
    class BrowserUploader
    {
        IWebDriver driver;
        IWebElement _download_new_media;
        IWebElement _helper_link;
        IWebElement _thankyou;
        IWebElement _url_wordpress;
        IWebElement _version;
        IWebElement _max_size;
        IWebElement _multi_file_bootloader;
        IWebElement _review;
        IWebElement _upload;
        public BrowserUploader()
        {
            driver = new FirefoxDriver();
            _download_new_media = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[3]/h1"));
            _helper_link = driver.FindElement(By.Id("contextual-help-link"));
            _thankyou = driver.FindElement(By.Id("WordPress"));
            _url_wordpress = driver.FindElement(By.CssSelector("#footer-thankyou > a:nth-child(1)"));
            _version = driver.FindElement(By.Id("footer-upgrade"));
            _max_size = driver.FindElement(By.ClassName("max-upload-size"));
            _multi_file_bootloader.FindElement(By.LinkText("Переключиться на многофайловый загрузчик"));
            _review.FindElement(By.Id("async-upload"));
            _upload.FindElements(By.Id("html-upload"));
        }
        public BrowserUploader ClicOnTheButHelpLink()
        {
            _helper_link.Click();
            return this;
        }
        public BrowserUploader ClickOnTheLinkWordpress()
        {
            _url_wordpress.Click();
            return this;
        }
        public BrowserUploader ClickOnTheLinkMultiFileBootloader()
        {
            _multi_file_bootloader.Click();
            return this;
        }
        public BrowserUploader ClickOnTheButReview()
        {
            _review.Click();
            return this;
        }
        public BrowserUploader ClicOnTheButUpload()
        {
            _upload.Click();
            return this;
        }
    }
}
