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
        IWebDriver driver =  Driver.GetDriver();
        public void Login()
        {
            driver.Navigate().GoToUrl("http://localhost/wp1/wp-admin/update-core.php");
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginClick();
            loginPage.LoginClear();
            loginPage.LoginInput();
            loginPage.PasswordClick();
            loginPage.PasswordClear();
            loginPage.PasswordInput();
            loginPage.SubmmitBotton();
        }
    }
}
