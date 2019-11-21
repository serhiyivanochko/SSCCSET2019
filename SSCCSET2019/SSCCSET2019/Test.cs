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
            MainPageLogic mpl = new MainPageLogic();
            MainPage.Driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/");

            mpl.login();//Валідні дані одразу в логіці

        }
    }
}
