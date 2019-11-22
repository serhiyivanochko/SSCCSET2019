using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SSCCSET2019.Pages.HomePage;
using SSCCSET2019.Pages.LogInPage;
using SSCCSET2019.Logic;
using System;
using System.Threading;
namespace SSCCSET2019
{
    [TestFixture()]

    class Test
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
       
            driver = Driver.GetInstance().driver;
        }
        [Test]
        public void TestCase()
        {
            driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/edit-tags.php?taxonomy=post_tag");
            LoginPageLogic logIn = new LoginPageLogic();
            logIn.LogInWordPress("root", "root", driver);


        }
        
      
        
    }
}