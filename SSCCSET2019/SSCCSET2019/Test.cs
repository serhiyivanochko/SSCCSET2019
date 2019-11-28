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
        [SetUp]
        public void SetUp()
        {
            MainPage.Driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/");
            MainPage.Driver.FindElement(By.Id("user_login")).Click();
            MainPage.Driver.FindElement(By.Id("user_login")).Clear();
            MainPage.Driver.FindElement(By.Id("user_login")).SendKeys("vlodkomickovich@gmail.com");
            MainPage.Driver.FindElement(By.Id("user_pass")).Click();
            MainPage.Driver.FindElement(By.Id("user_pass")).Clear();
            MainPage.Driver.FindElement(By.Id("user_pass")).SendKeys("vlodko27");
            MainPage.Driver.FindElement(By.Id("wp-submit")).Click();
        }
       
        [TearDown]
        public void TearDown()
        {
            MainPage.Driver.Close();
        }
        [Test]
        public void TestBlockNews()
        {
            MainPageLogic mpl = new MainPageLogic();
            mpl.ClickLinksInBlockNews();
        }
        [Test]
        public void TestHeader()
        {
            MainPageLogic mpl = new MainPageLogic();
            mpl.ClickingHeaderMainPage();
        }
        /*
        [Test]
        public void TestQuickDrafts()
        {
            MainPageLogic mpl = new MainPageLogic();

            mpl.write_to_input_headline_in_quickDrafts("Headline");
            mpl.write_to_input_content_in_quickDrafts("Some contents");
            mpl.click_on_button_save_in_quick_drafts();
        }
        [Test]
        public void Write_to_inputTown_in_news() //Fail alltime
        {
            MainPageLogic mpl = new MainPageLogic();

            mpl.write_to_inputTown_in_news("TownName");
            mpl.click_button_send_inNews();
        }
        */
    }
}
