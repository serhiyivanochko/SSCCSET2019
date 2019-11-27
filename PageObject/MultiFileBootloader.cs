using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Wordpress
{
    class MultiFileBootloader
    {
        IWebDriver driver;
        IWebElement _download_new_media;
        IWebElement _helper_link;
        IWebElement _drag_drop_area;
        IWebElement _drag_drop_info;
        IWebElement _else;
        IWebElement _plupload_browse_button;
        IWebElement _flash_bypass;
        IWebElement _url_browser_loader;
        IWebElement _max_size;
        IWebElement _thankyou;
        IWebElement _url_wordpress;
        IWebElement _version;
        public MultiFileBootloader()
        {
            driver = new FirefoxDriver();
            _download_new_media = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[3]/h1"));
            _helper_link = driver.FindElement(By.Id("contextual-help-link"));
            _drag_drop_area = driver.FindElement(By.Id("drag_drop_area"));
            _drag_drop_info = driver.FindElement(By.ClassName("drag-drop-info"));
            _else = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[3]/form/div[3]/div[1]/div/p[2]"));
            _plupload_browse_button = driver.FindElement(By.Id("plupload-browse-button"));
            _flash_bypass = driver.FindElement(By.ClassName("upload-flash-bypass"));
            _url_browser_loader = driver.FindElement(By.LinkText("загрузчик браузера"));
            _max_size = driver.FindElement(By.ClassName("max-upload-size"));
            _thankyou = driver.FindElement(By.Id("WordPress"));
            _url_wordpress = driver.FindElement(By.CssSelector("#footer-thankyou > a:nth-child(1)"));
            _version = driver.FindElement(By.Id("footer-upgrade"));
        }
        public MultiFileBootloader ClicOnTheButHelpLink()
        {
            _helper_link.Click();
            return this;
        }
        public MultiFileBootloader ClickOnThePluploadBrowseBut()
        { 
            _plupload_browse_button.Click();
            return this;
        }
        public MultiFileBootloader ClickOnTheLinkBrowserLoader()
        {
            string url = "http://localhost/wordpress-abc/wp-admin/media-new.php?browser-uploader";
            _url_browser_loader.Click();
            return url;
        }
        public MultiFileBootloader ClickOnTheLinkWordpress()
        {
            _url_wordpress.Click();
            return this;
        }
    }
}
