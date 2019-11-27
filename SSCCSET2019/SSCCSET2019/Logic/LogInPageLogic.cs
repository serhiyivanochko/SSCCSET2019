using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Pages.LogInPage;

namespace SSCCSET2019.Logic.LoginPageLogic
{
    class LoginPageLogic
    {
        IWebDriver driver = Driver.GetDriver();
        public void LogInWordPress(string login, string password)
        {
            driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/edit-tags.php?taxonomy=post_tag");
            LoginPage logIn = new LoginPage(driver);            
            logIn.ClickOnLoginField();
            logIn.ClearLoginField();
            logIn.SetTextInLoginField(login);
            logIn.ClickOnPasswordField();
            logIn.ClearPasswordField();
            logIn.SetTextInPasswordField(password);
            logIn.ClickSubmitButton();
            //return new MainPage();
            driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/");
        }
    }
}
