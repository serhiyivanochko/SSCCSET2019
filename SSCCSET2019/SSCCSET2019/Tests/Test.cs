using NUnit.Framework;
using OpenQA.Selenium;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Logic.LoginPageLogic;
using System.Threading;

namespace SSCCSET2019.Tests.Test
{
    [TestFixture()]
    class Test
    {
        [SetUp]
        public void Setup()
        {
            
        }
        [Test]
        public void TestCase()
        {
            LoginPageLogic login = new LoginPageLogic();
            login.LogInWordPress("root", "root");
        }
        [TearDown]
        public void Close()
        {
            Driver.GetDriver().Close();
        }
    }
}