using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCCSET2019.Pages
{
    class Hiden
    {
        public bool isVisibleHideShoW = false;
        public bool isOpened = false;
        IWebDriver driver; 
        IWebElement aboutButton;
        IWebElement hideShow;
        IWebElement redownloadButton;
        IWebElement undo;
        public Hiden(IWebDriver webDriver)
        {
            this.driver = webDriver;
            hideShow = driver.FindElement(By.Id("show-dismissed"));
        }
        public Hiden IsVisibleHideButton()
        {
            if(hideShow != null)
            {
                isVisibleHideShoW = true;
            }
            else
            {
                isVisibleHideShoW = false;
            }
            return this;
        }
        public Hiden AboutButton()
        {
            if (isVisibleHideShoW)
            {
                aboutButton = driver.FindElement(By.Id("show-dismissed"));
                aboutButton.Click();
                return this;  //"http://localhost/wp1/wp-admin/about.php"
            }
            else
            {
                return null;
            }
        }
        public Hiden Opened()
        {
            if (isVisibleHideShoW)
            {
                if (hideShow.GetAttribute("aria-expanded") == "true")
                {
                    isOpened = false;
                }
                else
                {
                    isOpened = true;
                }
                return this;
            }
            else
            {
                return null;
            }
        }
        public Hiden Undo()
        {
            if (isOpened)
            {
                redownloadButton = driver.FindElement(By.Id("upgrade"));
                undo = driver.FindElement(By.Id("undismiss"));
                undo.Click();
                return this;
            }
            else
            {
                return null;
            }
        }
    }
}