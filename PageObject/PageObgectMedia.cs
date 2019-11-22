using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Wordpress
{
    class PageObgectMedia
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
        public PageObgectMedia()
        {
            driver = new FirefoxDriver();
            //Верхня частина сторінки
            _download_new_media = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[3]/h1"));
            _helper_link = driver.FindElement(By.Id("contextual-help-link"));
            //Поле для загрузки медіафайлів
            _drag_drop_area = driver.FindElement(By.Id("drag_drop_area"));
            _drag_drop_info = driver.FindElement(By.ClassName("drag-drop-info"));
            _else = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[3]/form/div[3]/div[1]/div/p[2]"));
            _plupload_browse_button = driver.FindElement(By.Id("plupload-browse-button"));
            //Інформація який повинен бути файл
            _flash_bypass = driver.FindElement(By.ClassName("upload-flash-bypass"));
            _url_browser_loader = driver.FindElement(By.CssSelector(".upload-flash-bypass > a:nth-child(1)"));
            _max_size = driver.FindElement(By.ClassName("max-upload-size"));
            //Нижня частина сторінки
            _thankyou = driver.FindElement(By.Id("footer-thankyou"));
            _url_wordpress = driver.FindElement(By.CssSelector("#footer-thankyou > a:nth-child(1)"));
            _version = driver.FindElement(By.Id("footer-upgrade"));
        }

        public void ClicOnTheButHelpLink()
        {

            _helper_link.Click();
        }

        public PageObgectMedia ClickOnThePluploadBrowseBut()
        { 
            _plupload_browse_button.Click();
            return this;
        }

        public void ClickOnTheLinkBrowserLoader()
        {
            _url_browser_loader.Click();
        }

        public void ClickOnTheLinkWordpress()
        {
            _url_wordpress.Click();
        }
    }
}
