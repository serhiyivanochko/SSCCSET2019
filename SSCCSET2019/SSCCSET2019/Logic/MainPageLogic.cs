using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SSCCSET2019.Pages;

namespace SSCCSET2019.Logic
{
    class MainPageLogic
    {
        public MainPage mainPage = new MainPage();


        //Testing Main Page header
        /*
        public void ClickingHeaderMainPage()
        {
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
            mainPage.Button_close();
            mainPage.Button_edit();
            mainPage.Button_send();
            mainPage.Button_cancel();
            mainPage.click_Link_1();
            mainPage.click_Link_2();
            mainPage.click_Link_3();
            mainPage.click_Link_4();
            mainPage.click_Link_meetings();
            mainPage.click_Link_wordcamp();
            mainPage.click_Link_news();
        }
        public void write_to_input_headline_in_quickDrafts(string str)
        {
            mainPage.click_on_input_in_headline();
            mainPage.clear_input_in_headline();
            mainPage.sendKeys_in_input_in_headline(str);
        }
        public void write_to_input_content_in_quickDrafts(string str)
        {
            mainPage.click_on_input_Content();
            mainPage.clear_input_Content();
            mainPage.sendKeys_in_input_Content(str);
        }
        public void write_to_inputTown_in_news(string str)
        {
            mainPage.click_on_town_input();
            mainPage.clear_town_input();
            mainPage.sendKeys_in_town_input(str);
        }
         (public void clicking_buttons_in_header()
        {
            mainPage.buttonClick();
            mainPage.clickOn_Link_theme();
            mainPage.Button_header_close();
        }
         */
        //Login
        public void login()
        {
            //Тимчасове рішення поки немає нормального метода 
            MainPage.Driver.FindElement(By.Id("user_login")).SendKeys("vlodkomickovich@gmail.com");
            MainPage.Driver.FindElement(By.Id("user_pass")).SendKeys("vlodko27");
            MainPage.Driver.FindElement(By.Id("wp-submit")).Click();
        }
    
    }
}

