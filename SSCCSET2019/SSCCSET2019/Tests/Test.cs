using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using SSCCSET2019.Pages.Tags;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Data.ApplicationSource;


namespace SSCCSET2019.Tests.Test
{
    [TestFixture()]
    class Test
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ApplicationSource.SetBrowser("Firefox");
            driver = Driver.GetDriver();
        }
        [Test]
        public void TestCase()
        {
            driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/edit-tags.php?taxonomy=post_tag");
            var login = driver.FindElement(By.Id("user_login"));
            var password = driver.FindElement(By.Id("user_pass"));
            login.SendKeys("Nazariy");
            password.SendKeys("wordpresswordpess");
            var submit = driver.FindElement(By.Id("wp-submit"));
            submit.Click();

            Tags tagsPage = new Tags(driver);

        }
        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}
