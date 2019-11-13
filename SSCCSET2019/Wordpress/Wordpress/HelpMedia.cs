using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Wordpress
{
    class HelpMedia
    {
        IWebDriver driver;

        IWebElement _overview;

        IWebElement _tab_panel;

        IWebElement _info;
        IWebElement _document_download_mediafile;
        IWebElement _forum_suport;
        public HelpMedia()
        {
            _overview = driver.FindElement(By.CssSelector("#tab-link-overview > a:nth-child(1)"));

            _tab_panel = driver.FindElement(By.Id("tab-panel-overview"));

            _info = driver.FindElement(By.CssSelector(".contextual-help-sidebar > p:nth-child(1) > strong:nth-child(1)"));
            _document_download_mediafile = driver.FindElement(By.CssSelector(".contextual-help-sidebar > p:nth-child(2) > a:nth-child(1)"));
            _forum_suport = driver.FindElement(By.CssSelector(".contextual-help-sidebar > p:nth-child(3) > a:nth-child(1)"));
        }
    }
}
