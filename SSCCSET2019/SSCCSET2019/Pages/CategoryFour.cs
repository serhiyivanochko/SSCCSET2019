using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SSCCSET2019.Pages;

namespace SSCCSET2019
{
    class CategoryFour : AddNewPostsWithSettings
    {
        public CategoryFour(IWebDriver driver) : base(driver)
        {           
            buttonFeaturedImage = driver.FindElement(By.CssSelector(".components-button.editor-post-featured-image__toggle"));
        }
    }
}
