using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SSCCSET2019.Pages;

namespace SSCCSET2019.Pages
{
    class PostVisibility : AddNewPostsWithSettings
    {
        public PostVisibility(IWebDriver driver) : base(driver)
        {
            publicVisibility = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[5]/div/div/div/div/fieldset/div[1]/label"));
            privateVisibility = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[5]/div/div/div/div/fieldset/div[2]/label"));
            passwordProtectedVisibility = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[5]/div/div/div/div/fieldset/div[3]/label"));
        }
    }
}
