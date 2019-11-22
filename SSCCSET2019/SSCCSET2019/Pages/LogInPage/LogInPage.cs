using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCCSET2019.Pages.LogInPage
{
    class LoginPage
    {
        private IWebElement login;
        private IWebElement pswrd;
        private IWebElement rmbrCheckBox;
        private IWebElement lgBtn;
        private IWebElement lostPswrd;
        private IWebElement back;

        public LoginPage(IWebDriver driver) 
        {
            login = driver.FindElement(By.Id("user_login"));
            pswrd = driver.FindElement(By.Id("user_pass"));
            rmbrCheckBox = driver.FindElement(By.Id("rememberme"));
            lgBtn = driver.FindElement(By.Id("wp-submit"));
            lostPswrd = driver.FindElement(By.XPath(@"//*[@id='nav']/at"));
            back = driver.FindElement(By.Id(@"//*[@id='backtoblog']/a"));
        }

        public LoginPage ClickOnLoginField()
        {
            login.Click();
            return this;
        }
        public LoginPage ClearLoginField()
        {
            login.Clear();
            return this;
        }
        public LoginPage SetTextInLoginField(string userName)
        {
            login.SendKeys(userName);
            return this;
        }
         public LoginPage ClickOnPasswordField()
        {
            pswrd.Click();
            return this;
        }
        public LoginPage ClearPasswordField()
        {
            pswrd.Clear();
            return this;
        }
        public LoginPage SetTextInPasswordField(string password)
        {
            pswrd.SendKeys(password);
            return this;
        }

        public void ClickSubmitButton() 
        {
            lgBtn.Click();
            //return new MainPage();
        }

        public LoginPage ClickOnCheckBox() 
        {
            rmbrCheckBox.Click();
            return this;
        }

    }
}
