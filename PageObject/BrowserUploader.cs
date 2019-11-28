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
        IWebElement _multi_file_bootloader;
        IWebElement _review;
        IWebElement _upload;
        public BrowserUploader()
        {
            driver = new FirefoxDriver();
            _multi_file_bootloader = driver.FindElement(By.LinkText("Переключиться на многофайловый загрузчик"));
            _review = driver.FindElement(By.Id("async-upload"));
            _upload = driver.FindElement(By.Id("html-upload"));
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
