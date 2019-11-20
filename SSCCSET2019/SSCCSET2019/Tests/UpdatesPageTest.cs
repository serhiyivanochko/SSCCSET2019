using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Data.ApplicationSource;
using SSCCSET2019.Pages;

namespace SSCCSET2019.Tests
{
    [TestFixture]
    class UpdatesPageTest
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            ApplicationSource.SetBrowser("chrome");
            driver = Driver.GetDriver();
        }
        [Test]
        public void Test()
        {
            driver.Navigate().GoToUrl("http://localhost/wp1/wp-admin/update-core.php");
            LogIn();
            UpdatesPage updatesPage = new UpdatesPage(driver);

        }
        public void LogIn()
        {
            driver.FindElement(By.Id("user_login")).Click();
            driver.FindElement(By.Id("user_login")).Clear();
            driver.FindElement(By.Id("user_login")).SendKeys("oleh619");
            driver.FindElement(By.Id("user_pass")).Click();
            driver.FindElement(By.Id("user_pass")).Clear();
            driver.FindElement(By.Id("user_pass")).SendKeys("olehinwordpress");
            driver.FindElement(By.Id("wp-submit")).Click();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
