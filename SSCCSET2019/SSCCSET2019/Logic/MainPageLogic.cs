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
        public void write_to_inputTown_in_news()
        {
            mainPage.click_on_town_input();
            mainPage.clear_town_input();
            mainPage.sendKeys_in_town_input("Lviv");
        }
        public void clicking_buttons_in_header()
        {
            mainPage.buttonClick();
            mainPage.clickOn_Link_theme();
            mainPage.Button_header_close();
        }

        //Login

        public void login()
        { 
            MainPage.Driver.FindElement(By.Id("user_login")).SendKeys("vlodkomickovich@gmail.com");
            MainPage.Driver.FindElement(By.Id("user_pass")).SendKeys("vlodko27");
            MainPage.Driver.FindElement(By.Id("wp-submit")).Click();
        }
    }
}

