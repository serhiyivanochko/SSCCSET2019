using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SSCCSET2019.Pages;
using SSCCSET2019.Pages.LogInPage;

namespace SSCCSET2019.Logic
{
    class LoginPageLogic
    {



        public void LogInWordPress(string login, string password, IWebDriver driver)
        {
            LoginPage logIn = new LoginPage(driver);            
            logIn.ClickOnLoginField();
            logIn.ClearLoginField();
            logIn.SetTextInLoginField(login);
            logIn.ClickOnPasswordField();
            logIn.ClearPasswordField();
            logIn.SetTextInPasswordField(password);
            logIn.ClickSubmitButton();
            //return new MainPage();
        }
    }
}
