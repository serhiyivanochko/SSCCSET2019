using NUnit.Framework;
using OpenQA.Selenium;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Data.ApplicationSource;
using SSCCSET2019.Pages;
using SSCCSET2019.Logic;
using OpenQA.Selenium.Chrome;

namespace SSCCSET2019.Tests
{
    [TestFixture]
    class UpdatesPageTest
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = Driver.GetDriver();
        }
        [Test]
        public void Test()
        {
            LoginPageLogic log1 = new LoginPageLogic();
            log1.Login();
            //UpdatesPageLogic up1 = new UpdatesPageLogic();
            //up1.MainUpdatesCheck();
        }
        [TearDown]
        public void TearDown()
        {
            Driver.GetDriver().Close();
        }
    }
}
