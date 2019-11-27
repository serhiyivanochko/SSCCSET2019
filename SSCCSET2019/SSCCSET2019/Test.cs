using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
namespace SSCCSET2019
{
   class Help
    {
        IWebDriver driver;
        public void Start_the_bros()
        {
            driver = new FirefoxDriver();
        }

        //майстерня - головна
        private IWebElement review;
        private IWebElement navigation;
        private IWebElement markup;
        private IWebElement content;

        //майстерня - оновлення
        private IWebElement how_to_update;
        // записи - всі записи
        private IWebElement screen_content;
        private IWebElement available_actions;
        private IWebElement group_actions;
        //записи - додати категорії
        private IWebElement add_category;
        //записи - позначка
        private IWebElement add_mark;
        // медіафайли - бібліотека
        private IWebElement acc_action;
        private IWebElement add_files;
        // сторінки- всі сторінки
        private IWebElement page_mangement;
        // коментарі
        private IWebElement modern_comments;
        //вигляд - теми
        private IWebElement add_theme;
        private IWebElement theme_review_sett;
        // вигляд - віджети
        private IWebElement reuse;
        private IWebElement failed_vidgets;
        private IWebElement html_vidget;
        //вигляд - меню
        private IWebElement menu_settings;
        private IWebElement edit_menu;
        //плагіни / встановлені плагіни
        private IWebElement trouble_shoot;
        //плагін - додати новий
        private IWebElement add_plagin;
        //користувачі - додати користувача
        private IWebElement user_role;
        // налаштування - написання
        private IWebElement show_email;
        private IWebElement update_services;
        //налаштування - читання
        private IWebElement visibility_search;
        // налаштування - постійні посилання
        private IWebElement settings_url;
        private IWebElement private_struct;

        public Help()
        {
            review = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[1]/a"));
            navigation = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a"));
            markup = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[3]/a"));
            content = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[4]/a"));
            how_to_update = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div/div[2]/div[1]/ul/li[2]/a"));
            screen_content = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a"));
            available_actions = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[3]/a"));
            group_actions = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[4]/a"));
            add_category = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a"));
            add_mark = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a"));
            acc_action = driver.FindElement(By.CssSelector("#tab-link-actions-links > a:nth-child(1)"));
            add_files = driver.FindElement(By.CssSelector("#tab-link-attaching-files > a:nth-child(1)"));
            page_mangement = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a"));
            modern_comments = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a"));
            add_theme = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div/div[2]/div[1]/ul/li[2]/a"));
            theme_review_sett = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div/div[2]/div[1]/ul/li[3]/a"));
            reuse = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div/div[2]/div[1]/ul/li[2]/a"));
            failed_vidgets = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div/div[2]/div[1]/ul/li[3]/a"));
            html_vidget = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div/div[2]/div[1]/ul/li[4]/a"));
            menu_settings = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a"));
            edit_menu = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[3]/a"));
            trouble_shoot = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a"));
            add_plagin = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[1]/div/div[2]/div[1]/ul/li[2]/a"));
            user_role = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[1]/div/div[2]/div[1]/ul/li[2]/a"));
            show_email = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[1]/div/div[2]/div[1]/ul/li[2]/a"));
            update_services= driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[1]/div/div[2]/div[1]/ul/li[3]/a"));
            visibility_search = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[1]/div/div[2]/div[1]/ul/li[2]/a"));
            settings_url= driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[1]/div/div[2]/div[1]/ul/li[2]/a")); 
            private_struct= driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/div[1]/div/div[2]/div[1]/ul/li[3]/a"));
        }
        public Help Review_Click()
        {
            review.Click();
            return this;
        }
        public Help Navigation_Click()
        {
            navigation.Click();
            return this;
        }
        public Help Markup_Click()
        {
            markup.Click();
            return this;
        }
        public Help Content_Click()
        {
            content.Click();
            return this;
        }
        public Help How_to_update_Click()
        {
            how_to_update.Click();
            return this;
        }
        public Help Screen_content_Click()
        {
            screen_content.Click();
            return this;
        }
        public Help Availiable_actions_Click()
        {
            available_actions.Click();
            return this;
        }
        public Help Group_actions_Click()
        {
            group_actions.Click();
            return this;
        }
        public Help Add_category_Click()
        {
            add_category.Click();
            return this;
        }
        public Help Add_mark_Click()
        {
            add_mark.Click();
            return this;
        }
        public Help Acc_action_Click()
        {
            acc_action.Click();
            return this;
        }
        public Help AddFiles_Click()
        {
            add_files.Click();
            return this;
        }
        public Help Page_managment_Click()
        {
            page_mangement.Click();
            return this;
        }
        public Help Modern_comments_Click()
        {
            modern_comments.Click();
            return this;
        }
        public Help Add_theme_Click()
        {
            add_theme.Click();
            return this;
        }
        public Help Theme_review_sett_Click()
        {
            theme_review_sett.Click();
            return this;
        }
        public Help Reuse_Click()
        {
            reuse.Click();
            return this;
        }
        public Help Failed_vidgets_Click()
        {
            failed_vidgets.Click();
            return this;
        }
        public Help Html_vidget_Click()
        {
            html_vidget.Click();
            return this;
        }
        public Help Menu_settings_Click()
        {
            menu_settings.Click();
            return this;
        }
        public Help Edit_menu_Click()
        {
            edit_menu.Click();
            return this;
        }
        public Help Trouble_shoot_Click()
        {
            trouble_shoot.Click();
            return this;
        }
        public Help Add_plagin_Click()
        {
            add_plagin.Click();
            return this;
        }
        public Help User_rolen_Click()
        {
            user_role.Click();
            return this;
        }
        public Help Show_email_Click()
        {
            show_email.Click();
            return this;
        }
        public Help Update_services_Click()
        {
            update_services.Click();
            return this;
        }
        public Help Visibility_search_Click()
        {
            visibility_search.Click();
            return this;
        }
        public Help Settings_url_Click()
        {
            settings_url.Click();
            return this;
        }
        public Help Private_struct_Click()
        {
            private_struct.Click();
            return this;
        }
    }
}
