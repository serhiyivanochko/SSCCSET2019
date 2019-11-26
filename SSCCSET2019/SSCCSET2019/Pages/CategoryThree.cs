using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SSCCSET2019.Pages;


namespace SSCCSET2019
{
    class CategoryThree : AddNewPostsWithSettings
    {
        public CategoryThree(IWebDriver driver) : base(driver)
        {
           
            addNewTag = driver.FindElement(By.ClassName("components-form-token-field__label"));
            componentsFormToken = driver.FindElement(By.ClassName("components-form-token-field__input-container"));

        }
    }
}
