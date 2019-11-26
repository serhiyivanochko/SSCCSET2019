using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SSCCSET2019.Pages;

namespace SSCCSET2019
{
    class CategoryTwo : AddNewPostsWithSettings
    {
        public CategoryTwo(IWebDriver driver) : base(driver)
        {
            checkboxThree = driver.FindElement(By.CssSelector(".editor-post-taxonomies__hierarchical-terms-input"));
            withoutHeading = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[2]/div/div/label"));
            addNewCategori = driver.FindElement(By.CssSelector(".components-button.editor-post-taxonomies__hierarchical-terms-add.is-link"));
        }
    }
}
