using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SSCCSET2019
{
    class Driver
    {
        private static IWebDriver instance;
        private Driver() { }

        public static IWebDriver GetDriver()
        {
            if (instance != null)
            {
                instance = new ChromeDriver();
            }
            return instance;

        }
    }
}