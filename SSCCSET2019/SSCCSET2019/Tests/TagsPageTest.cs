using NUnit.Framework;
using OpenQA.Selenium;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Logic;
using SSCCSET2019.Logic.LoginPageLogic;

namespace SSCCSET2019.Tests
{
    [TestFixture()]
    class TagsPageTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.GetDriver().Navigate().GoToUrl("http://localhost/wordpress/wp-admin/edit-tags.php?taxonomy=post_tag");
            new LoginPageLogic().LogInWordPress("Nazariy", "wordpresswordpess");
        }
     
        [Test]
        public void TestAddNewTagsWithSlugAndDescription()
        {
            TagsPageLogic tagsPage = new TagsPageLogic();
            string tagName = "1Test Tag";
            string tagSlug = "Test Slug";
            string tagDescription = "Test Description";
            tagsPage.AddNewTagsWithSlugAndDescription(tagName, tagSlug, tagDescription);
            Assert.AreEqual(tagsPage.GetLastNameTag(), tagName);
            Assert.AreEqual(tagsPage.GetLastSlugText(), tagSlug);
            Assert.AreEqual(tagsPage.GetLastDescriptionText(), tagDescription);
        }

        [Test]
        public void TestAddNewTagsWithSlug()
        {
            TagsPageLogic tagsPage = new TagsPageLogic();
            string tagName = "Test Tag";
            string tagSlug = "Test Slug";
            tagsPage.AddNewTagsWithSlug(tagName, tagSlug);
            Assert.AreEqual(tagsPage.GetLastNameTag(), tagName);
            Assert.AreEqual(tagsPage.GetLastSlugText(), tagSlug);
        }

        [Test]
        public void TestIfFoundedTags()
        {
            TagsPageLogic tagsPage = new TagsPageLogic();
            string tagName = "Test Tag";
            string tagSlug = "Test Slug";
            tagsPage.AddNewTagsWithSlug(tagName, tagSlug);
            bool temp = tagsPage.IfFoundedTags(tagName);
            Assert.AreEqual(temp, true);
        }

        [Test]
        public void TestNumberOfTags()
        {
            TagsPageLogic tagsPage = new TagsPageLogic();
            string tagName = "Test Tag";
            string tagSlug = "Test Slug";
            tagsPage.AddNewTagsWithSlug(tagName, tagSlug);
            Assert.AreEqual(tagsPage.NumberOfTags(), 1);
        }
        [TearDown]
        public void Close()
        {
          //  Driver.GetDriver().Close();
        }
    }
}
