using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSCCSET2019.Pages;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Data.ApplicationSource;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;

namespace SSCCSET2019.Logic
{
    class LoginPageLogic
    {
        LoginPage loginPage;
        public LoginPageLogic()
        {
            ApplicationSource.SetBrowser("chrome");
            var driver = Driver.GetDriver();
            loginPage = new LoginPage(driver);
        }
        public void Login()
        {
            loginPage.LoginClick();
            loginPage.LoginClear();
            loginPage.LoginInput();
            loginPage.PasswordClick();
            loginPage.PasswordClear();
            loginPage.PasswordInput();
            loginPage.SubmmitBotton();
            //return ?????;
        }
    }
}
