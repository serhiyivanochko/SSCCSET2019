using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCCSET2019.Pages
{
    class Visible
    {
        public bool isVisibleHidebutton = false;
        IWebDriver driver;
        IWebElement redownloadButton;
        IWebElement hideButton;
        public Visible(IWebDriver webDriver)
        {
            this.driver = webDriver;
            redownloadButton = driver.FindElement(By.Id("upgrade"));
            hideButton = driver.FindElement(By.Id("dismiss"));
        }
        public Visible IsVisibleHideButton()
        {
            if(hideButton != null)
            {
                isVisibleHidebutton = true;
            }
            else
            {
                isVisibleHidebutton = false;
            }
            return this;
        }
        public Visible ReinstallUpdates()
        {
            if (isVisibleHidebutton)
            {
                redownloadButton.Click();
                return this;
            }
            else
            {
                return null;
            }
        }

    }
}
