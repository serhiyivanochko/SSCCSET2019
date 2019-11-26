using NUnit.Framework;
using OpenQA.Selenium;
using System;
using SSCCSET2019.Pages;
using OpenQA.Selenium.Chrome;
using SSCCSET2019.Logic;
using SSCCSET2019.Tools;

namespace SSCCSET2019.Tests.Test
{
    [TestFixture()]
    public class Test
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = Driver.GetDriver();
        }

        [Test]
        public void TestCase()
        {
            driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/post-new.php");
            IWebElement login = driver.FindElement(By.Id("user_login"));
            IWebElement password = driver.FindElement(By.Id("user_pass"));
            login.SendKeys("Ruslana");
            password.SendKeys("wordpresswordpress");
            IWebElement submitBtn = driver.FindElement(By.Id("wp-submit"));
            submitBtn.Click();

            AddNewPostWithSettingsLogic logic = new AddNewPostWithSettingsLogic();
            logic.OpenCategoriesBlock();
            logic.OpenTagsBlock();
            logic.OpenFeaturedImageBlock();
            logic.OpenExcerptBlock();
            logic.OpenDiscussionBlock();
        }

        [TearDown]
        public void Close()
        {
            Driver.GetDriver().Close();
        }

    }
    
}
