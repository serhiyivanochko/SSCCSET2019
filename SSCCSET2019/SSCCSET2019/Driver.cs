using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;

namespace SSCCSET2019
{
    class Driver
    {
        private static IWebDriver driver;
        private Driver() { }

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                if (Constants.BrowserName.ToLower().Equals("chrome"))
                {
                    driver = new ChromeDriver();
                }
                else if (Constants.BrowserName.ToLower().Equals("firefox"))
                {
                    driver = new FirefoxDriver();
                }
                else if(Constants.BrowserName.ToLower().Equals("internet_explorer"))
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