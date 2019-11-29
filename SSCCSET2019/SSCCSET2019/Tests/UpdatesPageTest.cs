using NUnit.Framework;
using OpenQA.Selenium;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Data.ApplicationSource;
using SSCCSET2019.Pages;
using SSCCSET2019.Logic;
using OpenQA.Selenium.Chrome;
using System.Threading;

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
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Test()
        {
            LoginPageLogic log1 = new LoginPageLogic();
            log1.Login();
            Thread.Sleep(1000) ;
            UpdatesPageLogic up1 = new UpdatesPageLogic();
            up1.MainUpdatesCheck();
            string actualUpdatesCheck = driver.Url;
            string expectedUpdatesCheck = "http://localhost/wp1/wp-admin/update-core.php?force-check=1";
            Assert.AreEqual(actualUpdatesCheck, expectedUpdatesCheck);
            /*up1.AboutWordpress();
            string actualAbout = driver.Url;
            string expectedAbout = "http://localhost/wp1/wp-admin/about.php";
            Assert.AreEqual(actualAbout, expectedAbout);
            up1.UpdatePlugins();
            string actualUpdatePlugins = driver.Url;
            string expectedUpdatePlugins = "http://localhost/wp1/wp-admin/update-core.php?action=do-plugin-upgrade";
            Assert.AreEqual( actualUpdatePlugins, expectedUpdatePlugins);*/
        }
        [TearDown]
        public void TearDown()
        {
            Driver.GetDriver().Close();
        }
    }
}
