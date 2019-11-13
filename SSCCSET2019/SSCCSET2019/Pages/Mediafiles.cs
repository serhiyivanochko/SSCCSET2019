using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

    namespace SSCCSET2019.Pages { 
    class Mediafiles
    {
        IWebDriver driver;
        public void BrowserStart()
        {
            driver = new FirefoxDriver();
        }
        private IWebElement media__lib;
        private IWebElement add_new;
        private SelectElement all_mediafiles;
        private IWebElement filter;
        private IWebElement screen_setting;
        private IWebElement search_object;
        private IWebElement help;
        public Mediafiles(){
            media__lib = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/h1"));
            add_new= driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/a"));
            all_mediafiles =new SelectElement(driver.FindElement(By.Id("attachment-filter")));
            filter = driver.FindElement(By.Id("post-query-submit"));
            screen_setting = driver.FindElement(By.Id("show-settings-link"));
            search_object = driver.FindElement(By.Id("media - search - input"));
            help = driver.FindElement(By.Id("contextual - help - link"));
        }
        public void ClickrSearchObjecField()
        {
            search_object.Click();
        }
        public void ClearSearchObjecField()
        {
            search_object.Clear();
        }
        public void InputSearchObjecField(string data)
        {
            search_object.SendKeys(data);
        }
        public void ClickFilter()
        {
            filter.Click();
        }
        public void AddNewElement()
        {
            add_new.Click();
        }
        public void DeselectMediafiles()
        {
            all_mediafiles.DeselectAll();
        }
        public SettingScreen ScreenSettingClick()
        {
            screen_setting.Click();
            return new SettingScreen();
        }

    }
    class SettingScreen
    {
        IWebDriver driver;
        public void BrowserStart()
        {
            driver = new FirefoxDriver();
        }
        private IWebElement author;
        private IWebElement downloaded_for;
        private IWebElement coments;
        private IWebElement date;
        private IWebElement numbers_of_notes;
        private IWebElement apply;

        public SettingScreen()
        {
            author = driver.FindElement(By.Name("author-hide"));
            downloaded_for = driver.FindElement(By.Name("parent-hide"));
            coments = driver.FindElement(By.Name("coments-hide"));
            date = driver.FindElement(By.Name("date-hide"));
            numbers_of_notes = driver.FindElement(By.Id("upload_per_page"));
            apply = driver.FindElement(By.Name("screen_options_apply")); 
        }
        public void AuthorSubmit()
        {
            author.Click();
        }
        public void DownloadedForSubmit()
        {
            downloaded_for.Click();
        }
        public void ComentrSubmit()
        {
            coments.Click();
        }
        public void DateSubmit()
        {
            date.Click();
        }
        public void InputNumbersOfNotes(string number)
        {
            numbers_of_notes.SendKeys(number);
        }
        public void ApplyClick()
        {
            apply.Click();
        }
    }
    class AddNew
    {
        IWebDriver driver;
        public void BrowserStart()
        {
            driver = new FirefoxDriver();
        }
        private IWebElement author;
        private IWebElement downloaded_for;
        private IWebElement coments;
        private IWebElement date;
        private IWebElement numbers_of_notes;
        private IWebElement apply;

        public AddNew()
        {
            author = driver.FindElement(By.Name("author-hide"));
            downloaded_for = driver.FindElement(By.Name("parent-hide"));
            coments = driver.FindElement(By.Name("coments-hide"));
            date = driver.FindElement(By.Name("date-hide"));
            numbers_of_notes = driver.FindElement(By.Id("upload_per_page"));
            apply = driver.FindElement(By.Name("screen_options_apply"));
        }
    }
}
