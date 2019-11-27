using NUnit.Framework;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Logic;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace LibraryGridTest
{
    [TestFixture]
    public class Tests
    {
        static IWebDriver driver;
        LibraryGridLogic library;
        const string URL = "http://localhost/wordpress/wp-admin/upload.php";

        [OneTimeSetUp]
        public void Init()
        {
            driver = Driver.GetDriver();
            driver.Manage().Window.Maximize();
            driver.Url = URL;

            driver.FindElement(By.Id("user_login")).Click();
            driver.FindElement(By.Id("user_login")).Clear();
            driver.FindElement(By.Id("user_login")).SendKeys("s3r3n1ty");
            driver.FindElement(By.Id("user_pass")).Click();
            driver.FindElement(By.Id("user_pass")).Clear();
            driver.FindElement(By.Id("user_pass")).SendKeys("s3r3n1ty");
            driver.FindElement(By.Id("wp-submit")).Click();

            library = new LibraryGridLogic();
            
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            Driver.GetDriver().Quit();
        }

        [SetUp]
        public void SetUp()
        {
            driver.Url = URL;
            
        }
        //[TearDown]
        //public void AfterEachTest()
        //{
        //    driver.Manage().Cookies.DeleteAllCookies();
        //}

        [TestCase("sorted.txt")]
        public void TestAddNewFile(string namefile)
        {
            string actual = library.AddNewItem(namefile);

            string  expected = "sorted.txt";
            Assert.AreEqual(expected, actual);
        }

        [TestCase("DirectoryC")]
        public void TestTextFieldSearch(string input)
        {
            List<string> actual = library.SearchElementByText(input);

            List<string> expected = new List<string>() {};
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, "accept")]
        public void TestDeleteItem(int index, string accept)
        {
            int actual = library.DeleteItem(index, accept);

            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
        [TestCase("Mine")]
        public void TestGetElementsFilterdByType(string type)
        {
            int actual = library.GetElementsFilteredByType(type);

            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}