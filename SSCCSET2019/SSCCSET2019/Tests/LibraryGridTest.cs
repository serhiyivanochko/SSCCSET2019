using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Logic;

namespace LibraryGridTest
{
    [TestFixture]
    public class Tests
    {
        LibraryGridLogic library;
        const string URL = "http://localhost/wordpress/wp-admin/upload.php";

        [OneTimeSetUp]
        public void Init()
        {
            IWebDriver driver = Driver.GetDriver();
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
            library.DeleteItem(0, "accept");
            Driver.GetDriver().Quit();
        }

        [SetUp]
        public void SetUp()
        {
            IWebDriver driver = Driver.GetDriver();
            driver.Url = URL;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        }

        [TestCase("sorted.txt")]
        public void TestAddNewFile(string namefile)
        {
            string actual = library.AddNewItem(namefile);

            string  expected = "sorted.txt";
            Assert.AreEqual(expected, actual);
        }

        [TestCase("sort")]
        public void TestTextFieldSearch(string input)
        {
            List<string> actual = library.SearchElementByText(input);

            List<string> expected = new List<string>() {"sorted"};
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, "accept")]
        public void TestDeleteItem(int index, string accept)
        {
            string actual = library.DeleteItem(index, accept)
                .GetCurrentItems();
            
            string expected = "sorted.txt";
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Mine", "sorted.txt")]
        public void TestGetElementsFilterdByType(string type, string namefile)
        {
            library.AddNewItem(namefile);
            int actual = library.GetElementsFilteredByType(type);

            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestCase("November 2019")]
        public void TestGetElementsFilteredByData(string date)
        {
            int actual = library.GetElementsFilteredByData(date);

            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Mine", "November 2019")]
        public void TestGetElementsFilteredByTypeAndData(string type, string date)
        {
            library.GetElementsFilteredByType(type);
            int actual = library.GetElementsFilteredByData(date);

            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}