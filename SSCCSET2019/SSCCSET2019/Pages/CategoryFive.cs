using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SSCCSET2019.Pages;

namespace SSCCSET2019
{
    class CategoryFive : AddNewPostsWithSettings
    {
        public CategoryFive(IWebDriver driver) : base(driver)
        {
 
            writeAnExecerpt = driver.FindElement(By.ClassName("components-base-control__label"));
            learnMore = driver.FindElement(By.ClassName("components-external-link"));
            textareaControl = driver.FindElement(By.ClassName("components-textarea-control__input"));
            externalLink = driver.FindElement(By.ClassName("components-external-link"));

        }
    }
}
