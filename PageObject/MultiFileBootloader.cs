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
        IWebElement _drag_drop_area;
        IWebElement _drag_drop_info;
        IWebElement _else;
        IWebElement _plupload_browse_button;
        IWebElement _flash_bypass;
        IWebElement _url_browser_loader;
        public MultiFileBootloader()
        {
            driver = new FirefoxDriver();
            _drag_drop_area = driver.FindElement(By.Id("drag_drop_area"));
            _drag_drop_info = driver.FindElement(By.ClassName("drag-drop-info"));
            _else = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[3]/form/div[3]/div[1]/div/p[2]"));
            _plupload_browse_button = driver.FindElement(By.Id("plupload-browse-button"));
            _flash_bypass = driver.FindElement(By.ClassName("upload-flash-bypass"));
            _url_browser_loader = driver.FindElement(By.LinkText("загрузчик браузера"));
        }
        public MultiFileBootloader ClickOnThePluploadBrowseBut()
        { 
            _plupload_browse_button.Click();
            return this;
        }
        public string ClickOnTheLinkBrowserLoader()
        {
            _url_browser_loader.Click();
            return "http://localhost/wordpress-abc/wp-admin/media-new.php?browser-uploader";
        }
    }
}
