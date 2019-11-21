using NUnit.Framework;
using OpenQA.Selenium;
using System;
namespace SSCCSET2019
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestCase()
        {
            MainPage.Driver.Navigate.GoToUrl("https://www.google.com.ua/");

        }
    }
}
