using NUnit.Framework;
using OpenQA.Selenium;
using SSCCSET2019.Logic;
using SSCCSET2019.Pages;
using System;
namespace SSCCSET2019
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestHeaderOfMainPage()
        {
            MainPageLogic mpl = new MainPageLogic();
            MainPage.Driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/");

            mpl.login();//Валідні дані зразу передаються в логіці
            //mpl.ClickingHeaderMainPage();
        }
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

        }
    }
}
