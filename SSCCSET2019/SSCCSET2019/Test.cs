using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SSCCSET2019.Pages.HomePage;
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
            AtGlance at = new AtGlance(driver);
            
          
        }
        
      
        
    }
}