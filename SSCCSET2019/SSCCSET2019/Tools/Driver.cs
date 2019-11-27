using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using SSCCSET2019.Data.ApplicationSource;

namespace SSCCSET2019.Tools
{
    class Driver
    {
        private static IWebDriver driver;
        private Driver() { }
        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                if (ApplicationSource.GetBrowserName().ToLower().Equals("chrome"))
                {
                    driver = new ChromeDriver();
                }
                else if (ApplicationSource.GetBrowserName().ToLower().Equals("firefox"))
                {
                    driver = new FirefoxDriver();
                }
                else if(ApplicationSource.GetBrowserName().ToLower().Equals("internetexplorer"))
                {
                    driver = new InternetExplorerDriver();
                }
                else
                {
                    throw new Exception("Browser is invalid");
                }
            }
            return driver;
        }
        public void Quit()
        {
            driver.Quit();
            driver = null;
        }
        public void Close()
        {
            driver.Close();
            driver = null;
        }
    }
}