using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSCCSET2019.Pages;

namespace SSCCSET2019
{
    class CategorySix : AddNewPostsWithSettings
    {
        public CategorySix(IWebDriver driver) : base(driver)
        {
            
            checkboxControlFour = driver.FindElement(By.XPath(@"//*[@id='inspector-checkbox-control-2']"));
            checkboxControlFive = driver.FindElement(By.XPath(@"//*[@id='inspector-checkbox-control-3']"));

        }
    }
}
