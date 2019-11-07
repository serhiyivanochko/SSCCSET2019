using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace SSCCSET2019
{
    [TestFixture()]
    public class Test
    {
        IWebDriver driver;

        [SetUp]
        public void BrowserStart()
        {
            driver = new FirefoxDriver();
        }

        [Test()]
        public void TestCase1()
        {
            driver.Url = "http://localhost/wordpress/wp-admin/edit.php";
            IWebElement user_login = driver.FindElement(By.Id("user_login"));
            user_login.SendKeys("nastia-peleshok");
            IWebElement user_password = driver.FindElement(By.Id("user_pass"));
            user_password.SendKeys("natailina2001");
            IWebElement log_in = driver.FindElement(By.Id("wp-submit"));
            log_in.Click();
            ////driver.Url = "http://localhost/wordpress/wp-admin/edit.php";
            IWebElement add_el = driver.FindElement(By.XPath("//html/body/div[1]/div[1]/div[2]/ul/li[3]/ul/li[3]/a"));
            add_el.Click();
        }


    }
}
