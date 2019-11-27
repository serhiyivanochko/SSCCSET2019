using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SSCCSET2019.Pages;

namespace SSCCSET2019.Logic
{
    class MainPageLogic
    {

        public MainPage mainPage = new MainPage();

        // Logic for testing MainPage header

        public void ClickingHeaderMainPage()
        {
            Thread.Sleep(1500);
            mainPage.buttonClick();
            mainPage.clickOn_Link_theme();
            mainPage.Link_firstRecord();
            mainPage.Link_createPage();
            mainPage.Link_setMainPage();
            mainPage.Link_lookSite();
            mainPage.Link_vidgets();
            mainPage.Link_menu();
            mainPage.Link_turnOffComments();
            mainPage.Link_learnMore();
            mainPage.Button_header_close();
        }
        //Testing block news of main page 
        public void ClickLinksInBlockNews()//тільки клік по лінках
        {
            Thread.Sleep(1500);
            mainPage.click_Link_1();
            mainPage.click_Link_2();
            mainPage.click_Link_3();
            mainPage.click_Link_4();
            mainPage.click_Link_meetings();
            mainPage.click_Link_wordcamp();
            mainPage.click_Link_news();
            mainPage.Button_edit();
            mainPage.Button_send();
            mainPage.Button_cancel();
        }
        public void write_to_input_headline_in_quickDrafts(string str)
        {
            Thread.Sleep(5000);
            mainPage.click_on_input_in_headline();
            mainPage.clear_input_in_headline();
            mainPage.sendKeys_in_input_in_headline(str);
        }
        public void write_to_input_content_in_quickDrafts(string str)
        {
            Thread.Sleep(5000);
            mainPage.click_on_input_Content();
            mainPage.clear_input_Content();
            mainPage.sendKeys_in_input_Content(str);
        }
        public void click_on_button_save_in_quick_drafts()
        {
            mainPage.Button_save();
        }
        public void write_to_inputTown_in_news(string str)
        {
            Thread.Sleep(5000);
            mainPage.click_on_town_input();
            mainPage.clear_town_input();
            mainPage.sendKeys_in_town_input(str);
        }
        public void click_button_send_inNews()
        {
            mainPage.Button_send();
        }

    }
}

