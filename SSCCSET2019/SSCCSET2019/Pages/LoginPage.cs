using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SSCCSET2019.Pages
{
    class LoginPage
    {
        IWebDriver driver;
        IWebElement login;
        IWebElement password;
        IWebElement submmit;
        public LoginPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            login = driver.FindElement(By.Id("user_login"));
            password = driver.FindElement(By.Id("user_pass"));
            submmit = driver.FindElement(By.Id("wp-submit"));
        }
        public LoginPage LoginClick()
        {
            login.Click();
            return this;
        }
        public LoginPage LoginClear()
        {
            login.Clear();
            return this;
        }
        public LoginPage LoginInput()
        {
            login.SendKeys("oleh619");
            return this;
        }
        public LoginPage PasswordClick()
        {
            password.Click();
            return this;
        }
        public LoginPage PasswordClear()
        {
            password.Clear();
            return this;
        }
        public LoginPage PasswordInput()
        {
            password.SendKeys("olehinwordpress");
            return this;
        }
        public LoginPage SubmmitBotton()
        {
            submmit.Click();
            return this;
        }
    }
}
