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
            LoginPage logIn = new LoginPage(driver);            
            logIn.ClickOnLoginField()
            .ClearLoginField()
            .SetTextInLoginField(login)
            .ClickOnPasswordField()
            .ClearPasswordField()
            .SetTextInPasswordField(password)
            .ClickSubmitButton();
        }
    }
}
