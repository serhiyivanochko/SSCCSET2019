using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SSCCSET2019.Pages.Posts
{
    class Help : Tags
    {
        private IWebDriver driver;

        public Help(IWebDriver driver) : base(driver)
        {
            
        }
}
