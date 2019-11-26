using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SSCCSET2019.Logic;
using SSCCSET2019.Pages;
using System;
using System.Threading;

namespace SSCCSET2019
{
    [TestFixture]
    public class Test
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            //Як краще ? 
            MainPage.Driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/");
            MainPage.Driver.FindElement(By.Id("user_login")).Click();
            MainPage.Driver.FindElement(By.Id("user_login")).Clear();
            MainPage.Driver.FindElement(By.Id("user_login")).SendKeys("vlodkomickovich@gmail.com");
            MainPage.Driver.FindElement(By.Id("user_pass")).Click();
            MainPage.Driver.FindElement(By.Id("user_pass")).Clear();
            MainPage.Driver.FindElement(By.Id("user_pass")).SendKeys("vlodko27");
            MainPage.Driver.FindElement(By.Id("wp-submit")).Click();
        }
        /*
        [OneTimeTearDown]
        public void CloseBrowser()
        {
           MainPage.Driver.Quit();
        }*/
        [Test]
        public void TestHeaderOfMainPage()
        {
            MainPageLogic mpl = new MainPageLogic();

            mpl.write_to_inputTown_in_news("Lviv");
        }

        /*
        [Test]
        public void TestQuickDrafts()
        {
            MainPageLogic mpl = new MainPageLogic();
            MainPage mp = new MainPage();
            MainPage.Driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/");

            mpl.login();
            mpl.write_to_input_headline_in_quickDrafts("Headline");
            mpl.write_to_input_content_in_quickDrafts("Some contents");
            mp.Button_save();//Виклик атомарної операції в тесті (Як правильно ?)
        }
        [Test]
        public void TestLinkInBlockNewsOnMainPage()
        {
            MainPageLogic mpl = new MainPageLogic();
            MainPage.Driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/");
            mpl.login();

            mpl.ClickLinksInBlockNews();
            mpl.write_to_inputTown_in_news("TownName");

        }*/
    }
}
