using System;
using System.Collections.Generic;
using System.Threading;
using SSCCSET2019.Pages;


namespace SSCCSET2019.Logic
{
    class MainPageLogic
    {

        public MainPage mainPage = new MainPage();

        public void ClickingHeaderMainPage()
        {
            Thread.Sleep(3000);

            mainPage.button_settings_Click();
            Thread.Sleep(3000);
            MainPage.Driver.Navigate().Back();
            mainPage = new MainPage();

            mainPage.clickOn_Link_theme();
            Thread.Sleep(3000);
            MainPage.Driver.Navigate().Back();
            mainPage = new MainPage();

            mainPage.Link_firstRecord();
            Thread.Sleep(3000);
            MainPage.Driver.Navigate().Back();
            mainPage = new MainPage();

            mainPage.Link_createPage();
            Thread.Sleep(3000);
            MainPage.Driver.Navigate().Back();
            mainPage = new MainPage();

            mainPage.Link_setMainPage();
            Thread.Sleep(3000);
            MainPage.Driver.Navigate().Back();
            mainPage = new MainPage();

            mainPage.Link_lookSite();
            Thread.Sleep(3000);
            MainPage.Driver.Navigate().Back();
            mainPage = new MainPage();

            mainPage.Link_vidgets();
            Thread.Sleep(3000);
            MainPage.Driver.Navigate().Back();
            mainPage = new MainPage();

            mainPage.Link_menu();
            Thread.Sleep(3000);
            MainPage.Driver.Navigate().Back();
            mainPage = new MainPage();

            mainPage.Link_turnOffComments();
            Thread.Sleep(3000);
            MainPage.Driver.Navigate().Back();
            mainPage = new MainPage();
            
            mainPage.Link_learnMore();
            Thread.Sleep(3000);
            MainPage.Driver.Navigate().Back();
            mainPage = new MainPage();

            mainPage.Button_header_close();
            Thread.Sleep(3000);
        }

        //Testing block news of main page 
        public void ClickLinksInBlockNews()
        {
            Thread.Sleep(3000);

            mainPage.click_Link_1();
            Thread.Sleep(3000);
            MainPage.Driver.Navigate().Back();
            mainPage = new MainPage();
            
            mainPage.click_Link_2();
            MainPage.Driver.Navigate().Back();
            Thread.Sleep(3000);
            mainPage = new MainPage();

            mainPage.click_Link_3();
            MainPage.Driver.Navigate().Back();
            Thread.Sleep(3000);
            mainPage = new MainPage();

            mainPage.click_Link_4();
            MainPage.Driver.Navigate().Back();
            Thread.Sleep(3000);
            mainPage = new MainPage();
            
            mainPage.click_Link_meetings();
            MainPage.Driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/");
            Thread.Sleep(3000);
            mainPage = new MainPage();

            mainPage.click_Link_wordcamp();
            MainPage.Driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/");
            Thread.Sleep(3000);
            mainPage = new MainPage();

            mainPage.click_Link_news();
            MainPage.Driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/");
            Thread.Sleep(3000);
            mainPage = new MainPage();

            mainPage.Button_edit();
            MainPage.Driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/");
            Thread.Sleep(3000);
            mainPage = new MainPage();
            MainPage.Driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/");
            Thread.Sleep(3000);
            mainPage = new MainPage();

            MainPage.Driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/");
            Thread.Sleep(3000);
            mainPage = new MainPage();
            mainPage.Button_cancel();
        }
        public void write_to_input_headline_in_quickDrafts(string str)
        {
            Thread.Sleep(1500);
            mainPage.click_on_input_in_headline();
            mainPage.clear_input_in_headline();
            mainPage.sendKeys_in_input_in_headline(str);
        }
        public void write_to_input_content_in_quickDrafts(string str)
        {
            Thread.Sleep(1500);
            mainPage.click_on_input_Content();
            mainPage.clear_input_Content();
            mainPage.sendKeys_in_input_Content(str);
        }
        public void click_on_button_save_in_quick_drafts()
        {
            Thread.Sleep(1500);
            mainPage.Button_save();
        }
        public void write_to_inputTown_in_news(string str)
        {
            Thread.Sleep(1500);
            mainPage.click_on_town_input();
            mainPage.clear_town_input();
            mainPage.sendKeys_in_town_input(str);
        }
        public void click_button_send_inNews()
        {
            Thread.Sleep(1500);
            mainPage.Button_send();
        }

    }
}

