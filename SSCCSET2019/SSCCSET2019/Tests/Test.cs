using NUnit.Framework;
using OpenQA.Selenium;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Logic.TagsPageLogic;
using System.Threading;

namespace SSCCSET2019.Tests.Test
{
    [TestFixture()]
    class Test
    {
        [SetUp]
        public void Setup()
        {
            IWebDriver driver = Driver.GetDriver();
            driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/edit-tags.php?taxonomy=post_tag");
            var login = driver.FindElement(By.Id("user_login"));
            var password = driver.FindElement(By.Id("user_pass"));
            login.SendKeys("Nazariy");
            password.SendKeys("wordpresswordpess");
            var submit = driver.FindElement(By.Id("wp-submit"));
            submit.Click();
        }
        [Test]
        public void TestCase()
        {
            TagsPageLogic tagsPage = new TagsPageLogic();
            string tagName = "Test Tag";
            string tagSlug = "Test Slug";
            string tagDescription = "Test Description";
            tagsPage.AddNewTagsWithSlugAndDescription(tagName, tagSlug, tagDescription);
            Thread.Sleep(5000);
            Assert.AreEqual(tagsPage.GetNameTag(), tagName);
           
        }
        [TearDown]
        public void Close()
        {
            // driver.Close();
        }
    }
}
